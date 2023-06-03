using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Service.Service.Interface;
using Services.DTOs.Account;
using Services.Helpers.Responses;

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
        [ProducesResponseType(statusCode: StatusCodes.Status200OK)]
        public async Task<RegisterResponse> Register([FromBody] RegisterDto register)
        {
           
            return await _accountService.RegisterAsync(register);
        }

        //[HttpPost]
        //public async Task<IActionResult> Register([FromBody] RegisterDto register)
        //{
        //    return Ok(await _accountService.RegisterAsync(register));
        //}


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
        public async Task<IActionResult> GetRolesByUser(string userId)
        {
            return Ok(await _accountService.GetRolesByUserAsync(userId));
        }

        [Authorize(Roles = "Admin")]
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

        [AllowAnonymous]
        [HttpPost]
        [ProducesResponseType(statusCode: StatusCodes.Status200OK)]
        public async Task<IActionResult> Login([FromBody] LoginDto login)
        {
            var result = await _accountService.LoginAsync(login);
            return Ok(result);
        }
    }
}
