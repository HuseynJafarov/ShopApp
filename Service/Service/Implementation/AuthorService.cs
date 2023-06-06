using AutoMapper;
using Domain.Entities;
using Repository.Repositories.Interface;
using Service.DTOs.Author;
using Service.DTOs.Cart;
using Service.Service.Interface;
    
namespace Service.Service.Implementation
{
    public class AuthorService:IAuthorService
    {
        private readonly IAuthorRepository _repo;
        private readonly IMapper _mapper;

        public AuthorService(IAuthorRepository authorRepository, IMapper mapper)
        {
            _repo = authorRepository;
            _mapper = mapper;
        }

        public async Task CreateAsync(AuthorCreateAndUpdateDto data)
        {
            await _repo.Create(_mapper.Map<Author>(data));
        }

        public async Task DeleteAsync(int id)
        {
            await _repo.Delete(await _repo.Get(id));
        }

        public async Task<List<AuthorListDto>> GetAllAsync()
        {
            return _mapper.Map<List<AuthorListDto>>(await _repo.GetAll());
        }

        public async Task<List<CartListDto>> GetAllAsyncWithCarts()
        {
           return _mapper.Map<List<CartListDto>>(await _repo.GetAllWithCart());
        }

        public async Task<List<AuthorListDto>> SerachAsync(string? searchText)
        {
            List<Author> searchDatas = new();
            if (searchText != null)
            {
                searchDatas = await _repo.FindAllAsync(x => x.Name.Contains(searchText)
                                              && x.Position.Contains(searchText));
            }
            else
            {
                searchDatas = await _repo.GetAll();
            }
            return _mapper.Map<List<AuthorListDto>>(searchDatas);
        }

        public async Task SoftDeleteAsync(int id)
        {
            await _repo.SoftDelete(await _repo.Get(id));
        }

        public async Task UpdateAsync(int id, AuthorCreateAndUpdateDto data)
        {
            Author dbAuthor = await (_repo.Get(id));
            _mapper.Map(data, dbAuthor);
            await _repo.Update(dbAuthor);
        }
    }
}
