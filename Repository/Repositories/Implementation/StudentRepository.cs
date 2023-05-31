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
    public class StudentRepository: Repository<Student> , IStudentRepository
    {
        public StudentRepository(AppDbContext context) :base(context) 
        {
            
        }
    }
}
