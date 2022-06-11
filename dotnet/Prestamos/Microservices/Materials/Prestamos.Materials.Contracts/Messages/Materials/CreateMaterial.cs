namespace Prestamos.Materials.Contracts.Messages.Materials
{
    public record CreateMaterial
    {
        /// <summary>
        /// Gets or sets the Material Correlation Id.
        /// </summary>
        public string DisplayName { get; set; } = null!;

        /// <summary>
        /// Gets or sets the Material Type Correlation Id.
        /// </summary>
        public Guid TypeCorrelationId { get; set; }
    }
}