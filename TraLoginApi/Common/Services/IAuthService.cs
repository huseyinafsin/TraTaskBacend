using System.Threading.Tasks;
using TraLoginApi.Common.Jwt;
using TraLoginApi.Data.Dtos;

namespace TraLoginApi.Common.Services
{
    public interface IAuthService
    {
        public Task<LoginResult> Login(LoginDto loginDto);
    }
}
