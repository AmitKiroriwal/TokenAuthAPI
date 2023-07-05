using Microsoft.EntityFrameworkCore;
using TokenAuthAPI.Models;

namespace TokenAuthAPI.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)  
        {

        }
        public DbSet<User> User { get; set; }
    }
}
