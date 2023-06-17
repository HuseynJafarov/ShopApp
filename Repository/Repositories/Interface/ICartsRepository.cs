using Domain.Entities;


namespace Repository.Repositories.Interface
{
    public interface ICartsRepository : IRepository<Carts>
    {
        Task<List<Carts>> GetAllCartAuthor();
        Task<Carts> GetByIdCartAuthor(int id);
        Task DeleteCartAuthor(List<CartAuthor> cartAuthors);
    }
}
