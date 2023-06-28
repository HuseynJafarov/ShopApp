using Service.DTOs.Basket;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Service.Interface
{
    public interface IBasketService
    {
        Task AddBasketAsync(int id);
        Task DeleteBasketAsync(int id);
        Task DeleteItemBasketAsync(int id);
        Task<int> GetBasketCountAsync();
        Task<List<BasketCartListDto>> GetBasketCartsAsync();
    }
}
