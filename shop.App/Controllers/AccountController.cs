using Microsoft.AspNetCore.Mvc;
using Service.DTOs.Account;
using Service.Service.Interface;

namespace shop.App.Controllers
{
    public class AccountController:AppController
    {
        private readonly IAccountService _accountService;

        public AccountController(IAccountService accountService)
        {
            _accountService = accountService;
        }

        [HttpPost]
        public async Task<ApiResponse> Register([FromBody] RegisterDto register)
        {
            return await _accountService.RegisterAsync(register);
        }

        //[HttpPost]
        //public async Task<IActionResult> Register([FromBody] RegisterDto register)
        //{
        //    return Ok(await _accountService.RegisterAsync(register));
        //}


        [HttpPost]
        public async Task<IActionResult> Login([FromBody] LoginDto login)
        {
            var result = await _accountService.LoginAsync(login);
            return Ok(result);
        }
    }
}
