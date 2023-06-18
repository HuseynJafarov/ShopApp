using Microsoft.AspNetCore.Mvc;
using Service.DTOs.Author;
using Service.Service.Interface;
using System.ComponentModel.DataAnnotations;

namespace shop.App.Controllers
{
    public class AuthorController:AppController
    {
        private readonly IAuthorService _service;

        public AuthorController(IAuthorService authorService)
        {
            _service = authorService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await _service.GetAllAsyncWithCarts());
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] AuthorCreateAndUpdateDto author)
        {
            await _service.CreateAsync(author);
            return Ok();
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<IActionResult> GetById([Required]int id)
        {
            return Ok(await _service.GetByIdAsyncWithCarts(id));
        }

        [HttpPost]
        public async Task<IActionResult> SoftDelete([Required] int id)
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

        [HttpPut]
        [Route("{id}")]
        public async Task<IActionResult> Update([Required][FromRoute] int id,  AuthorCreateAndUpdateDto author)
        {
            try
            {
                await _service.UpdateAsync(id, author);
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
