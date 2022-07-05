using MassTransit;
using Prestamos.Users.Domain.Entities;

namespace Prestamos.Loans.Domain.Entities
{
    public class Loan
    {
        public Loan()
        {
            this.CorrelationId = NewId.NextGuid();
        }

        /// <summary>
        /// Gets or sets the Loan's correlation id.
        /// </summary>
        public Guid CorrelationId { get; set; }

        /// <summary>
        /// Gets the Loan's initial date.
        /// </summary>
        public DateTime InitialDate { get; private set; }

        /// <summary>
        /// Gets the Loan's end date.
        /// </summary>
        public DateTime? EndDate { get; private set; } = null!;
        
        /// <summary>
        /// Gets the Loan's estimated end date.
        /// </summary>
        public DateTime EstimatedEndDate { get; private set; }

        /// <summary>
        /// Gets or sets the Owner's Correlation Id.
        /// </summary>
        public Guid OwnerCorrelationId { get; set; }

        /// <summary>
        /// Gets the Loan's Lines.
        /// </summary>
        public IEnumerable<LoanLine> LoanLines { get; private set; }

        public void SetInitialDate(DateTime initialDate)
        {
            this.InitialDate = initialDate;
        }

        public void SetEndDate(DateTime endDate)
        {
            this.EndDate = endDate;
        }

        public void SetEstimatedEndDate(DateTime estimatedEndDate)
        {
            this.EstimatedEndDate = estimatedEndDate;
        }

        public void SetLoanLines(IEnumerable<LoanLine> lines)
        {
            this.LoanLines = lines;
        }

        public void SetOwner(Guid ownerCorrelationId)
        {
            this.OwnerCorrelationId = ownerCorrelationId;
        }
    }
}