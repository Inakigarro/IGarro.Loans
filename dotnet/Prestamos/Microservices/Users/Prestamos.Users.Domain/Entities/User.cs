using System.ComponentModel.DataAnnotations;
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
        public string DisplayName { get; private set; } = null!;

        /// <summary>
        /// Gets or sets the User Email.
        /// </summary>
        [EmailAddress]
        public string Email { get; private set; } = null!;

        public void SetDisplayName(string displayName)
        {
            if (displayName == String.Empty)
            {
                throw new ArgumentNullException(displayName, "The provided display name is empty.");
            }

            this.DisplayName = displayName;
        }

        public void SetEmail(string email)
        {
            if (email == String.Empty)
            {
                throw new ArgumentNullException(email, "The provided display name is empty.");
            }

            this.Email = email;
        }
    }   
}