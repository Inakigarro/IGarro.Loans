namespace Prestamos.Materials.Contracts.Messages.MaterialTypes
{
    /// <summary>
    /// Message used to respond to the GetAllMaterialTypes request.
    /// </summary>
    public record GetAllMaterialTypesResponse
    {
        public IEnumerable<MaterialTypeUpdated> MaterialTypes { get; set; } = null!;
    }
}

