namespace Prestamos.Loans.Contracts.GetLoansById
{
    public record GetLoanByIdResponse
    {
        /// <summary>
        /// Gets or sets the Loan's correlation id.
        /// </summary>
        public Guid CorrelationId { get; set; }

        /// <summary>
        /// Gets the Loan's initial date.
        /// </summary>
        public DateTime InitialDate { get; set; }

        /// <summary>
        /// Gets the Loan's end date.
        /// </summary>
        public DateTime? EndDate { get; set; } = null!;
        
        /// <summary>
        /// Gets the Loan's estimated end date.
        /// </summary>
        public DateTime EstimatedEndDate { get; set; }

        /// <summary>
        /// Gets or sets the Owner's Correlation Id.
        /// </summary>
        public Guid OwnerCorrelationId { get; set; }

        /// <summary>
        /// Gets the Loan's Lines.
        /// </summary>
        public IEnumerable<LoanLineUpdated> LoanLines { get; set; } = new List<LoanLineUpdated>();
    }
}