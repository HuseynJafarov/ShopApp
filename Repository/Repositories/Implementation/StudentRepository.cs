using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Repository.Data;
using Repository.Repositories.Interface;


namespace Repository.Repositories.Implementation
{
    public class StudentRepository: Repository<Student> , IStudentRepository
    {
        private readonly AppDbContext _context;
        private readonly DbSet<Student> _entities;

        public StudentRepository(AppDbContext context) :base(context) 
        {
            _context = context;
            _entities = _context.Set<Student>();
        }

        public async Task<List<Student>> GetAllNew()
        {
            var data = await _entities
                .Where(x=> !x.SoftDeleted)
                .Include(_entities => _entities.Carts)
                .ToListAsync();
            return data;
        }
    }
}
