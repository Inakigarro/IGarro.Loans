using System.Threading.Tasks;
using AutoMapper;
using MassTransit;
using Prestamos.Users.Application.Contracts;
using Prestamos.Users.Persistence.Repositories.Users;

namespace Prestamos.Users.Application.Consumers
{
    public class UpdateUserConsumer : IConsumer<UpdateUser>
    {
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;

        public UpdateUserConsumer(
            IUserRepository userRepository,
            IMapper mapper)
        {
            _userRepository = userRepository;
            _mapper = mapper;
        }
        
        public async Task Consume(ConsumeContext<UpdateUser> context)
        {
            var userUpdated = await _userRepository.Update(context.Message);
            await context.Publish(_mapper.Map<UserUpdated>(userUpdated));
        }
    }
}