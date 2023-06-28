using Service.DTOs.Basket;
using Service.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Service.Implementation
{
    public class BasketService : IBasketService
    {
        public Task AddBasketAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task DeleteBasketAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task DeleteItemBasketAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<BasketCartListDto>> GetBasketCartsAsync()
        {
            throw new NotImplementedException();
        }

        public Task<int> GetBasketCountAsync()
        {
            throw new NotImplementedException();
        }
    }
}
