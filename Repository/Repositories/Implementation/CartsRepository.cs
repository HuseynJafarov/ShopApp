using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Repository.Data;
using Repository.Repositories.Interface;
using System.Linq.Expressions;

namespace Repository.Repositories.Implementation
{
    public class CartsRepository : Repository<Carts>,  ICartsRepository
    {
        private readonly AppDbContext _context;
        private readonly DbSet<Carts> _entities;

        public CartsRepository(AppDbContext context) :base(context) 
        {
            _context = context;
            _entities = _context.Set<Carts>();
        }

        public async Task<List<Carts>> GetAllWithAuthor()
        {
            var data = await _entities.Include(x => x.CartAuthors).ThenInclude(x => x.Author).ToListAsync();
            return data;
        }
    }
}
