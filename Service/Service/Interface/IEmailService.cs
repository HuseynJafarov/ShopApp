using Domain.Entities;
using Service.DTOs.Account;
using Services.DTOs.Account;


namespace Service.Service.Interface
{
    public interface IEmailService
    {
        void Register(RegisterDto registerDto, string link);
        Task ConfirmEmail(string userId, string token);
        void ForgotPassword(AppUser user, string url, ForgotPasswordDto forgotPassword);
    }
}
