using Microsoft.AspNetCore.Mvc;
using Service.Service.Interface;

namespace shop.App.Controllers
{
    public class AuthorController:AppController
    {
        private readonly IAuthorService _authorService;

        public AuthorController(IAuthorService authorService)
        {
            _authorService = authorService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await _authorService.GetAllAsyncWithCarts());
        }
    }
}
