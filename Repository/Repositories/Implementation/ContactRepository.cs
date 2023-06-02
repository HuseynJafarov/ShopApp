using Domain.Entities;
using Repository.Data;
using Repository.Repositories.Interface;


namespace Repository.Repositories.Implementation
{
    public class ContactRepository : Repository<Contact> , IContactRepository
    {
        public ContactRepository(AppDbContext context) :base(context)
        {
            
        }
    }
}
