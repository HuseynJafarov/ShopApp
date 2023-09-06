using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using Service.Service.Interface;
using Services.Helpers;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Service.Service.Implementation
{
    public class TokenService : ITokenService
    {
        private readonly JWTSettings _jwtSetting;
        
        public TokenService(IOptions<JWTSettings> jwt)
        {
            _jwtSetting = jwt.Value;
        }

        public string GenerateJwtToken(string id, string username, string email, List<string> roles)
        {
            var claims = new List<Claim>
            {
            new Claim(JwtRegisteredClaimNames.Sub, email),
            new Claim(JwtRegisteredClaimNames.Sub, username),
            new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
            new Claim(ClaimTypes.NameIdentifier, username),
            new Claim(JwtRegisteredClaimNames.UniqueName,id),
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
