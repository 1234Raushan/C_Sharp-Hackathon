using LoginPage.Models;
using Microsoft.EntityFrameworkCore;

namespace LoginPage.DBContext
{
    public class LoginDBContext :DbContext
    {
        public LoginDBContext(DbContextOptions<LoginDBContext>options):base(options) { }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
          modelBuilder.Entity<User>().ToTable("userdb");
        }
        public DbSet<User> users { get; set; }
    }
}
