namespace Prestamos.Materials.Contracts.Messages.Materials
{
    /// <summary>
    /// Message used to request a material by its Id.
    /// </summary>
    public record GetMaterialById
    {
        /// <summary>
        /// Gets or sets the Material Correlation Id.
        /// </summary>
        public Guid CorrelationId { get; set; }
    }
}

