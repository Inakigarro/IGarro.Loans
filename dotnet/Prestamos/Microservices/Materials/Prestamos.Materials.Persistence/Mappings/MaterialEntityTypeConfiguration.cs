using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Prestamos.Materials.Domain.Entities;

namespace Prestamos.Materials.Persistence.Mappings
{
    public class MaterialEntityTypeConfiguration : IEntityTypeConfiguration<Material>
    {
        public void Configure(EntityTypeBuilder<Material> builder)
        {
            // Primary Key.
            builder.HasKey(x => x.CorrelationId);
            
            // Correlation Id.
            builder.Property(x => x.CorrelationId);
            
            // Display Name.
            builder.Property(x => x.DisplayName);
            
            // Type.
            builder.HasOne(x => x.Type)
                .WithMany();
        }
    }
}

