namespace Prestamos.Loans.Contracts.GetLoansById
{
    public record GetLoanById
    {
        public Guid LoanCorrelationId { get; set; }
    }
}