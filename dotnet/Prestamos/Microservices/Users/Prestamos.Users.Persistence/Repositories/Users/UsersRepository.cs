using Microsoft.EntityFrameworkCore;
using Prestamos.Users.Application.Contracts;
using Prestamos.Users.Domain.Entities;

namespace Prestamos.Users.Persistence.Repositories.Users
{
    public class UsersRepository : IUserRepository
    {
        private readonly UsersDbContext _dbContext;

        public UsersRepository(UsersDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        
        public async Task<User> Add(CreateUser createUser)
        {
            await using (_dbContext)
            {
                var newUser = new User();
                newUser.SetDisplayName(createUser.DisplayName);
                newUser.SetEmail(createUser.Email);

                await _dbContext.Users.AddAsync(newUser);
                var result = await _dbContext.SaveChangesAsync();
                
                if (result != 1)
                {
                    throw new InvalidOperationException("An error occured when creating a new Material Type");
                }

                return newUser;
            }
        }

        public async Task<User> Update(UpdateUser updateUser)
        {
            await using (_dbContext)
            {
                var updatedUser = _dbContext.Users.FirstOrDefault(x => x.CorrelationId == updateUser.CorrelationId);

                if (updatedUser == null)
                {
                    throw new InvalidOperationException(
                        $"There is no user with given Correlation Id: {updateUser.CorrelationId}");
                }
                
                updatedUser.SetDisplayName(updateUser.DisplayName);
                updatedUser.SetEmail(updateUser.Email);

                await _dbContext.SaveChangesAsync();

                return updatedUser;
            }
        }

        public async Task<User> GetById(Guid correlationId)
        {
            await using (_dbContext)
            {
                var user = await _dbContext.Users.FindAsync(correlationId);

                if (user == null)
                {
                    throw new InvalidOperationException(
                        $"There is no user with given Correlation Id: {correlationId}"); 
                }

                return user;
            }
        }

        public async Task<IEnumerable<User>> GetAll()
        {
            await using (_dbContext)
            {
                var users = await _dbContext.Users.ToListAsync();
                return users;
            }
        }
    }   
}