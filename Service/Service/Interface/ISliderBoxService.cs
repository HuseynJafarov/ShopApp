using Service.DTOs.Services;
using Service.DTOs.SliderBox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Service.Interface
{
    public interface ISliderBoxService
    {

        Task CreateAsync(SliderBoxCreateAndUpdateDto sliderBox);
        Task<List<SliderBoxListDto>> GetAllAsync();
        Task DeleteAsync(int id);
        Task SoftDeleteAsync(int id);
        Task UpdateAsync(int id, SliderBoxCreateAndUpdateDto SliderBox);
        Task<List<SliderBoxListDto>> SerachAsync(string? searchText);
    }
}
