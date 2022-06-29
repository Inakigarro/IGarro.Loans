using MassTransit;

namespace Prestamos.Materials.Domain.Entities
{
    public class Material
    {
        /// <summary>
        /// Initialize a new <see cref="Material"/> instance.
        /// </summary>
        public Material()
        {
            this.CorrelationId = NewId.NextGuid();
        }

        /// <summary>
        /// Gets or sets the Material Correlation Id.
        /// </summary>
        public Guid CorrelationId { get; set; }

        /// <summary>
        /// Gets or sets the Material Correlation Id.
        /// </summary>
        public string DisplayName { get; private set; } = null!;

        /// <summary>
        /// Gets or sets the Material Type Correlation Id.
        /// </summary>
        public Guid TypeCorrelationId { get; set; }

        /// <summary>
        /// Gets or sets the Material Type.
        /// </summary>
        public MaterialType Type { get; set; } = null!;

        public void SetDisplayName(string displayName)
        {
            if (displayName == String.Empty)
            {
                throw new ArgumentNullException(displayName, "The provided display name is empty.");
            }

            this.DisplayName = displayName;
        }

        public void SetMaterialType(MaterialType type)
        {
            this.Type = type;
            this.TypeCorrelationId = type.CorrelationId;
        }
    }
}