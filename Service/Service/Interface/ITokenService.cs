

namespace Service.Service.Interface
{
    public interface ITokenService
    {
        string GenerateJwtToken(string id,string username, string email, List<string> roles);
    }
}
