namespace Prestamos.Users.Application.Contracts
{
    public record CreateUser
    {
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