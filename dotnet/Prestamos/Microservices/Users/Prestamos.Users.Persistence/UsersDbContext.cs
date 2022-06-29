using Microsoft.EntityFrameworkCore;
using Prestamos.Users.Domain.Entities;
using Prestamos.Users.Persistence.Mappings;

namespace Prestamos.Users.Persistence
{
    public class UsersDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        
        public UsersDbContext(DbContextOptions options) 
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.HasDefaultSchema("Users");
            modelBuilder.ApplyConfiguration(new UserEntityTypeConfiguration());
        }
    }
}