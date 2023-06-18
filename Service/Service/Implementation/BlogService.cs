using AutoMapper;
using Domain.Entities;
using Repository.Repositories.Interface;
using Service.DTOs.Blog;
using Service.Helpers;
using Service.Service.Interface;


namespace Service.Service.Implementation
{
    public class BlogService : IBlogService
    {
        private readonly IBlogRepository _repo;
        private readonly IMapper _mapper;
        private readonly IAuthorRepository _authorRepo;


        public BlogService(IBlogRepository blogRepository
            , IMapper mapper
            , IAuthorRepository authorRepo)
        {
            _repo = blogRepository;
            _mapper = mapper;
            _authorRepo = authorRepo;
        }

        public async Task CreateAsync(BlogCreateAndUpdateDto data)
        {
            var author = await _authorRepo
                .FindAllAsync(a =>
                a.Id == data.AuthorId);

            var mapBlog = _mapper
                .Map<Blog>(data);

            mapBlog.Image = await 
                data.Photo.GetBytes();

            await _repo.Create(mapBlog);
        }

        public async Task DeleteAsync(int id)
        {
            await _repo.Delete(await _repo.GetById(id));
        }

        public async Task<List<BlogListDto>> GetAllAsync()
        {
            var data = await _repo.GetAllWithAuthor();
            var mappedData = _mapper.Map<List<BlogListDto>>(data);
            return mappedData;
        }

        public async Task<BlogListDto> GetByIdAsync(int id)
        {
            var data = await _repo.GetByIdWithAuthor(id);
            var mappedData =  _mapper.Map<BlogListDto>(data);
            return mappedData;
        }

        public async Task<List<BlogListDto>> SerachAsync(string? searchText)
        {
            List<Blog> searchDatas = new();
            if (searchText != null)
            {
                searchDatas = await _repo
                    .FindAllAsync(x =>
                    x.Description
                    .Contains(searchText) 
                    && x.Title
                    .Contains(searchText));
            }
            else
            {
                searchDatas = await _repo.GetAll();
            }
            return _mapper.Map<List<BlogListDto>>(searchDatas);
        }

        public async Task SoftDeleteAsync(int id)
        {
            await _repo.SoftDelete(await _repo.GetById(id));
        }

        public async Task UpdateAsync(int id, BlogCreateAndUpdateDto data)
        {
            Blog dbBlog = await _repo.GetById(id);
            _mapper.Map(data, dbBlog);
            await _repo.Update(dbBlog);
        }

    }
}
