using Service.DTOs.Contact;


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
