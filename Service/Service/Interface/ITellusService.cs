using Service.DTOs.Subscribe;
using Service.DTOs.TellUs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Service.Interface
{
    public interface ITellusService
    {
        Task<List<TellusListDto>> GetAllAsync();
        Task DeleteAsync(int id);
        Task SoftDeleteAsync(int id);
        Task<List<TellusListDto>> SerachAsync(string? searchText);
    }
}
