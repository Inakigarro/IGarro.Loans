using Microsoft.EntityFrameworkCore;
using Prestamos.Materials.Domain.Entities;
using Prestamos.Materials.Persistence.Mappings;

namespace Prestamos.Materials.Persistence
{
    public class MaterialsDbContext : DbContext
    {
        public DbSet<MaterialType> MaterialTypes { get; set; }
        public DbSet<Material> Materials { get; set; }
        
        public MaterialsDbContext(DbContextOptions options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new MaterialTypeEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration(new MaterialEntityTypeConfiguration());
        }
    }
}

