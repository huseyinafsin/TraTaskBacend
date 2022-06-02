using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TraLoginApi.Common.Repository;
using TraLoginApi.Data.Models;
using TraLoginApi.Data.Contexts;

namespace TraLoginApi.Repositores
{
    public class UserRepository : IUserRepository
    {
        private readonly AppContext _context;

        public UserRepository(AppContext context)
        {
            _context = context;
        }
        public async Task<User> GetByUsernameAsync(string username)
        {
            return await _context.Users.SingleOrDefaultAsync(u => u.Username == username);
        }
    }
}
