using Domain.Entities;
using MailKit.Net.Smtp;
using MailKit.Security;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using MimeKit;
using MimeKit.Text;
using Service.DTOs.Account;
using Service.Service.Interface;
using Services.DTOs.Account;


namespace Service.Service.Implementation
{
    public class EmailService : IEmailService
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly IWebHostEnvironment _env;

        public EmailService(UserManager<AppUser> userManager, IWebHostEnvironment env)
        {
            _userManager = userManager;
            _env = env;
        }

        public async Task ConfirmEmail(string userId, string token)
        {
            AppUser user = await _userManager.FindByIdAsync(userId);

            if (user != null)
            {
                 await _userManager.ConfirmEmailAsync(user, token);
            }
        }

        public void ForgotPassword(AppUser user, string url, ForgotPasswordDto forgotPassword)
        {
            var message = new MimeMessage();
            message.From.Add(new MailboxAddress("OnlineCourse", "huseynnj@code.edu.az"));
            message.To.Add(new MailboxAddress(user.FullName, forgotPassword.Email));
            message.Subject = "Reset Password";
            string emailbody = string.Empty;

            using (StreamReader streamReader = new StreamReader(Path.Combine(_env.WebRootPath, "Templates", "Reset.html")))
            {
                emailbody = streamReader.ReadToEnd();
            }

            emailbody = emailbody.Replace("{{fullname}}", $"{user.FullName}").Replace("{{code}}", $"{url}");
            message.Body = new TextPart(TextFormat.Html) { Text = emailbody };

            using var smtp = new SmtpClient();
            smtp.Connect("smtp.gmail.com", 587, SecureSocketOptions.StartTls);
            smtp.Authenticate("huseynnj@code.edu.az", "0557655033Hh.");
            smtp.Send(message);
            smtp.Disconnect(true);
        }

        public  void Register(RegisterDto registerDto, string link)
        {
            var message = new MimeMessage();
            message.From.Add(new MailboxAddress("OnlineCourse", "huseynnj@code.edu.az"));
            message.To.Add(new MailboxAddress(registerDto.FullName, registerDto.Email));
            message.Subject = "Confirm Email";
            string emailbody = string.Empty;

            using (StreamReader streamReader = new StreamReader(Path.Combine(_env.WebRootPath, "Templates", "Confirm.html")))
            {
                emailbody = streamReader.ReadToEnd();
            }

            emailbody = emailbody.Replace("{{code}}", $"{link}").Replace("{{fullname}}", $"{registerDto.FullName}");
            message.Body = new TextPart(TextFormat.Html) { Text = emailbody };

            using var smtp = new SmtpClient();
            smtp.Connect("smtp.gmail.com", 587, SecureSocketOptions.StartTls);
            smtp.Authenticate("huseynnj@code.edu.az", "0557655033Hh.");
            smtp.Send(message);
            smtp.Disconnect(true);

            
        }
    }
}
