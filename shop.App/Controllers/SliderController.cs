using Microsoft.AspNetCore.Mvc;
using Service.DTOs.Slider;
using Service.DTOs.SliderBox;
using Service.Service.Interface;
using System.ComponentModel.DataAnnotations;

namespace shop.App.Controllers
{
    public class SliderController:AppController
    {
        private readonly ISliderService _sliderService;

        public SliderController(ISliderService sliderService)
        {
            _sliderService = sliderService;
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] SliderCreateAndUpdateDto data)
        {
            try
            {
                await _sliderService.CreateAsync(data);
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
            
            return Ok(await _sliderService.GetAllAsync());
        }

        [HttpPost]
        public async Task<IActionResult> SoftDelete([Required] int id)
        {
            try
            {
                await _sliderService.SoftDeleteAsync(id);
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
                await _sliderService.DeleteAsync(id);
                return Ok();
            }
            catch (NullReferenceException)
            {
                return NotFound();
            }
        }

        [HttpPut]
        [Route("{id}")]
        public async Task<IActionResult> Update([FromBody][Required] int id, SliderCreateAndUpdateDto data)
        {
            try
            {
                await _sliderService.UpdateAsync(id, data);
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
            
            return Ok(await _sliderService.SerachAsync(searchData));
        }

    }
}
