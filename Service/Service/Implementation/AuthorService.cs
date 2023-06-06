using AutoMapper;
using Repository.Repositories.Interface;
using Service.DTOs.Author;
using Service.DTOs.Cart;
using Service.Service.Interface;
    
namespace Service.Service.Implementation
{
    public class AuthorService:IAuthorService
    {
        private readonly IAuthorRepository _authorRepository;
        private readonly IMapper _mapper;

        public AuthorService(IAuthorRepository authorRepository, IMapper mapper)
        {
            _authorRepository = authorRepository;
            _mapper = mapper;
        }

        public Task CreateAsync(AuthorCreateAndUpdateDto data)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<AuthorListDto>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<List<CartListDto>> GetAllAsyncWithCarts()
        {
           return _mapper.Map<List<CartListDto>>(await _authorRepository.GetAllWithCart());
        }

        public Task<List<AuthorListDto>> SerachAsync(string? searchText)
        {
            throw new NotImplementedException();
        }

        public Task SoftDeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(int id, AuthorCreateAndUpdateDto slider)
        {
            throw new NotImplementedException();
        }
    }
}
