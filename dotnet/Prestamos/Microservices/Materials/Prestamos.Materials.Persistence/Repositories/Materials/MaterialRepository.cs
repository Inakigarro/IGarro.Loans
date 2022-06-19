using Prestamos.Materials.Contracts.Messages.Materials;
using Prestamos.Materials.Domain.Entities;

namespace Prestamos.Materials.Persistence.Repositories.Materials
{
    public class MaterialRepository : IMaterialRepository
    {
        private readonly MaterialsDbContext _dbContext;

        public MaterialRepository(MaterialsDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task Add(Material material)
        {
            await using (_dbContext)
            {
                await _dbContext.Materials.AddAsync(material);
                var result = await _dbContext.SaveChangesAsync();
            }
        }

        public async Task<Material> Update(UpdateMaterial updateMaterial)
        {
            await using (_dbContext)
            {
                var updatedMaterial = _dbContext.Materials.Where(x => x.CorrelationId == updateMaterial.CorrelationId).FirstOrDefault();

                if (updatedMaterial == null)
                {
                    throw new InvalidOperationException($"There is no Material with the given Correlation Id: {updateMaterial.CorrelationId}");
                }

                if (updatedMaterial.TypeCorrelationId != updateMaterial.TypeCorrelationId)
                {
                    var materialType = await _dbContext.MaterialTypes.FindAsync(updateMaterial.TypeCorrelationId);

                    if (materialType == null)
                        throw new InvalidOperationException($"There is no Material Type with given Correlation Id: {updateMaterial.TypeCorrelationId}");

                    updatedMaterial.SetMaterialType(materialType);
                }

                updatedMaterial.SetDisplayName(updateMaterial.DisplayName);

                await _dbContext.SaveChangesAsync();

                return updatedMaterial;
            }
        }

        public Task<IEnumerable<Material>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<Material> GetById(Guid correlationId)
        {
            throw new NotImplementedException();
        }
    }
}
