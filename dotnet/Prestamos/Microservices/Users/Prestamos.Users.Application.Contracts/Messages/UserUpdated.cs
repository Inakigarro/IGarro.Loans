namespace Prestamos.Users.Application.Contracts
{
    public record UserUpdated
    {
        /// <summary>
        /// Gets or sets the User Correlation Id.
        /// </summary>
        public Guid CorrelationId { get; set; }

        /// <summary>
        /// Gets or sets the User DisplayName.
        /// </summary>
        public string DisplayName { get; set; } = null!;

        /// <summary>
        /// Gets or sets the User Email.
        /// </summary>
        public string Email { get; set; } = null!;
    }
}

