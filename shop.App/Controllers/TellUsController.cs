using Microsoft.AspNetCore.Mvc;
using Service.DTOs.Slider;
using Service.DTOs.TellUs;
using Service.Service.Implementation;
using Service.Service.Interface;
using Service.Validations.Contact;
using System.ComponentModel.DataAnnotations;

namespace shop.App.Controllers
{
    public class TellUsController:AppController
    {
        private readonly ITellusService _tellusService;

        public TellUsController(ITellusService tellusService)
        {
            _tellusService = tellusService;
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromForm] TellUsCreateAndUpdateDto data)
        {
            TellUsCreateAndUpdateDtoValidator validator = new();
            var validationResult = validator.Validate(data);

            if (!validationResult.IsValid)
            {
                return BadRequest(validationResult.Errors);
            }

            try
            {
                await _tellusService.CreateAsync(data);
                return Ok();
            }
            catch (NullReferenceException)
            {
                return NotFound();
            }

        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            
            return Ok(await _tellusService.GetAllAsync());
        }

        [HttpPost]
        public async Task<IActionResult> SoftDelete([Required] int id)
        {
            try
            {
                await _tellusService.SoftDeleteAsync(id);
                return Ok();
            }
            catch (NullReferenceException)
            {
                return NotFound();
            }

        }

        [HttpDelete]
        public async Task<IActionResult> Delete([Required] int id)
        {
            try
            {
                await _tellusService.DeleteAsync(id);
                return Ok();
            }
            catch (NullReferenceException)
            {
                return NotFound();
            }
        }


        [HttpPut]
        [Route("{id}")]
        public async Task<IActionResult> Update([FromRoute][Required] int id, TellUsCreateAndUpdateDto data)
        {
            TellUsCreateAndUpdateDtoValidator validator = new();
            var validationResult = validator.Validate(data);

            if (!validationResult.IsValid)
            {
                return BadRequest(validationResult.Errors);
            }

            try
            {
                await _tellusService.UpdateAsync(id, data);
                return Ok();
            }
            catch (NullReferenceException)
            {
                return NotFound();
            }
        }


        [HttpGet]
        public async Task<IActionResult> Search(string? searchData)
        {
            
            return Ok(await _tellusService.SerachAsync(searchData));
        }
    }
}
