using Service.DTOs.Slider;
using Service.DTOs.Student;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Service.Interface
{
    public interface IStudentService
    {
        Task CreateAsync(StudentCreateAndUpdateDto data);
        Task<List<StudentListDto>> GetAllAsync();
        Task DeleteAsync(int id);
        Task SoftDeleteAsync(int id);
        Task UpdateAsync(int id, StudentCreateAndUpdateDto data);
        Task<List<StudentListDto>> SerachAsync(string? searchText);
    }
}
