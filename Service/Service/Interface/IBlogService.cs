using Service.DTOs.Blog;

namespace Service.Service.Interface
{
    public interface IBlogService
    {
        Task CreateAsync(BlogCreateAndUpdateDto data);
        Task<List<BlogListDto>> GetAllAsync();
        Task DeleteAsync(int id);
        Task SoftDeleteAsync(int id);
        Task<BlogListDto> GetByIdAsync(int id);
        Task UpdateAsync(int id, BlogCreateAndUpdateDto data);
        Task<List<BlogListDto>> SerachAsync(string? searchText);
    }
}
