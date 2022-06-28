using MassTransit;

namespace Prestamos.Users.Domain.Entities
{
    public class User
    {
        /// <summary>
        /// Initialize a new <see cref="User"/> instance.
        /// </summary>
        public User()
        {
            this.CorrelationId = NewId.NextGuid();
        }

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