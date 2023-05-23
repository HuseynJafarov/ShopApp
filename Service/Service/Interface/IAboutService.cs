using Service.DTOs.About;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Service.Interface
{
    public interface IAboutService
    {
        Task CreateAsync(AboutCreateAndUpdateDto about);
        Task<List<AboutListDto>> GetAllAsync();
       
        Task DeleteAsync(int id);
        Task SoftDeleteAsync(int id);
        Task UpdateAsync(int id, AboutCreateAndUpdateDto about);
        Task<List<AboutListDto>> SerachAsync(string? searchText);
    }
}
