using Microsoft.AspNetCore.Mvc;
using Service.DTOs.About;
using Service.Service.Interface;
using System.ComponentModel.DataAnnotations;

namespace shop.App.Controllers
{
    public class AboutController:AppController
    {
        private readonly IAboutService _aboutService;
        private readonly IWebHostEnvironment _env;

        public AboutController(IAboutService aboutService, IWebHostEnvironment env)
        {
            _aboutService = aboutService;
            _env = env;
        }


        [HttpPost]
        public async Task<IActionResult> CreateAsync([FromBody] AboutCreateAndUpdateDto product)
        {
            await _aboutService.CreateAsync(product);
            return Ok();
        }

    }
}
