using Service.DTOs.Slider;
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
        Task CreateAsync(TellUsCreateAndUpdateDto tellUs);
        Task<List<TellusListDto>> GetAllAsync();
        Task DeleteAsync(int id);
        Task SoftDeleteAsync(int id);
        Task UpdateAsync(int id, TellUsCreateAndUpdateDto tellUs);
        Task<List<TellusListDto>> SerachAsync(string? searchText);
    }
}
