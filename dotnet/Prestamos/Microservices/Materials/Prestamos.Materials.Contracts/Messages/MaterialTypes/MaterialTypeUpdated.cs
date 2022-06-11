namespace Prestamos.Materials.Contracts.Messages.MaterialTypes
{
    /// <summary>
    /// Message used to inform when a Material Type were created or updated.
    /// </summary>
    public record MaterialTypeUpdated
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