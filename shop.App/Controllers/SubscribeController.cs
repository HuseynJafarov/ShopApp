using Microsoft.AspNetCore.Mvc;
using Service.DTOs.SliderBox;
using Service.DTOs.Subscribe;
using Service.DTOs.TellUs;
using Service.Service.Implementation;
using Service.Service.Interface;
using Service.Validations.Contact;
using Service.Validations.Subscribe;
using System.ComponentModel.DataAnnotations;

namespace shop.App.Controllers
{
    public class SubscribeController:AppController
    {
        private readonly ISubscribeService _subscribeService;

        public SubscribeController(ISubscribeService subscribeService)
        {
            _subscribeService = subscribeService;
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] SubscribeCreateAndUpdateDto data)
        {
            SubscribeCreateAndUpdateDtoValidator validator = new();
            var validationResult = validator.Validate(data);

            if (!validationResult.IsValid)
            {
                return BadRequest(validationResult.Errors);
            }

            try
            {
                await _subscribeService.CreateAsync(data);
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
            
            return Ok(await _subscribeService.GetAllAsync());
        }

        [HttpPost]
        public async Task<IActionResult> SoftDelete([Required] int id)
        {
            try
            {
                await _subscribeService.SoftDeleteAsync(id);
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
                await _subscribeService.DeleteAsync(id);
                return Ok();
            }
            catch (NullReferenceException)
            {
                return NotFound();
            }
        }


        [HttpPut]
        [Route("{id}")]
        public async Task<IActionResult> Update([FromRoute][Required] int id, SubscribeCreateAndUpdateDto data)
        {
            SubscribeCreateAndUpdateDtoValidator validator = new();
            var validationResult = validator.Validate(data);

            if (!validationResult.IsValid)
            {
                return BadRequest(validationResult.Errors);
            }

            try
            {
                await _subscribeService.UpdateAsync(id, data);
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
            
            return Ok(await _subscribeService.SerachAsync(searchData));
        }
    }
}
