using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Prestamos.Materials.Domain.Entities;

namespace Prestamos.Materials.Persistence.Mappings
{
    public class MaterialTypeEntityTypeConfiguration : IEntityTypeConfiguration<MaterialType>
    {
        public void Configure(EntityTypeBuilder<MaterialType> builder)
        {
            builder.HasKey(x => x.CorrelationId);
            
            // Correlation Id.
            builder.Property(x => x.CorrelationId);
            
            // Display Name.
            builder.Property(x => x.DisplayName);
            
            // Code.
            builder.Property(x => x.Code);
        }
    }
}

