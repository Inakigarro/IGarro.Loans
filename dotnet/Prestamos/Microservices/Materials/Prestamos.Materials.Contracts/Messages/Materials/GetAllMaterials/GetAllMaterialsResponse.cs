namespace Prestamos.Materials.Contracts.Messages.Materials
{
    /// <summary>
    /// Message used to respond to the GetAllMaterials request.
    /// </summary>
    public record GetAllMaterialsResponse
    {
        /// <summary>
        /// Gets or sets the Materials.
        /// </summary>
        public IEnumerable<MaterialUpdated> Materials { get; set; } = null!;
    }
}
