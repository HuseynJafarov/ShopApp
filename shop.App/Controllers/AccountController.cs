using Domain.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Service.DTOs.Account;
using Service.Service.Interface;
using Services.DTOs.Account;
using Services.Helpers.Responses;

namespace shop.App.Controllers
{
    public class AccountController:AppController
    {
        private readonly IAccountService _accountService;
        private readonly IEmailService _emailService;
        private readonly UserManager<AppUser> _userManager;

        public AccountController(IAccountService accountService,
            UserManager<AppUser> userManager,
            IEmailService emailService)
        {
            _accountService = accountService;
            _emailService = emailService;
            _userManager = userManager;
        }



        [HttpPost]
        [ProducesResponseType(statusCode: StatusCodes.Status200OK)]
        public async Task<IActionResult> Register([FromBody] RegisterDto register)
        {
            var response = await _accountService.RegisterAsync(register);

            AppUser user = await _userManager.FindByEmailAsync(register.Email);

            var code = await _userManager.GenerateEmailConfirmationTokenAsync(user);

            var link = Url.Action(nameof(ConfirmEmail), "Account", new { userId = user.Id, token = code }, Request.Scheme, Request.Host.ToString());

            _emailService.Register(register, link);

            return Ok(response);
        }


        [AllowAnonymous]
        [HttpPost]
        [ProducesResponseType(statusCode: StatusCodes.Status200OK)]
        public async Task<IActionResult> Login([FromBody] LoginDto login)
        {
            var result = await _accountService.LoginAsync(login);
            return Ok(result);
        }
       

        [HttpPost]
        [ProducesResponseType(statusCode: StatusCodes.Status200OK)]
        public async Task<IActionResult> CreateRole()
        {
            await _accountService.CreateRoleAsync();
            return Ok();
        }


        [HttpPost]
        [ProducesResponseType(statusCode: StatusCodes.Status200OK)]
        public async Task<IActionResult> AddRoleToUser([FromBody] UserRoleDto model)
        {
            await _accountService.AddRoleToUserAsync(model);
            return Ok();
        }

        [HttpGet]
        [ProducesResponseType(statusCode: StatusCodes.Status200OK)]
        public async Task<IActionResult> GetRolesByUser(string email)
        {
            return Ok(await _accountService.GetUserRole(email));
        }


        //[Authorize(Roles = "Admin")]
        [HttpGet]
        [ProducesResponseType(statusCode: StatusCodes.Status200OK)]
        public async Task<IActionResult> GetRoles()
        {
            return Ok(await _accountService.GetRolesAsync());
        }


        [HttpGet]
        [ProducesResponseType(statusCode: StatusCodes.Status200OK)]
        [ProducesResponseType(statusCode: StatusCodes.Status401Unauthorized)]
        public async Task<IActionResult> GetUsers()
        {
            return Ok(await _accountService.GetUsersAsync());
        }


        [HttpGet]
        [ProducesResponseType(statusCode: StatusCodes.Status200OK)]
        public async Task<IActionResult> ChangeRole(string id)
        {
            await _accountService.ChangeRoleAsync(id);
            return Ok();
        }


        [HttpPut]
        [ProducesResponseType(statusCode: StatusCodes.Status200OK)]
        public async Task<IActionResult> ChangePassword([FromRoute] string email,[FromBody] ChangePasswordDto changePasswordDto)
        {
            var appUser = await _userManager.FindByEmailAsync(email);
            await _accountService.ChangePassword(appUser, changePasswordDto);
            return Ok();
        }

        [HttpGet]
        [ProducesResponseType(statusCode: StatusCodes.Status200OK)]
        public async Task<IActionResult> ConfirmEmail(string userId, string token)
        {
            await _accountService.ConfirmEmail(userId, token);
            return Redirect("http://localhost:3000/");
        }

        [HttpGet]
        [ProducesResponseType(statusCode: StatusCodes.Status200OK)]
        public async Task<IActionResult> GetUserByEmail(string email)
        {
            return Ok(await _accountService.GetUserByEmailAsync(email));
        }

        [HttpPost]
        [ProducesResponseType(statusCode: StatusCodes.Status200OK)]
        public async Task<IActionResult> ForgotPassword([FromBody] ForgotPasswordDto forgotPassword)
        {
            var user = await _userManager.FindByEmailAsync(forgotPassword.Email);

            if(user == null) throw new Exception("User not found");

            var passwordToken = await _userManager.GeneratePasswordResetTokenAsync(user);

            //var url1 = Url.Action("ResetPassword", "Account", new { userId = user.Id, token = passwordToken }, Request.Scheme, Request.Host.ToString());
            //string url2 = Url.Action("http://localhost:3000/", "forgotpassword", new { email = user.Email, Id = user.Id, token = forgotpasswordtoken, }, Request.Scheme);
            
            string url3 = "http://localhost:3000/forgotpassword/" + user.Email + "/token=" + passwordToken;
            _emailService.ForgotPassword(user, url3, forgotPassword);

            return Ok();
        }

        [HttpPost]
        [ProducesResponseType(statusCode: StatusCodes.Status200OK)]
        public async Task<IActionResult> UpdatePassword([FromBody] UpdatePasswordDto resetPassword)
        {
            var user = await _userManager.FindByEmailAsync(resetPassword.Email);

            if (user == null) throw new Exception("User not found");

            var result =  await _userManager.ResetPasswordAsync(user, resetPassword.Token, resetPassword.Password);

            return Ok();
        }


    }
}
