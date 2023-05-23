using Service.DTOs.About;
using Service.DTOs.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Service.Interface
{
    public interface IServicesService
    {
        Task CreateAsync(ServicesCreateAndUpdateDto services);
        Task<List<ServicesListDto>> GetAllAsync();
        Task DeleteAsync(int id);
        Task SoftDeleteAsync(int id);
        Task UpdateAsync(int id, ServicesCreateAndUpdateDto services);
        Task<List<ServicesListDto>> SerachAsync(string? searchText);
    }
}
