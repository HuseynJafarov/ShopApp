using Service.DTOs.Services;
using Service.DTOs.Setting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Service.Interface
{
    public interface ISettingService
    {
        Task CreateAsync(SettingCreateAndUpdateDto setting);
        Task<List<SettingListDto>> GetAllAsync();
        Task DeleteAsync(int id);
        Task SoftDeleteAsync(int id);
        Task UpdateAsync(int id, SettingCreateAndUpdateDto setting);
        Task<List<SettingListDto>> SerachAsync(string? searchText);
    }
}
