using AutoMapper;
using Domain.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using Service.Service.Interface;
using Services.DTOs.Account;
using Services.Helpers;
using Services.Helpers.Enums;
using Services.Helpers.Responses;
using System.Data;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace Service.Service.Implementation
{
    public class AccountService : IAccountService
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly IMapper _mapper;
        private readonly JWTSettings _jwtSetting;

        public AccountService(IOptions<JWTSettings> jwt, UserManager<AppUser> userManager,
            RoleManager<IdentityRole> roleManager, IMapper mapper)
        {
            _jwtSetting = jwt.Value;
            _userManager = userManager;
            _roleManager = roleManager;
            _mapper = mapper;
        }
        public async Task AddRoleToUserAsync(UserRoleDto model)
        {
            var user = await _userManager.FindByIdAsync(model.UserId);
            var role = await _roleManager.FindByIdAsync(model.RoleId);
            await _userManager.AddToRoleAsync(user, role.ToString());
        }

        public async Task<IEnumerable<string>> GetRolesByUserAsync(string userId)
        {
            return await _userManager.GetRolesAsync(await _userManager.FindByIdAsync(userId));
        }

        public async Task CreateRoleAsync()
        {
            foreach (var role in Enum.GetValues(typeof(Roles)))
            {
                if (!await _roleManager.RoleExistsAsync(role.ToString()))
                {
                    await _roleManager.CreateAsync(new IdentityRole { Name = role.ToString() });
                }
            }
        }

        public async Task<IEnumerable<IdentityRole>> GetRolesAsync()
        {
            return await _roleManager.Roles.ToListAsync();
        }

        public async Task<IEnumerable<UserDto>> GetUsersAsync()
        {
            return _mapper.Map<List<UserDto>>(await _userManager.Users.ToListAsync());
        }

        public async Task<LoginResponse> LoginAsync(LoginDto model)
        {
            var dbUser = await _userManager.FindByEmailAsync(model.Email);

            if(dbUser == null)
            {
                LoginResponse response = new()
                {
                    Token = null,
                    Errors = new List<string> { "User does not exist" },
                    StatusMessage = "Failed"
                };
                return response;
            }

            if (!await _userManager.CheckPasswordAsync(dbUser, model.Password))
            {
                LoginResponse response = new()
                {
                    Token = null,
                    Errors = new List<string> { "Invalid password" },
                    StatusMessage = "Failed"
                };
                return response;
            } 
            
            var roles = await _userManager.GetRolesAsync(dbUser);

            string token = GenerateJwtToken(dbUser.UserName,dbUser.Id ,roles.ToList());

            LoginResponse loginResponse = new()
            {
                Token = token,
                Errors = null,
                StatusMessage = "Success"
            };

            return  loginResponse;

        }

        public async Task<RegisterResponse> RegisterAsync(RegisterDto model)
        {
            AppUser user = _mapper.Map<AppUser>(model);

            IdentityResult result = await _userManager.CreateAsync(user, model.Password);

            if (!result.Succeeded)
            {
                RegisterResponse response = new()
                {
                    Errors = result.Errors.Select(m => m.Description).ToList(),
                    StatusMessage = "Failed"
                };

                return response;
            }

            await _userManager.AddToRoleAsync(user, Roles.Member.ToString());

             
            return new RegisterResponse { Errors = null, StatusMessage = "Success" };
        }


        private string GenerateJwtToken(string username, string userId,List<string> roles)
        {
            var claims = new List<Claim>
            {
            new Claim(JwtRegisteredClaimNames.Sub, userId),
            new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
            new Claim(ClaimTypes.NameIdentifier, username)
            };

            roles.ForEach(role =>
            {
                claims.Add(new Claim(ClaimTypes.Role, role));
            });

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_jwtSetting.Key));
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
            var expires = DateTime.Now.AddDays(Convert.ToDouble(_jwtSetting.ExpireDays));

            var token = new JwtSecurityToken(
                _jwtSetting.Issuer,
                _jwtSetting.Auidience,
                claims,
                expires: expires,
                signingCredentials: creds
            );

            return new JwtSecurityTokenHandler().WriteToken(token);
        }
    }
}
