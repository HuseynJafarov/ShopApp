using AutoMapper;
using Domain.Entities;
using Repository.Repositories.Interface;
using Service.DTOs.Subscribe;
using Service.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Service.Implementation
{
    public class SubscribeService : ISubscribeService
    {
        private readonly ISubscribeRepository _repo;
        private readonly IMapper _mapper;

        public SubscribeService(ISubscribeRepository repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }

        public async Task CreateAsync(SubscribeCreateAndUpdateDto subscribe)
        {
            await _repo.Create(_mapper.Map<Subscribe>(subscribe));
        }

        public async Task DeleteAsync(int id)
        {
            Subscribe subscribe = await _repo.GetById(id);
            await _repo.Delete(subscribe);
        }

        public async Task<List<SubscribeListDto>> GetAllAsync()
        {
            return _mapper.Map<List<SubscribeListDto>>(await _repo.GetAll());

        }

        public async Task<List<SubscribeListDto>> SerachAsync(string? searchText)
        {
            List<Subscribe> searchDatas = new();
            if (searchText != null)
            {
                searchDatas = await _repo.FindAllAsync(m => m.Email.Contains(searchText));
            }
            else
            {
                searchDatas = await _repo.GetAll();
            }


            return _mapper.Map<List<SubscribeListDto>>(searchDatas);
        }

        public async Task SoftDeleteAsync(int id)
        {
            Subscribe subscribe = await _repo.GetById(id);
            await _repo.SoftDelete(subscribe);
        }

        public async Task UpdateAsync(int id, SubscribeCreateAndUpdateDto subscribe)
        {
            var dbSubscribe = await _repo.GetById(id);
            _mapper.Map(subscribe, dbSubscribe);
            await _repo.Update(dbSubscribe);
        }
    }
}
