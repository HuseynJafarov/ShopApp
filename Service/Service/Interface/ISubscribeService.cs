using Service.DTOs.Slider;
using Service.DTOs.Subscribe;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Service.Interface
{
    public interface ISubscribeService
    {

        Task<List<SubscribeListDto>> GetAllAsync();
        Task DeleteAsync(int id);
        Task SoftDeleteAsync(int id);
        Task<List<SubscribeListDto>> SerachAsync(string? searchText);
    }
}
