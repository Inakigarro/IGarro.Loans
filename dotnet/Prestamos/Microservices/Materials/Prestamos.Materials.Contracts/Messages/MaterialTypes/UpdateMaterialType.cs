namespace Prestamos.Materials.Contracts.Messages.MaterialTypes
{
    public record UpdateMaterialType
    {
        /// <summary>
        /// Gets or sets the Material Type's Correlation Id.
        /// </summary>
        public Guid CorrelationId { get; set; }
        
        /// <summary>
        /// Gets or sets the Material Type's Display Name.
        /// </summary>
        public string DisplayName { get; set; } = null!;
        
        /// <summary>
        /// Gets or sets the Material Type's Code.
        /// </summary>
        public string Code { get; set; } = null!;
    }
}