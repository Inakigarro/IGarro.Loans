using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Prestamos.Loans.Domain.Entities;

namespace Prestamos.Loans.Persistence.Mappings
{
    public class LoanEntityTypeConfiguration : IEntityTypeConfiguration<Loan>
    {
        public void Configure(EntityTypeBuilder<Loan> builder)
        {
            // Primary key.
            builder.HasKey(x => x.CorrelationId);
            
            // Correlation Id.
            builder.Property(x => x.CorrelationId);
            
            // Initial Date.
            builder.Property(x => x.InitialDate);
            
            // End Date.
            builder.Property(x => x.EndDate);
            
            // Estimated End Date.
            builder.Property(x => x.EstimatedEndDate);

            // Owner.
            builder.Property(x => x.OwnerCorrelationId);

            // Loan Lines.
            builder.HasMany(x => x.LoanLines)
                .WithOne();
        }
    }   
}