using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using MassTransit;
using Prestamos.Users.Application.Contracts;
using Prestamos.Users.Persistence.Repositories.Users;


namespace Prestamos.Users.Application.Consumers
{
    public class GetAllUsersConsumer : IConsumer<GetAllUsers>
    {
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;

        public GetAllUsersConsumer(
            IUserRepository userRepository,
            IMapper mapper)
        {
            _userRepository = userRepository;
            _mapper = mapper;
        }


        public async Task Consume(ConsumeContext<GetAllUsers> context)
        {
            var users = await _userRepository.GetAll();
            await context.RespondAsync(_mapper.Map<IEnumerable<UserUpdated>>(users));
        }
    }
}