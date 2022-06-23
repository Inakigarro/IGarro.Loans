using MassTransit;
using Microsoft.AspNetCore.Mvc;
using Prestamos.Materials.Contracts.Messages.MaterialTypes;

namespace Loans.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MaterialTypesController : ControllerBase
    {
        private readonly IPublishEndpoint _publishEndpoint;
        private readonly IRequestClient<GetMaterialTypeById> _materialTypeByIdClient;
        private readonly IRequestClient<GetAllMaterialTypes> _allMaterialTypesClient;

        public MaterialTypesController(IPublishEndpoint publishEndpoint, IRequestClient<GetMaterialTypeById> materialTypeByIdClient, IRequestClient<GetAllMaterialTypes> allMaterialTypesClient)
        {
            _publishEndpoint = publishEndpoint;
            _materialTypeByIdClient = materialTypeByIdClient;
            _allMaterialTypesClient = allMaterialTypesClient;
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
            var response = await _materialTypeByIdClient.GetResponse<GetMaterialTypeByIdResponse>(getMaterialTypeById);
            return response.Message;
        }

        [HttpGet("GetAllMaterialTypes")]
        public async Task<GetAllMaterialTypesResponse> GetAllMaterialTypes()
        {
            var response = await _allMaterialTypesClient.GetResponse<GetAllMaterialTypesResponse>(new GetAllMaterialTypes());
            return response.Message;
        }
    }
}

