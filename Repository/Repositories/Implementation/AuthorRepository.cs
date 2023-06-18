using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Repository.Data;
using Repository.Repositories.Interface;


namespace Repository.Repositories.Implementation
{
    public class AuthorRepository : Repository<Author>, IAuthorRepository
    {
        private readonly AppDbContext _context;
        private readonly DbSet<Author> _entities;
        public AuthorRepository(AppDbContext context) :base(context) 
        {
            _context = context;
            _entities = _context.Set<Author>();
        }

        public async Task<List<Author>> GetAllWithBlogAndCarts()
        {
           var data  = await _entities
                .Where(a => !a.SoftDeleted)
                .Include(a=> a.Blog)
                .AsNoTracking()
                .Include(x => x.CartAuthors)
                .ThenInclude(x => x.Carts)
                .AsNoTracking()
                .ToListAsync();
            return data;
        }

        public async Task<Author> GetByIdWithBlogAndCart(int id)
        {
            var data = await _entities
                .Where(a => !a.SoftDeleted)
                .Include(a => a.Blog)
                .AsNoTracking()
                .Include(x => x.CartAuthors)
                .ThenInclude(x => x.Carts)
                .AsNoTracking()
                .FirstOrDefaultAsync(x=> x.Id == id);
            return data;
        }
    }
}
