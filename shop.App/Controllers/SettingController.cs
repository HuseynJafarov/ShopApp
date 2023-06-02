using Microsoft.AspNetCore.Mvc;
using Service.DTOs.Setting;
using Service.Service.Interface;
using System.ComponentModel.DataAnnotations;

namespace shop.App.Controllers
{
    public class SettingController: AppController
    {
        private readonly ISettingService _settingService;

        public SettingController(ISettingService settingService)
        {
            _settingService = settingService;
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody]SettingCreateAndUpdateDto data)
        {
            try
            {
                await _settingService.CreateAsync(data);
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
            
            return Ok(await _settingService.GetAllAsync());
        }

        [HttpPost]
        public async Task<IActionResult> SoftDelete([Required]int id)
        {
            try
            {
                await _settingService.SoftDeleteAsync(id);
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
                await _settingService.DeleteAsync(id);
                return Ok();
            }
            catch (NullReferenceException)
            {
                return NotFound();
            }
        }

        [HttpPut]
        [Route("{id}")]
        public async Task<IActionResult> Update([FromRoute][Required] int id, SettingCreateAndUpdateDto data)
        {
            try
            {
                await _settingService.UpdateAsync(id, data);
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
            
            return Ok(await _settingService.SerachAsync(searchData));
        }
    }
}
