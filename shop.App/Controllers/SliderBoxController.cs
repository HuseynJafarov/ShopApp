using Microsoft.AspNetCore.Mvc;
using Service.DTOs.Setting;
using Service.DTOs.SliderBox;
using Service.Service.Interface;
using System.ComponentModel.DataAnnotations;

namespace shop.App.Controllers
{
    public class SliderBoxController :AppController
    {
        private readonly ISliderBoxService _sliderBoxService;

        public SliderBoxController(ISliderBoxService sliderBoxService)
        {
            _sliderBoxService = sliderBoxService;
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] SliderBoxCreateAndUpdateDto data)
        {
            try
            {
                await _sliderBoxService.CreateAsync(data);
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
            
            return Ok(await _sliderBoxService.GetAllAsync());
        }

        [HttpPost]
        public async Task<IActionResult> SoftDelete([Required] int id)
        {
            try
            {
                await _sliderBoxService.SoftDeleteAsync(id);
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
                await _sliderBoxService.DeleteAsync(id);
                return Ok();
            }
            catch (NullReferenceException)
            {
                return NotFound();
            }
        }

        [HttpPut]
        [Route("{id}")]
        public async Task<IActionResult> Update([FromRoute][Required] int id, SliderBoxCreateAndUpdateDto data)
        {
            try
            {
                await _sliderBoxService.UpdateAsync(id, data);
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
            
            return Ok(await _sliderBoxService.SerachAsync(searchData));
        }
    }
}
