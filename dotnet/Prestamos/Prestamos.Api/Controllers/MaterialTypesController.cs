using MassTransit;
using Microsoft.AspNetCore.Mvc;
using Prestamos.Materials.Contracts.Messages.MaterialTypes;

namespace Prestamos.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MaterialTypesController : ControllerBase
    {
        private readonly IPublishEndpoint _publishEndpoint;
        private readonly IRequestClient<GetMaterialTypeById> _client;

        public MaterialTypesController(IPublishEndpoint publishEndpoint, IRequestClient<GetMaterialTypeById> client)
        {
            _publishEndpoint = publishEndpoint;
            _client = client;
        }

        [HttpPost("CreateMaterialType")]
        public async Task CreateMaterialType(CreateMaterialType createMaterialType)
        {
            await _publishEndpoint.Publish(createMaterialType);
        }

        [HttpPost("UpdateMaterialType")]
        public async Task UpdateMaterialType(UpdateMaterialType updateMaterialType)
        {
            await _publishEndpoint.Publish(updateMaterialType);
        }

        [HttpPost("GetMaterialTypeById")]
        public async Task<GetMaterialTypeByIdResponse> GetMaterialTypeById(GetMaterialTypeById getMaterialTypeById)
        {
            var response = await _client.GetResponse<GetMaterialTypeByIdResponse>(getMaterialTypeById);
            return response.Message;
        }
    }
}

