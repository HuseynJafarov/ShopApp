using Service.DTOs.About;
using Service.DTOs.Cart;
using Service.DTOs.Contact;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Service.Interface
{
    public interface IContactService
    {
        Task CreateAsync(ContactCreateAndUpdateDto contact);
        Task<List<ContactListDto>> GetAllAsync();
        Task DeleteAsync(int id);
        Task SoftDeleteAsync(int id);
        Task UpdateAsync(int id, ContactCreateAndUpdateDto contact);
        Task<List<ContactListDto>> SerachAsync(string? searchText);
    }
}
