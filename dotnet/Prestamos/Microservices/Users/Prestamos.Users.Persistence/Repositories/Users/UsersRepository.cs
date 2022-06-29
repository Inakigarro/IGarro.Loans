using Prestamos.Users.Application.Contracts;
using Prestamos.Users.Domain.Entities;

namespace Prestamos.Users.Persistence.Repositories.Users
{
    public class UsersRepository : IUserRepository
    {
        public Task<User> Add(CreateUser user)
        {
            throw new NotImplementedException();
        }

        public Task<User> Update(UpdateUser updateUser)
        {
            throw new NotImplementedException();
        }

        public Task<User> GetById(Guid correlationId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<User>> GetAll()
        {
            throw new NotImplementedException();
        }
    }   
}