namespace Prestamos.Materials.Contracts.Messages.Materials
{
    /// <summary>
    /// Message used to respond to the request <see cref="GetMaterialById"/>.
    /// </summary>
    public record GetMaterialByIdResponse
    {
        /// <summary>
        /// Gets or sets the Material Correlation Id.
        /// </summary>
        public Guid CorrelationId { get; set; }

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

