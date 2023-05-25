using Microsoft.AspNetCore.Mvc;
using Service.Service.Interface;
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

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            await _tellusService.GetAllAsync();
            return Ok();
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


        [HttpGet]
        public async Task<IActionResult> Search(string? searchData)
        {
            await _tellusService.SerachAsync(searchData);
            return Ok();
        }
    }
}
