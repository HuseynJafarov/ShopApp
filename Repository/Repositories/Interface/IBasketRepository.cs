using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Repositories.Interface
{
    public interface IBasketRepository
    {
        Task AddBasket(int id);
        Task<List<BasketCart>> GetBasketCarts();
        Task DeleteItemBasket(int id);
        Task<int> GetBasketCount();
        Task DeleteBasket(int id);
    }
}
