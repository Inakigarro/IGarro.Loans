using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Prestamos.Users.Domain.Entities;

namespace Prestamos.Users.Persistence.Mappings
{
    public class UserEntityTypeConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            // Primary key.
            builder.HasKey(x => x.CorrelationId);
            
            // Correlation Id.
            builder.Property(x => x.CorrelationId);
            
            // DisplayName.
            builder.Property(x => x.DisplayName);
            
            // Email.
            builder.Property(x => x.Email);
        }
    }   
}