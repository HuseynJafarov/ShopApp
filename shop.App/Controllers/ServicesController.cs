using Microsoft.AspNetCore.Mvc;
using Service.DTOs.HeroSlider;
using Service.DTOs.Services;
using Service.Service.Interface;
using System.ComponentModel.DataAnnotations;

namespace shop.App.Controllers
{
    public class ServicesController: AppController
    {
        private readonly IServicesService _servicesService;

        public ServicesController(IServicesService servicesService)
        {
            _servicesService = servicesService;
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] ServicesCreateAndUpdateDto data)
        {
            await _servicesService.CreateAsync(data);

            return Ok();
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            
            return Ok(await _servicesService.GetAllAsync());
        }

        [HttpDelete]
        public async Task<IActionResult> Delete([Required] int id)
        {
            try
            {
                await _servicesService.DeleteAsync(id);
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
                await _servicesService.SoftDeleteAsync(id);
                return Ok();
            }
            catch (NullReferenceException)
            {

                return NotFound();
            }
        }

        [HttpPut]
        [Route("{id}")]
        public async Task<IActionResult> Update([FromRoute][Required] int id, ServicesCreateAndUpdateDto data)
        {
            try
            {
                await _servicesService.UpdateAsync(id, data);
                return Ok();

            }
            catch (NullReferenceException)
            {

                return NotFound();
            }
        }

        [HttpGet]
        public async Task<IActionResult> Search(string? searchText)
        {
            
            return Ok(await _servicesService.SerachAsync(searchText));
        }
    }
}
