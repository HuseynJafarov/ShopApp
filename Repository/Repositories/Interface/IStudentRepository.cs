using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Repositories.Interface
{
    public interface IStudentRepository: IRepository<Student>
    {
        Task<List<Student>> GetAllWithCart();
        Task<Student> GetByIdWithCart(int id);
    }
}
