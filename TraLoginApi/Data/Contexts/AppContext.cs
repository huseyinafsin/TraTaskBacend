using Microsoft.EntityFrameworkCore;
using TraLoginApi.Data.Models;

namespace TraLoginApi.Data.Contexts
{
    public class AppContext : DbContext
    {
        public AppContext(DbContextOptions<AppContext> options) : base(options)
        {
        }
        public virtual DbSet<User> Users { get; set; }
    }

}
