namespace Prestamos.Loans.Contracts.GetLoanLinesById
{
    public record GetLoanLineById
    {
        /// <summary>
        /// Gets or sets the Loan Line Correlation Id.
        /// </summary>
        public Guid LoanLineCorrelationId { get; set; }
    }   
}