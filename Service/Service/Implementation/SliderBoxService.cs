using AutoMapper;
using Domain.Entities;
using Repository.Repositories.Interface;
using Service.DTOs.Services;
using Service.DTOs.SliderBox;
using Service.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Service.Implementation
{
    public class SliderBoxService : ISliderBoxService
    {
        private readonly ISliderBoxsRepository _repo;
        private readonly IMapper _mapper;

        public SliderBoxService(ISliderBoxsRepository repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }
        public async Task CreateAsync(SliderBoxCreateAndUpdateDto sliderBox)
        {
            await _repo.Create(_mapper.Map<SliderBoxs>(sliderBox));
        }

        public async Task DeleteAsync(int id)
        {
            SliderBoxs sBox = await _repo.GetById(id);
            await _repo.Delete(sBox);
        }

        public async Task<List<SliderBoxListDto>> GetAllAsync()
        {
            return _mapper.Map<List<SliderBoxListDto>>(await _repo.GetAll());
        }

        public async Task<List<SliderBoxListDto>> SerachAsync(string? searchText)
        {
            List<SliderBoxs> searchDatas = new();
            if (searchText != null)
            {
                searchDatas = await _repo.FindAllAsync(m => m.Title.Contains(searchText));
            }
            else
            {
                searchDatas = await _repo.GetAll();
            }


            return _mapper.Map<List<SliderBoxListDto>>(searchDatas);
        }

        public async Task SoftDeleteAsync(int id)
        {

            SliderBoxs sBox = await _repo.GetById(id);
            await _repo.SoftDelete(sBox);
        }

        public async Task UpdateAsync(int id, SliderBoxCreateAndUpdateDto sliderBox)
        {
            var dbSliderBox = await _repo.GetById(id);
            _mapper.Map(sliderBox, dbSliderBox);
            await _repo.Update(dbSliderBox);
        }
    }
}
