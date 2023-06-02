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
        public async Task<IActionResult> Create([FromBody] CartCreateAndUpdateDto cart)
        {
            await _cartService.CreateAsync(cart);

            return Ok();
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            
            return Ok(await _cartService.GetAllAsync());
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
        public async Task<IActionResult> Update([FromRoute][Required]int id,CartCreateAndUpdateDto cart)
        {
            try
            {
                await _cartService.UpdateAsync(id, cart);
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
               
                return Ok(await _cartService.SerachAsync(searchText));
        }
    }
}
