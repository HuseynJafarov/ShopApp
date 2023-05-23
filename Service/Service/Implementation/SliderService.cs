using AutoMapper;
using Domain.Entities;
using Repository.Repositories.Interface;
using Service.DTOs.Slider;
using Service.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Service.Implementation
{
    public class SliderService :ISliderService
    {
        private readonly ISliderRepository _repo;
        private readonly IMapper _mapper;

        public SliderService(ISliderRepository repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }

        public async Task CreateAsync(SliderCreateAndUpdateDto slider)
        {
            await _repo.Create(_mapper.Map<Slider>(slider));
        }

        public async Task DeleteAsync(int id)
        {
            Slider slider = await _repo.Get(id);
            await _repo.Delete(slider);
        }

        public async Task<List<SliderListDto>> GetAllAsync()
        {
            return _mapper.Map<List<SliderListDto>>(await _repo.GetAll());
        }

        public async Task<List<SliderListDto>> SerachAsync(string? searchText)
        {
            List<Slider> searchDatas = new();
            if (searchText != null)
            {
                searchDatas = await _repo.FindAllAsync(m => m.Title.Contains(searchText) && m.Description.Contains(searchText));
            }
            else
            {
                searchDatas = await _repo.GetAll();
            }


            return _mapper.Map<List<SliderListDto>>(searchDatas);
        }

        public async Task SoftDeleteAsync(int id)
        {
            Slider slider = await _repo.Get(id);
            await _repo.SoftDelete(slider);
        }

        public async Task UpdateAsync(int id, SliderCreateAndUpdateDto slider)
        {

            var dbSlider = await _repo.Get(id);
            _mapper.Map(slider, dbSlider);
            await _repo.Update(dbSlider);
        }
    }
}
