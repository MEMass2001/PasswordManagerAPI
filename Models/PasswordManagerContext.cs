using Microsoft.EntityFrameworkCore;

namespace PasswordManagerAPI.Models
{
    public class PasswordManagerContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<Account> Accounts { get; set; }
        public PasswordManagerContext(DbContextOptions<PasswordManagerContext> options) : base(options)
        {
            Database.EnsureCreated();
        }
    }
}