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

        public async Task<Material> Add(CreateMaterial createMaterial)
        {
            await using (_dbContext)
            {
                var materialType = await _dbContext.MaterialTypes.FindAsync(createMaterial.TypeCorrelationId);
                
                if (materialType == null)
                {
                    throw new ArgumentNullException($"There is no Material Type with given correlationId: {createMaterial.TypeCorrelationId}");
                }

                var material = new Material();

                material.SetDisplayName(createMaterial.DisplayName);
                material.SetMaterialType(materialType);

                await _dbContext.Materials.AddAsync(material);
                var result = await _dbContext.SaveChangesAsync();

                return material;
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

        public Task<Material> Update(UpdateMaterial updateMaterial)
        {
            throw new NotImplementedException();
        }
    }
}
