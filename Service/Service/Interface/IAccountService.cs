
using Domain.Entities;
using Microsoft.AspNetCore.Identity;
using Service.DTOs.Account;
using Services.DTOs.Account;
using Services.Helpers.Responses;


namespace Service.Service.Interface
{
    public interface IAccountService
    {
        Task<RegisterResponse> RegisterAsync(RegisterDto model);
        Task<LoginResponse> LoginAsync(LoginDto model);
        Task CreateRoleAsync();
        Task<IEnumerable<IdentityRole>> GetRolesAsync();
        Task<IEnumerable<UserDto>> GetUsersAsync();
        Task AddRoleToUserAsync(UserRoleDto model);
        Task<IEnumerable<string>> GetUserRole(string email);
        Task ChangeRoleAsync(string id);
        Task ChangePassword(AppUser appUser, ChangePasswordDto changePasswordDto);
        Task<UserDto> GetUserByEmailAsync(string email);
    }
}
