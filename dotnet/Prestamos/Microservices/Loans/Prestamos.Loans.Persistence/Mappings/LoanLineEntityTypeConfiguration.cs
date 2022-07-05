using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Prestamos.Loans.Domain.Entities;

namespace Prestamos.Loans.Persistence.Mappings
{
    public class LoanLineEntityTypeConfiguration : IEntityTypeConfiguration<LoanLine>
    {
        public void Configure(EntityTypeBuilder<LoanLine> builder)
        {
            // Primary Key.
            builder.HasKey(x => x.CorrelationId);
            
            // Correlation Id.
            builder.Property(x => x.CorrelationId);
            
            // Number.
            builder.Property(x => x.Number);
            
            // Material.
            builder.Property(x => x.MaterialCorrelationId);
        }
    }   
}