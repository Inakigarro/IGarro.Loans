using Prestamos.Materials.Contracts.Messages.MaterialTypes;
using Prestamos.Materials.Domain.Entities;

namespace Prestamos.Materials.Persistence.Repositories
{
    public interface IMaterialTypeRepository
    {
        /// <summary>
        /// Add a material type to the database.
        /// </summary>
        /// <param name="materialType"></param>
        /// <returns></returns>
        public Task<MaterialType> Add(CreateMaterialType materialType);

        /// <summary>
        /// Update a material type.
        /// </summary>
        /// <param name="materialType"></param>
        /// <returns></returns>
        public Task<MaterialType> Update(UpdateMaterialType materialType);
        
        /// <summary>
        /// Get a material type by its Id.
        /// </summary>
        /// <param name="correlationId"></param>
        /// <returns></returns>
        public Task<MaterialType> GetById(Guid correlationId);

        /// <summary>
        /// Get all the material types.
        /// </summary>
        /// <returns></returns>
        public Task<IEnumerable<MaterialType>> GetAll();
    }   
}