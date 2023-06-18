using AutoMapper;
using Domain.Entities;
using Repository.Repositories.Interface;
using Service.DTOs.Services;
using Service.Service.Interface;


namespace Service.Service.Implementation
{
    public class ServicesService : IServicesService
    {
        private readonly IServicesRepository _repo;
        private readonly IMapper _mapper;

        public ServicesService(IServicesRepository repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }

        public async Task CreateAsync(ServicesCreateAndUpdateDto services)
        {
            await _repo.Create(_mapper.Map<Domain.Entities.Services>(services));

        }

        public async Task DeleteAsync(int id)
        {
            Domain.Entities.Services services = await _repo.GetById(id);
            await _repo.Delete(services);
        }

        public async Task<List<ServicesListDto>> GetAllAsync()
        {
            return _mapper.Map<List<ServicesListDto>>(await _repo.GetAll());
        }

        public async Task<List<ServicesListDto>> SerachAsync(string? searchText)
        {
            List<Domain.Entities.Services> searchDatas = new();
            if (searchText != null)
            {
                searchDatas = await _repo.FindAllAsync(m => m.Title.Contains(searchText) && m.Description.Contains(searchText));
            }
            else
            {
                searchDatas = await _repo.GetAll();
            }


            return _mapper.Map<List<ServicesListDto>>(searchDatas);
        }

        public async Task SoftDeleteAsync(int id)
        {

            Domain.Entities.Services services = await _repo.GetById(id);
            await _repo.SoftDelete(services);
        }

        public async Task UpdateAsync(int id, ServicesCreateAndUpdateDto services)
        {
            var dbService = await _repo.GetById(id);
            _mapper.Map(services, dbService);
            await _repo.Update(dbService);
        }
    }
}
