using Service.DTOs.About;


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
