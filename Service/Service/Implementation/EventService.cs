using AutoMapper;
using Domain.Entities;
using Repository.Repositories.Interface;
using Service.DTOs.Event;
using Service.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Service.Implementation
{
    public class EventService : IEventService
    {
        private readonly IEventsRepository _repo;
        private readonly IMapper _mapper;

        public EventService(IEventsRepository repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }

        public async Task CreateAsync(EventCreateAndUpdateDto eventCreateAndUpdate)
        {
            await _repo.Create(_mapper.Map<Events>(eventCreateAndUpdate));
        }

        public async Task DeleteAsync(int id)
        {
            Events events = await _repo.GetById(id);
            await _repo.Delete(events);
        }

        public async Task<List<EventListDto>> GetAllAsync()
        {
            return _mapper.Map<List<EventListDto>>(await _repo.GetAll());
        }

        public async Task<List<EventListDto>> SerachAsync(string? searchText)
        {
            List<Events> searchDatas = new();
            if (searchText != null)
            {
                searchDatas = await _repo.FindAllAsync(m => m.Title.Contains(searchText) && m.Description.Contains(searchText) && m.Location.Contains(searchText));
            }
            else
            {
                searchDatas = await _repo.GetAll();
            }


            return _mapper.Map<List<EventListDto>>(searchDatas);
        }

        public async Task SoftDeleteAsync(int id)
        {
            Events events = await _repo.GetById(id);
            await _repo.SoftDelete(events);
        }

        public async Task UpdateAsync(int id, EventCreateAndUpdateDto eventCreateAndUpdate)
        {
            var dbEvent = await _repo.GetById(id);
            _mapper.Map(eventCreateAndUpdate, dbEvent);
            await _repo.Update(dbEvent);
        }
    }
}
