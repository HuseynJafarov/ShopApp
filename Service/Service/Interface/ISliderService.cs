using Service.DTOs.Slider;


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
