using Microsoft.AspNetCore.Mvc;
using Service.DTOs.About;
using Service.Service.Interface;
using System.ComponentModel.DataAnnotations;

namespace shop.App.Controllers
{
   
    public class AboutController:AppController
    {
        private readonly IAboutService _aboutService;

        public AboutController(IAboutService aboutService)
        {
            _aboutService = aboutService;
      
        }


        [HttpPost]
        public async Task<IActionResult> Create([FromBody] AboutCreateAndUpdateDto about)
        {
            await _aboutService.CreateAsync(about);
            return Ok();
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await _aboutService.GetAllAsync());
        }

        [HttpDelete]
        public async Task<IActionResult> Delete([Required] int id)
        {
            try
            {
                await _aboutService.DeleteAsync(id);
                return Ok();
            }
            catch (NullReferenceException)
            { 
                return NotFound();
            }

        }

        [HttpPost]
        public async Task<IActionResult> SoftDelete([Required] int id)
        {
            try
            {
                await _aboutService.SoftDeleteAsync(id);
                return Ok();
            }
            catch (NullReferenceException)
            {
                return NotFound();




            }
        }

        [HttpPut]
        [Route("{id}")]
        public async Task<IActionResult> Update([FromRoute][Required] int id, AboutCreateAndUpdateDto about)
        {
            try
            {
                await _aboutService.UpdateAsync(id, about);
                return Ok();



            }
            catch (NullReferenceException)
            {
                return NotFound();

            }
        }

        [HttpGet]
        public async Task<IActionResult> Search(string? search)
        {
            return Ok(await _aboutService.SerachAsync(search));

        }

    }
}
