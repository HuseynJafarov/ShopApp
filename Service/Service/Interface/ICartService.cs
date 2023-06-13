using Service.DTOs.Cart;


namespace Service.Service.Interface
{
    public interface ICartService
    {
        Task CreateAsync(CartCreateAndUpdateDto cart);
        Task<List<CartListDto>> GetAllAsyncWithAuthor();
        Task DeleteAsync(int id);
        Task SoftDeleteAsync(int id);
        Task UpdateAsync(int id, CartCreateAndUpdateDto cart);
        Task<List<CartListDto>> SerachAsync(string? searchText);
    }
}
