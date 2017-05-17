using Microsoft.EntityFrameworkCore;
using NewCo.Core.Models;

namespace NewCo.Persistence
{
    public class NewCoDbContext : DbContext
    {
        public DbSet<Account> Accounts { get; set; }

        public NewCoDbContext(DbContextOptions<NewCoDbContext> options) 
            :base(options)
        {
        }
    }
}