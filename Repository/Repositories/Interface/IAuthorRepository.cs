using Domain.Entities;


namespace Repository.Repositories.Interface
{
    public interface IAuthorRepository :IRepository<Author>
    {
        Task<List<Author>> GetAllWithCart();
        
    }
}
