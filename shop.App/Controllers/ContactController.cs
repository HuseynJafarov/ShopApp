using Microsoft.AspNetCore.Mvc;
using Service.DTOs.Contact;
using Service.Service.Interface;

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
    }
}
