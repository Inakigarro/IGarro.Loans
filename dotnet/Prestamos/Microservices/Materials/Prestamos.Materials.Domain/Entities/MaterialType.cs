using MassTransit;

namespace Prestamos.Materials.Domain.Entities
{
    public class MaterialType
    {
        /// <summary>
        /// Initialize a new <see cref="MaterialType"/> instance.
        /// </summary>
        public MaterialType()
        {
            this.CorrelationId = NewId.NextGuid();
        }

        #region Properties

        /// <summary>
        /// Gets or sets the Material Type's Correlation Id.
        /// </summary>
        public Guid CorrelationId { get; set; }
        
        /// <summary>
        /// Gets or sets the Material Type's Display Name.
        /// </summary>
        public string DisplayName { get; private set; } = null!;
        
        /// <summary>
        /// Gets or sets the Material Type's Code.
        /// </summary>
        public string Code { get; private set; } = null!;

        #endregion

        #region Methods

        public void SetDisplayName(string displayName)
        {
            if (displayName == String.Empty)
            {
                throw new ArgumentNullException(displayName, "The provided display name is empty.");
            }

            this.DisplayName = displayName;
        }

        public void SetCode(string code)
        {
            if (code == String.Empty)
            {
                throw new ArgumentNullException(code, "The provided display name is empty.");
            }

            this.Code = code;
        }

        #endregion
    }
}