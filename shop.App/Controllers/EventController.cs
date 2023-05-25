using Microsoft.AspNetCore.Mvc;
using Service.DTOs.Cart;
using Service.DTOs.Event;
using Service.Service.Interface;
using System.ComponentModel.DataAnnotations;

namespace shop.App.Controllers
{
    public class EventController : AppController
    {
        private readonly IEventService _eventService;

        public EventController(IEventService eventService)
        {
            _eventService = eventService;
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] EventCreateAndUpdateDto data)
        {
            await _eventService.CreateAsync(data);

            return Ok();
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            await _eventService.GetAllAsync();
            return Ok();
        }

        [HttpDelete]
        public async Task<IActionResult> Delete([Required] int id)
        {
            try
            {
                await _eventService.DeleteAsync(id);
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
                await _eventService.SoftDeleteAsync(id);
                return Ok();
            }
            catch (NullReferenceException)
            {

                return NotFound();
            }
        }

        [HttpPut]
        [Route("{id}")]
        public async Task<IActionResult> Update([FromBody][Required] int id, EventCreateAndUpdateDto data)
        {
            try
            {
                await _eventService.UpdateAsync(id, data);
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
            await _eventService.SerachAsync(searchText);
            return Ok();
        }
    }
}
