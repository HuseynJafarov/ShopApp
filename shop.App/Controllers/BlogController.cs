using Microsoft.AspNetCore.Mvc;
using Service.DTOs.Blog;
using Service.Service.Implementation;
using Service.Service.Interface;
using System.ComponentModel.DataAnnotations;

namespace shop.App.Controllers
{
    public class BlogController: AppController
    {
        private readonly IBlogService _service;

        public BlogController(IBlogService service)
        {
            _service = service;
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromForm] BlogCreateAndUpdateDto blog)
        {
            await _service.CreateAsync(blog);
            return Ok();
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<IActionResult> GetById([Required] int id)
        {
            try
            {
                return Ok(await _service.GetByIdAsync(id));
            }
            catch (NullReferenceException)
            {
                return NotFound();
            }
        }   

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await _service.GetAllAsync());
        }

        [HttpDelete]
        public async Task<IActionResult> Delete([Required] int id)
        {
            try
            {
                await _service.DeleteAsync(id);
                return Ok();
            }
            catch (NullReferenceException)
            {
                return NotFound();
            }
        }

        [HttpPost]
        public async Task<IActionResult> SoftDeleted([Required] int id)
        {
            try
            {
                await _service.SoftDeleteAsync(id);
                return Ok();
            }
            catch (NullReferenceException)
            {
                return NotFound();
            }
        }

        [HttpPost]
        [Route("{id}")]
        public async Task<IActionResult> Update([FromRoute][Required] int id ,[FromForm]BlogCreateAndUpdateDto data)
        {
            try
            {
                await _service.UpdateAsync(id, data);
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
            return Ok(await _service.SerachAsync(search));
        }

    }
}
