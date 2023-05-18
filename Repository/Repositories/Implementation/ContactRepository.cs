using Domain.Entities;
using Repository.Data;
using Repository.Repositories.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Repositories.Implementation
{
    public class ContactRepository : Repository<Contact> , IContactRepository
    {
        public ContactRepository(AppDbContext context) :base(context)
        {
            
        }
    }
}
