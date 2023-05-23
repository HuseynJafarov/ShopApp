using AutoMapper;
using Domain.Entities;
using Repository.Repositories.Interface;
using Service.DTOs.HeroSlider;
using Service.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Service.Implementation
{
    public class HeroSliderService : IHeroSliderService
    {
        private readonly IHeroSlidersRepository _repo;
        private readonly IMapper _mapper;

        public HeroSliderService(IHeroSlidersRepository repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }

        public async Task CreateAsync(HeroSliderCreateAndUpdateDto hero)
        {
            await _repo.Create(_mapper.Map<HeroSliders>(hero));
        }

        public async Task DeleteAsync(int id)
        {
            HeroSliders hSlider = await _repo.Get(id);
            await _repo.Delete(hSlider);
        }

        public async Task<List<HeroSliderListDto>> GetAllAsync()
        {
            return _mapper.Map<List<HeroSliderListDto>>(await _repo.GetAll());
        }

        public async Task<List<HeroSliderListDto>> SerachAsync(string? searchText)
        {
            List<HeroSliders> searchDatas = new();
            if (searchText != null)
            {
                searchDatas = await _repo.FindAllAsync(m => m.Student.Contains(searchText) && m.StudentStatus.Contains(searchText));
            }
            else
            {
                searchDatas = await _repo.GetAll();
            }


            return _mapper.Map<List<HeroSliderListDto>>(searchDatas);
        }

        public async Task SoftDeleteAsync(int id)
        {
            HeroSliders hSlider = await _repo.Get(id);
            await _repo.SoftDelete(hSlider);
        }

        public async Task UpdateAsync(int id, HeroSliderCreateAndUpdateDto hero)
        {
            var dbHeroSlider= await _repo.Get(id);
            _mapper.Map(hero, dbHeroSlider);
            await _repo.Update(dbHeroSlider);
        }
    }
}
