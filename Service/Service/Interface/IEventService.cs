using Service.DTOs.About;
using Service.DTOs.Event;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Service.Interface
{
    public interface IEventService
    {
        Task CreateAsync(EventCreateAndUpdateDto eventCreateAndUpdate);
        Task<List<EventListDto>> GetAllAsync();
        Task DeleteAsync(int id);
        Task SoftDeleteAsync(int id);
        Task UpdateAsync(int id, EventCreateAndUpdateDto eventCreateAndUpdate);
        Task<List<EventListDto>> SerachAsync(string? searchText);
    }
}
