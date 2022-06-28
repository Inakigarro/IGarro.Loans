using Prestamos.Users.Application.Contracts;
using Prestamos.Users.Domain.Entities;

namespace Prestamos.Users.Persistence.Repositories.Users
{
    public interface IUserRepository
    {
        /// <summary>
        /// Add a User to the database.
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public Task<User> Add(CreateUser user); 

        /// <summary>
        /// Update a User.
        /// </summary>
        /// <param name="updateUser"></param>
        /// <returns></returns>
        public Task<User> Update(UpdateUser updateUser);

        /// <summary>
        /// Get a User by its Id.
        /// </summary>
        /// <param name="correlationId"></param>
        /// <returns></returns>
        public Task<User> GetById(Guid correlationId);

        /// <summary>
        /// Get all the Users.
        /// </summary>
        /// <returns></returns>
        public Task<IEnumerable<User>> GetAll();
    }
}

