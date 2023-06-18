using Service.DTOs.Author;
using Service.DTOs.Cart;


namespace Service.Service.Interface
{
    public interface IAuthorService
    {
        
        Task CreateAsync(AuthorCreateAndUpdateDto data);
        Task<List<AuthorListDto>> GetAllAsyncWithCarts();
        Task<AuthorListDto> GetByIdAsyncWithCarts(int id);
        Task DeleteAsync(int id);
        Task SoftDeleteAsync(int id);
        Task UpdateAsync(int id, AuthorCreateAndUpdateDto data);
        Task<List<AuthorListDto>> SerachAsync(string? searchText);
    }
}
