using AutoMapper;
using Repository.Repositories.Interface;
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

        public async Task<List<CartListDto>> GetAllAsyncWithCarts()
        {
           return _mapper.Map<List<CartListDto>>(await _authorRepository.GetAllWithCart());
        }
    }
}
