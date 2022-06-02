using System.Threading.Tasks;
using TraLoginApi.Common.Repository;
using TraLoginApi.Common.Services;
using TraLoginApi.Data.Models;

namespace TraLoginApi.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
   

        public async Task<User> GetByUsernameAsync(string username)
        {
            return await _userRepository.GetByUsernameAsync(username);
        }
    }
}
