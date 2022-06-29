using System.Threading.Tasks;
using AutoMapper;
using MassTransit;
using Prestamos.Users.Application.Contracts;
using Prestamos.Users.Persistence.Repositories.Users;

namespace Prestamos.Users.Application.Consumers
{
    public class CreateUserConsumer : IConsumer<CreateUser>
    {
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;

        public CreateUserConsumer(
            IUserRepository userRepository,
            IMapper mapper)
        {
            _userRepository = userRepository;
            _mapper = mapper;
        }

        public async Task Consume(ConsumeContext<CreateUser> context)
        {
            var user = await _userRepository.Add(context.Message);

            await context.Publish(_mapper.Map<UserUpdated>(user));
        }
    }
}