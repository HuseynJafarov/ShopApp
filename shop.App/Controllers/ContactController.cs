using Microsoft.AspNetCore.Mvc;
using Service.DTOs.Cart;
using Service.DTOs.Contact;
using Service.Service.Implementation;
using Service.Service.Interface;
using System.ComponentModel.DataAnnotations;

namespace shop.App.Controllers
{
    public class ContactController:AppController
    {
        private readonly IContactService _contactService;

        public ContactController(IContactService contactService)
        {
            _contactService = contactService;
        }


        [HttpPost]
        public async Task<IActionResult> Create(ContactCreateAndUpdateDto contact)
        {
            await _contactService.CreateAsync(contact);
            return Ok();
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            
            return Ok(await _contactService.GetAllAsync());
        }

        [HttpDelete]
        public async Task<IActionResult> Delete([Required] int id)
        {
            try
            {
                await _contactService.DeleteAsync(id);
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
                await _contactService.SoftDeleteAsync(id);
                return Ok();
            }
            catch (NullReferenceException)
            {

                return NotFound();
            }
        }

        [HttpPut]
        [Route("{id}")]
        public async Task<IActionResult> Update([FromRoute][Required] int id, ContactCreateAndUpdateDto contact)
        {
            try
            {
                await _contactService.UpdateAsync(id, contact);
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
            
            return Ok(await _contactService.SerachAsync(searchText));
        }
    }
}
