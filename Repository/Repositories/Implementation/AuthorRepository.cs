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

        public async Task<List<Author>> GetAllWithCart()
        {
           var data  = await _entities.Include(x => x.CartAuthors).ThenInclude(x => x.Carts).ToListAsync();
            return data;
        }
    }
}
