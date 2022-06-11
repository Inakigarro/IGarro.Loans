namespace Prestamos.Materials.Contracts.Messages.MaterialTypes
{
    /// <summary>
    /// Message used to request a material type by its Id.
    /// </summary>
    public record GetMaterialTypeById
    {
        /// <summary>
        /// Gets or sets the Material Type's Correlation Id.
        /// </summary>
        public Guid CorrelationId { get; set; }
    }
}

