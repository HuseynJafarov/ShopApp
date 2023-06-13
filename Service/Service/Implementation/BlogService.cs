using AutoMapper;
using Domain.Entities;
using Repository.Repositories.Implementation;
using Repository.Repositories.Interface;
using Service.DTOs.Blog;
using Service.Service.Interface;


namespace Service.Service.Implementation
{
    public class BlogService : IBlogService
    {
        private readonly IBlogRepository _repo;
        private readonly IMapper _mapper;

        public BlogService(IBlogRepository blogRepository, IMapper mapper)
        {
            _repo = blogRepository;
            _mapper = mapper;
        }

        public async Task CreateAsync(BlogCreateAndUpdateDto data)
        {
            await _repo.Create(_mapper.Map<Blog>(data));
        }

        public async Task DeleteAsync(int id)
        {
            await _repo.Delete(await _repo.Get(id));
        }

        public async Task<List<BlogListDto>> GetAllAsync()
        {
            return _mapper.Map<List<BlogListDto>>(await _repo.GetAll());
        }

        public async Task<List<BlogListDto>> SerachAsync(string? searchText)
        {
            List<Blog> searchDatas = new();
            if (searchText != null)
            {
                searchDatas = await _repo.FindAllAsync(x => x.Description.Contains(searchText)
                                              && x.Title.Contains(searchText));
            }
            else
            {
                searchDatas = await _repo.GetAll();
            }
            return _mapper.Map<List<BlogListDto>>(searchDatas);
        }

        public async Task SoftDeleteAsync(int id)
        {
            await _repo.SoftDelete(await _repo.Get(id));
        }

        public async Task UpdateAsync(int id, BlogCreateAndUpdateDto data)
        {
            Blog dbBlog = await(_repo.Get(id));
            _mapper.Map(data, dbBlog);
            await _repo.Update(dbBlog);
        }
    }
}
