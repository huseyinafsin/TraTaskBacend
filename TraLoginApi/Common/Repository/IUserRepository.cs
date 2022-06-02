using System.Threading.Tasks;
using TraLoginApi.Data.Models;

namespace TraLoginApi.Common.Repository
{
    public interface IUserRepository
    {
        public Task<User> GetByUsernameAsync(string username);
    }
}
