using Prestamos.Materials.Contracts.Messages.Materials;
using Prestamos.Materials.Domain.Entities;

namespace Prestamos.Materials.Persistence.Repositories.Materials
{
    public interface IMaterialRepository
    {
        /// <summary>
        /// Add a Material to the database.
        /// </summary>
        /// <param name="material"></param>
        /// <returns></returns>
        public Task<Material> Add(CreateMaterial material); 

        /// <summary>
        /// Update a Material.
        /// </summary>
        /// <param name="updateMaterial"></param>
        /// <returns></returns>
        public Task<Material> Update(UpdateMaterial updateMaterial);

        /// <summary>
        /// Get a Material by its Id.
        /// </summary>
        /// <param name="correlationId"></param>
        /// <returns></returns>
        public Task<Material> GetById(Guid correlationId);

        /// <summary>
        /// Get all the Materials.
        /// </summary>
        /// <returns></returns>
        public Task<IEnumerable<Material>> GetAll();
    }
}
