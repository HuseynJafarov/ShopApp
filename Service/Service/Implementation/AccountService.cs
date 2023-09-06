using AutoMapper;
using Domain.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Repository.Data;
using Service.DTOs.Account;
using Service.Service.Interface;
using Services.DTOs.Account;
using Services.Helpers;
using Services.Helpers.Enums;
using Services.Helpers.Responses;
using System.Data;


namespace Service.Service.Implementation
{
    public class AccountService : IAccountService
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly IMapper _mapper;
        private readonly IEmailService _emailService;
        private readonly ITokenService _tokenService;

        public AccountService(UserManager<AppUser> userManager,
            RoleManager<IdentityRole> roleManager,
            IMapper mapper,
            IEmailService emailService,
            ITokenService tokenService)
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _mapper = mapper;
            _emailService = emailService;
            _tokenService = tokenService;
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

            string token = _tokenService.GenerateJwtToken(dbUser.Id,dbUser.UserName,dbUser.Email ,roles.ToList());

            LoginResponse loginResponse = new()
            {
                Token = token,
                Errors = null,
                StatusMessage = "Success"
            };

            return  loginResponse;

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

        public async Task AddRoleToUserAsync(UserRoleDto model)
        {
            var user = await _userManager.FindByIdAsync(model.UserId);
            var role = await _roleManager.FindByIdAsync(model.UserId);

            await _userManager.AddToRoleAsync(user, role.ToString());
        }

        public async Task<IEnumerable<string>> GetUserRole(string email)
        {
            var user = await _userManager.FindByEmailAsync(email);
            var roles = await _userManager.GetRolesAsync(user);
            return roles;
        }

        public async Task ChangeRoleAsync(string id)
        {
            var user = await _userManager.FindByIdAsync(id);
            var role = await _userManager.GetRolesAsync(user);

            if (role[0] == "Admin" )
            {
                await _userManager.AddToRoleAsync(user, "Member");
                await _userManager.RemoveFromRoleAsync(user, "Admin");
            }
            if (role[0] == "Member")
            {
                await _userManager.AddToRoleAsync(user, "Admin");
                await _userManager.RemoveFromRoleAsync(user, "Member");
            }
        }

        public async Task ChangePassword(AppUser appUser, ChangePasswordDto changePasswordDto)
        {
            var appuse = await _userManager.FindByIdAsync(appUser.Id);

            //var result = await _userManager.RemovePasswordAsync(appuse);
            //result = await _userManager.AddPasswordAsync(appuse, updatePasswordDto.Password);

            await _userManager.ChangePasswordAsync(appuse, changePasswordDto.Password, changePasswordDto.NewPassword);
            var mappedUser = _mapper.Map(changePasswordDto, appuse);
            await _userManager.UpdateAsync(mappedUser);
        }

        public async Task<UserDto> GetUserByEmailAsync(string email)
        {
            var user = await _userManager.FindByEmailAsync(email);
            var mappedUser = _mapper.Map<UserDto>(user);
            return mappedUser;
        }

        
    }
}
