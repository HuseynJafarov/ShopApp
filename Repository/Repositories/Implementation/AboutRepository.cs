using Domain.Entities;
using Repository.Data;
using Repository.Repositories.Interface;


namespace Repository.Repositories.Implementation
{
    public class AboutRepository : Repository<About> , IAboutRepository
    {
        public AboutRepository(AppDbContext context) :base(context) 
        {
            
        }
    }
}
