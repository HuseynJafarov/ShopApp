using Service.DTOs.About;
using Service.DTOs.Cart;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Service.Interface
{
    public interface ICartService
    {
        Task CreateAsync(CartCreateAndUpdateDto cart);
        Task<List<CartListDto>> GetAllAsync();
        Task<List<CartListDto>> GetAllAsyncWithAuthor();
        Task DeleteAsync(int id);
        Task SoftDeleteAsync(int id);
        Task UpdateAsync(int id, CartCreateAndUpdateDto cart);
        Task<List<CartListDto>> SerachAsync(string? searchText);
    }
}
