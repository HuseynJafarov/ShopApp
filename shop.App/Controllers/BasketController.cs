using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Service.Service.Interface;
using System.ComponentModel.DataAnnotations;

namespace shop.App.Controllers
{
    public class BasketController:AppController
    {
        private readonly IBasketService _basketService;

        public BasketController(IBasketService basketService)
        {
            _basketService = basketService;
        }

        [Authorize]
        [HttpPost]
        public async Task<IActionResult> AddBasket([Required][FromQuery]int id)
        {
           
             await _basketService.AddBasketAsync(id);
             return Ok();
           
        }

        [Authorize]
        [HttpGet]
        public async Task<IActionResult> GetBasketProducts()
        {
            return Ok(await _basketService.GetBasketCartsAsync());
        }


        [Authorize]
        [HttpGet]
        public async Task<IActionResult> GetBasketCount()
        {
            return Ok(await _basketService.GetBasketCountAsync());
        }


        [Authorize]
        [HttpDelete]
        public async Task<IActionResult> DeleteBasketProduct([Required][FromQuery] int id)
        {
            await _basketService.DeleteBasketAsync(id);
            return Ok();
        }


        [Authorize]
        [HttpDelete]
        public async Task<IActionResult> DeleteBasketItemProduct([Required][FromQuery] int id)
        {
            await _basketService.DeleteItemBasketAsync(id);
            return Ok();
        }
    }
}
