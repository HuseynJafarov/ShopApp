using AutoMapper;
using Domain.Entities;
using Repository.Repositories.Interface;
using Service.DTOs.Subscribe;
using Service.DTOs.TellUs;
using Service.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Service.Implementation
{
    public class TellusService : ITellusService
    {
        private readonly ITellUsRepository _repo;
        private readonly IMapper _mapper;

        public TellusService(ITellUsRepository repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }

        public async Task CreateAsync(TellUsCreateAndUpdateDto tellUs)
        {
            await _repo.Create(_mapper.Map<TellUs>(tellUs));
        }

        public async Task DeleteAsync(int id)
        {
            TellUs tellUs = await _repo.Get(id);
            await _repo.Delete(tellUs);
        }

        public async Task<List<TellusListDto>> GetAllAsync()
        {
            return _mapper.Map<List<TellusListDto>>(await _repo.GetAll());
        }

        public async Task<List<TellusListDto>> SerachAsync(string? searchText)
        {
            List<TellUs> searchDatas = new();
            if (searchText != null)
            {
                searchDatas = await _repo.FindAllAsync(m => m.Email.Contains(searchText) && m.Name.Contains(searchText));
            }
            else
            {
                searchDatas = await _repo.GetAll();
            }


            return _mapper.Map<List<TellusListDto>>(searchDatas);
        }

        public async Task SoftDeleteAsync(int id)
        {
            TellUs tellUs = await _repo.Get(id);
            await _repo.SoftDelete(tellUs
                );
        }

        public async Task UpdateAsync(int id, TellUsCreateAndUpdateDto tellUs)
        {
            var dbTellUs = await _repo.Get(id);
            _mapper.Map(tellUs, dbTellUs);
            await _repo.Update(dbTellUs);
        }
    }
}
