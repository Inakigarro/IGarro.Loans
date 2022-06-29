namespace Prestamos.Users.Application.Contracts
{
    public record GetUsersById
    {
        /// <summary>
        /// Gets or sets the User's Correlation Id.
        /// </summary>
        public Guid CorrelationId { get; set; }
    }
}