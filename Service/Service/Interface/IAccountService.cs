using Service.DTOs.Account;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Service.Interface
{
    public interface IAccountService
    {
        Task<string?> LoginAsync(LoginDto model);
        Task<ApiResponse> RegisterAsync(RegisterDto model);
    }
}
