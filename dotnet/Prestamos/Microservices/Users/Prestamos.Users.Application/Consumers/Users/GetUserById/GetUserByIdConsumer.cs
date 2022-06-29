using System.Threading.Tasks;
using AutoMapper;
using MassTransit;
using Prestamos.Users.Application.Contracts;
using Prestamos.Users.Persistence.Repositories.Users;

namespace Prestamos.Users.Application.Consumers
{
    public class GetUserByIdConsumer : IConsumer<GetUsersById>
    {
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;

        public GetUserByIdConsumer(
            IUserRepository userRepository,
            IMapper mapper)
        {
            _userRepository = userRepository;
            _mapper = mapper;
        }
        
        public async Task Consume(ConsumeContext<GetUsersById> context)
        {
            var user = await _userRepository.GetById(context.Message.CorrelationId);
            await context.RespondAsync(_mapper.Map<GetUsersByIdResponse>(user));
        }
    }
}