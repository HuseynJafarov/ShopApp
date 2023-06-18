using Domain.Entities;


namespace Repository.Repositories.Interface
{
    public interface IAuthorRepository :IRepository<Author>
    {
        Task<List<Author>> GetAllWithBlogAndCarts();
        Task<Author> GetByIdWithBlogAndCart(int  id);
        
    }
}
