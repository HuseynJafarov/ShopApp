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

        public async Task<List<Carts>> GetAllNew()
        {
            var data = await _entities
                .Where(a => !a.SoftDeleted)
                .Include(x => x.CartAuthors)
                .ThenInclude(x => x.Author)
                .ToListAsync();
            return data;
        }

        public async Task<Carts> GetNew(int id)
        {
            var data = await _entities
                .Where(a => !a.SoftDeleted)
                .Include(x => x.CartAuthors)
                .ThenInclude(x => x.Author)
                .FirstOrDefaultAsync(x=> x.Id == id);
            return data;
        }

        
    }
}
