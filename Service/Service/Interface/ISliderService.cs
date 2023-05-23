using Service.DTOs.Services;
using Service.DTOs.Slider;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Service.Interface
{
    public interface ISliderService
    {

        Task CreateAsync(SliderCreateAndUpdateDto slider);
        Task<List<SliderListDto>> GetAllAsync();
        Task DeleteAsync(int id);
        Task SoftDeleteAsync(int id);
        Task UpdateAsync(int id, SliderCreateAndUpdateDto slider);
        Task<List<SliderListDto>> SerachAsync(string? searchText);
    }
}
