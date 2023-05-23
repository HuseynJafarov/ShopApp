using Service.DTOs.About;
using Service.DTOs.HeroSlider;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Service.Interface
{
    public interface IHeroSliderService
    {
        Task CreateAsync(HeroSliderCreateAndUpdateDto hero);
        Task<List<HeroSliderListDto>> GetAllAsync();
        Task DeleteAsync(int id);
        Task SoftDeleteAsync(int id);
        Task UpdateAsync(int id, HeroSliderCreateAndUpdateDto hero);
        Task<List<HeroSliderListDto>> SerachAsync(string? searchText);
    }
}
