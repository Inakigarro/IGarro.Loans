using MassTransit;
using Microsoft.AspNetCore.Mvc;
using Prestamos.Users.Application.Contracts;

namespace Loans.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsersController : ControllerBase
    {
        private readonly IPublishEndpoint _publishEndpoint;
        private readonly IRequestClient<GetUsersById> _userByIdClient;
        private readonly IRequestClient<GetAllUsers> _usersClient;

        public UsersController(
            IPublishEndpoint publishEndpoint,
            IRequestClient<GetUsersById> userByIdClient,
            IRequestClient<GetAllUsers> usersClient)
        {
            _publishEndpoint = publishEndpoint;
            _userByIdClient = userByIdClient;
            _usersClient = usersClient;
        }
        
        [HttpPost("CreateUser")]
        public async Task CreateUser(CreateUser createUser)
        {
            await _publishEndpoint.Publish(createUser);
        }
        
        
        [HttpPost("UpdateUser")]
        public async Task UpdateUser(UpdateUser updateUser)
        {
            await _publishEndpoint.Publish(updateUser);
        }

        [HttpPost("GetUserById")]
        public async Task<GetUsersByIdResponse> GetUserById(GetUsersById getUserById)
        {
            var response = await _userByIdClient.GetResponse<GetUsersByIdResponse>(getUserById);
            return response.Message;
        }

        [HttpGet("GetAllUsers")]
        public async Task<GetAllUsersResponse> GetAllUsers()
        {
            var response = await _usersClient.GetResponse<GetAllUsersResponse>(new GetAllUsers());
            return response.Message;
        }
    }   
}