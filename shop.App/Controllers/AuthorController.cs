using Microsoft.AspNetCore.Mvc;
using Service.Service.Interface;

namespace shop.App.Controllers
{
    public class AuthorController:AppController
    {
        private readonly IAuthorService _service;

        public AuthorController(IAuthorService authorService)
        {
            _service = authorService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllWithCarts()
        {
            return Ok(await _service.GetAllAsyncWithCarts());
        }
    }
}
