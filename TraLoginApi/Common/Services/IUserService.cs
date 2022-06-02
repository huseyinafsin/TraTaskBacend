using System.Threading.Tasks;
using TraLoginApi.Data.Models;

namespace TraLoginApi.Common.Services
{
    public interface IUserService
    {
        public Task<User> GetByUsernameAsync(string username);
    }
}
