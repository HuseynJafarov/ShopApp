using AutoMapper;
using Domain.Entities;
using Repository.Repositories.Interface;
using Service.DTOs.About;
using Service.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Service.Implementation
{
    public class AboutService : IAboutService
    {
        private readonly IAboutRepository _repo;
        private readonly IMapper _mapper;

        public AboutService(IAboutRepository repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }

        public async Task CreateAsync(AboutCreateAndUpdateDto about)
        {
            await _repo.Create(_mapper.Map<About>(about));
        }

        public async Task DeleteAsync(int id)
        {
            About about = await _repo.GetById(id);
            await _repo.Delete(about);
        }

        public async Task<List<AboutListDto>> GetAllAsync()
        {
            return _mapper.Map<List<AboutListDto>>(await _repo.GetAll());
        }

        public async Task<List<AboutListDto>> SerachAsync(string? searchText)
        {
            List<About> searchDatas = new();
            if (searchText != null)
            {
                searchDatas = await _repo.FindAllAsync(x => x.Title.Contains(searchText) && x.Description.Contains(searchText));
            }
            else
            {
                searchDatas = await _repo.GetAll();
            }

            return _mapper.Map<List<AboutListDto>>(searchDatas);
        }

        public async Task SoftDeleteAsync(int id)
        {
            About about = await (_repo.GetById(id));
            await _repo.SoftDelete(about);
        }

        public async Task UpdateAsync(int id, AboutCreateAndUpdateDto about)
        {
            About dbAbout = await (_repo.GetById(id));
            _mapper.Map(about,dbAbout);
            await _repo.Update(dbAbout);
        }
    }
}
