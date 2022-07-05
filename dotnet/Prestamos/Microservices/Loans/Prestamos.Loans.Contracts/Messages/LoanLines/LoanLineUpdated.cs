namespace Prestamos.Loans.Contracts
{
    public record LoanLineUpdated
    {
        /// <summary>
        /// Gets or sets the Loan Line Correlation Id.
        /// </summary>
        public Guid CorrelationId { get; set; }

        /// <summary>
        /// Gets or sets the Loan Line Number.
        /// </summary>
        public int Number { get; set; }

        /// <summary>
        /// Gets or sets the Loan Line Material.
        /// </summary>
        public Guid MaterialCorrelationId { get; set; }
    }   
}