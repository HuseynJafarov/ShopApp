using Service.DTOs.Cart;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Service.Interface
{
    public interface IAuthorService
    {
        Task<List<CartListDto>> GetAllAsyncWithCarts();
    }
}
