using Microsoft.EntityFrameworkCore;
using Prestamos.Materials.Contracts.Messages.MaterialTypes;
using Prestamos.Materials.Domain.Entities;

namespace Prestamos.Materials.Persistence.Repositories
{
    public class MaterialTypeRepository : IMaterialTypeRepository
    {
        private readonly MaterialsDbContext _dbContext;

        public MaterialTypeRepository(MaterialsDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        
        public async Task<MaterialType> Add(CreateMaterialType materialType)
        {
            await using (_dbContext)
            {
                var newMaterialType = new MaterialType();
            
                newMaterialType.SetDisplayName(materialType.DisplayName);
                newMaterialType.SetCode(materialType.Code);

                await _dbContext.AddAsync(newMaterialType);
                var result = await _dbContext.SaveChangesAsync();

                if (result != 1)
                {
                    throw new InvalidOperationException("An error occured when creating a new Material Type");
                }

                return newMaterialType;
            }
        }

        public async Task<MaterialType> Update(UpdateMaterialType materialType)
        {
            await using (_dbContext)
            {
                var updatedMaterialType = await _dbContext.MaterialTypes.FindAsync(materialType.CorrelationId);

                if (updatedMaterialType == null)
                {
                    throw new InvalidOperationException($"There is no Material Type with the given correlationId: {materialType.CorrelationId}");
                }
                
                updatedMaterialType.SetCode(materialType.Code);
                updatedMaterialType.SetDisplayName(materialType.DisplayName);

                var result = await _dbContext.SaveChangesAsync();
                
                if (result != 1)
                {
                    throw new InvalidOperationException("An error occured when updating a new Material Type");
                }

                return updatedMaterialType;
            }
        }

        public async Task<MaterialType> GetById(Guid correlationId)
        {
            await using (_dbContext)
            {
                var materialType = await _dbContext.MaterialTypes.FindAsync(correlationId);
                
                if (materialType == null)
                {
                    throw new InvalidOperationException($"There is no Material Type with the given correlationId: {correlationId}");
                }

                return materialType;
            }
        }

        public async Task<IEnumerable<MaterialType>> GetAll()
        {
            await using (_dbContext)
            {
                var materialTypes = await _dbContext.MaterialTypes.ToListAsync();
                return materialTypes;
            }
        }
    }   
}