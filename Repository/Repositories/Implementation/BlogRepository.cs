using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Repository.Data;
using Repository.Repositories.Interface;

namespace Repository.Repositories.Implementation
{
    public class BlogRepository: Repository<Blog>, IBlogRepository
    {
        private readonly AppDbContext _context;
        private readonly DbSet<Blog> _entities;
        public BlogRepository(AppDbContext context) : base(context)
        {
            _context = context;
            _entities = _context.Set<Blog>();
        }

        public async Task<List<Blog>> GetAllWithAuthor()
        {
            var data = await _entities
                .Where(x =>
                !x.SoftDeleted)
                .Include(_entities =>
                _entities.Author)
                .AsNoTracking()
                .ToListAsync()
                ?? throw new NullReferenceException();

            return data;
        }

        public async Task<Blog> GetByIdWithAuthor(int id)
        {
            var data = await _entities
                .Where(x =>
                    !x.SoftDeleted)
                .Include(_entities =>
                    _entities.Author)
                .AsNoTracking()
                .FirstOrDefaultAsync(x =>
                    x.Id == id)
                ?? throw new NullReferenceException();
          
            return data;
        }
    }
}
