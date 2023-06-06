using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Repositories.Interface
{
    public interface ICartsRepository : IRepository<Carts>
    {
        Task<List<Carts>> GetAllWithAuthor();
  
    }
}
