using Microsoft.EntityFrameworkCore;
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

        public async Task<Material> Add(CreateMaterial material)
        {
            await using (_dbContext)
            {
                var materialType = await _dbContext.MaterialTypes.FindAsync(material.TypeCorrelationId);
                
                if(materialType == null)
                {
                    throw new InvalidOperationException($"An error occured while creating a material. There is no material type with given CorrelationId: {material.TypeCorrelationId}");
                }
                var newMaterial = new Material();

                newMaterial.SetDisplayName(material.DisplayName);
                newMaterial.SetMaterialType(materialType);
                
                await _dbContext.Materials.AddAsync(newMaterial);
                var result = await _dbContext.SaveChangesAsync();
                
                if (result != 1)
                {
                    throw new InvalidOperationException("An error occured when creating a new Material Type");
                }

                return newMaterial;
            }
        }

        public async Task<Material> Update(UpdateMaterial updateMaterial)
        {
            using (_dbContext)
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

        public async Task<IEnumerable<Material>> GetAll()
        {
            await using (_dbContext)
            {
                var materials = await _dbContext.Materials.ToListAsync();
                return materials;
            }
        }

        public async Task<Material> GetById(Guid correlationId)
        {
            await using (_dbContext)
            {
                var material = await _dbContext.Materials.FindAsync(correlationId);

                if (material == null)
                {
                    throw new InvalidOperationException(
                        $"There is no Material with the given correlationId: {correlationId}");
                }

                return material;   
            }
        }
    }
}
