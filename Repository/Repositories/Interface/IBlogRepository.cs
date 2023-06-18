using Domain.Entities;


namespace Repository.Repositories.Interface
{
    public interface IBlogRepository :IRepository<Blog>
    {
        Task<List<Blog>> GetAllWithAuthor();
        Task<Blog> GetByIdWithAuthor(int id);
    }
}
