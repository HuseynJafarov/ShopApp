using Microsoft.AspNetCore.Mvc;
using Service.DTOs.Event;
using Service.DTOs.HeroSlider;
using Service.Service.Interface;
using System.ComponentModel.DataAnnotations;

namespace shop.App.Controllers
{
    public class HeroSliderController :AppController
    {
        private readonly IHeroSliderService _heroSliderService;

        public HeroSliderController(IHeroSliderService heroSlider)
        {
            _heroSliderService = heroSlider;
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] HeroSliderCreateAndUpdateDto data)
        {
            await _heroSliderService.CreateAsync(data);

            return Ok();
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            
            return Ok(await _heroSliderService.GetAllAsync());
        }

        [HttpDelete]
        public async Task<IActionResult> Delete([Required] int id)
        {
            try
            {
                await _heroSliderService.DeleteAsync(id);
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
                await _heroSliderService.SoftDeleteAsync(id);
                return Ok();
            }
            catch (NullReferenceException)
            {

                return NotFound();
            }
        }

        [HttpPut]
        [Route("{id}")]
        public async Task<IActionResult> Update([FromRoute][Required] int id, HeroSliderCreateAndUpdateDto data)
        {
            try
            {
                await _heroSliderService.UpdateAsync(id, data);
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
            
            return Ok(await _heroSliderService.SerachAsync(searchText));
        }
    }
}
