using Microsoft.EntityFrameworkCore;
using Prestamos.Loans.Domain.Entities;
using Prestamos.Loans.Persistence.Mappings;

namespace Prestamos.Loans.Persistence
{
    public class LoansDbContext : DbContext
    {
        public DbSet<Loan> Loans { get; set; }
        public DbSet<LoanLine> LoanLines { get; set; }

        public LoansDbContext(DbContextOptions options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.HasDefaultSchema("Loans");
            modelBuilder.ApplyConfiguration(new LoanEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration(new LoanLineEntityTypeConfiguration());
        }
    }
}