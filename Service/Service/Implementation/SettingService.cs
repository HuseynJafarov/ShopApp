using AutoMapper;
using Domain.Entities;
using Repository.Repositories.Interface;
using Service.DTOs.Setting;
using Service.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Service.Implementation
{
    public class SettingService : ISettingService
    {
        private readonly ISettingsRepository _repo;
        private readonly IMapper _mapper;

        public SettingService(ISettingsRepository repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }

        public async Task CreateAsync(SettingCreateAndUpdateDto setting)
        {
            await _repo.Create(_mapper.Map<Settings>(setting));
        }

        public async Task DeleteAsync(int id)
        {
            Settings settings = await _repo.Get(id);
            await _repo.Delete(settings);
        }

        public async Task<List<SettingListDto>> GetAllAsync()
        {
            return _mapper.Map<List<SettingListDto>>(await _repo.GetAll());
        }

        public async Task<List<SettingListDto>> SerachAsync(string? searchText)
        {
            List<Settings> searchDatas = new();
            if (searchText != null)
            {
                searchDatas = await _repo.FindAllAsync(m => m.SiteName.Contains(searchText) && m.Description.Contains(searchText));
            }
            else
            {
                searchDatas = await _repo.GetAll();
            }


            return _mapper.Map<List<SettingListDto>>(searchDatas);
        }

        public async Task SoftDeleteAsync(int id)
        {
            Settings settings = await _repo.Get(id);
            await _repo.SoftDelete(settings);
        }

        public async Task UpdateAsync(int id, SettingCreateAndUpdateDto setting)
        {
            var dbSetting = await _repo.Get(id);
            _mapper.Map(setting, dbSetting);
            await _repo.Update(dbSetting);
        }
    }
}
