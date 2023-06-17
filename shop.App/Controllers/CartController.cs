using Microsoft.AspNetCore.Mvc;
using Service.DTOs.Cart;
using Service.Service.Interface;
using System.ComponentModel.DataAnnotations;

namespace shop.App.Controllers
{


    public class CartController: AppController
    {
        private readonly ICartService _cartService;

        public CartController(ICartService cartService)
        {
            _cartService = cartService;
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromForm] CartCreateAndUpdateDto cart)
        {
            try
            {
                 await _cartService.CreateAsync(cart);
                 return Ok();
            }
              catch (NullReferenceException)
            {
                return BadRequest(new { ErrorMessage = "Not Created" });
            }
        }


        [HttpGet]
        public async Task<IActionResult> GetAllWithAuthor()
        {
            try
            {
                var data = await _cartService.GetAllAsync();
                return Ok(data);
            }
            catch (Exception)
            {
                return NotFound("No records found!");
            }
        }

        [HttpGet]
        public async Task<IActionResult> GetWithAuthor([Required] int id)
        {
            try
            {
                var data = await _cartService.GetByIdAsync(id);
                return Ok(data);
            }
            catch (Exception)
            {
                return NotFound("No records found!");
            }
        }

        [HttpDelete]
        public async Task<IActionResult> Delete([Required] int id)
        {
            try
            {
                await _cartService.DeleteAsync(id);
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
                await _cartService.SoftDeleteAsync(id);
                return Ok();
            }
            catch (NullReferenceException)
            {

                return NotFound();
            }
        }

        [HttpPut]
        [Route("{id}")]
        public async Task<IActionResult> Update([FromRoute][Required]int id, [FromForm]CartCreateAndUpdateDto cart)
        {
            try
            {
                await _cartService.UpdateAsync(id, cart);
                return Ok();

            }   
            catch (NullReferenceException)
            {

                return BadRequest(new { ErrorMessage = "Not Update" });
            }
        }

        [HttpGet]
        public async Task<IActionResult> Search(string? searchText)
        {

                return Ok(await _cartService.SerachAsync(searchText));
        }
    }
}
