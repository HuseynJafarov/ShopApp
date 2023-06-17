using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Repository.Data;
using Repository.Repositories.Interface;


namespace Repository.Repositories.Implementation
{
    public class CartAuthorRepository : ICartAuthorRepository
    {
        private readonly AppDbContext _context;
        private readonly DbSet<CartAuthor> _entityCartAuthor;

        public CartAuthorRepository(AppDbContext context)
        {
            _context = context;
            _entityCartAuthor = _context.Set<CartAuthor>();
        }

        public async Task DeleteCartAuthor(List<CartAuthor> cartAuthors)
        {
            foreach (var item in cartAuthors)
            {
                _entityCartAuthor.Remove(item);
            }

            await _context.SaveChangesAsync();
        }
    }
}
