using Service.DTOs.Author;
using Service.DTOs.Cart;


namespace Service.Service.Interface
{
    public interface IAuthorService
    {
        Task<List<CartListDto>> GetAllAsyncWithCarts();
        Task CreateAsync(AuthorCreateAndUpdateDto data);
        Task<List<AuthorListDto>> GetAllAsync();
        Task DeleteAsync(int id);
        Task SoftDeleteAsync(int id);
        Task UpdateAsync(int id, AuthorCreateAndUpdateDto data);
        Task<List<AuthorListDto>> SerachAsync(string? searchText);
    }
}
