namespace Prestamos.Loans.Contracts
{
    /// <summary>
    /// Message used to create a Loan Line.
    /// </summary>
    public record CreateLoanLine
    {
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