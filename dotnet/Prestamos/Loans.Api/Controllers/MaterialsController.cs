using MassTransit;
using Microsoft.AspNetCore.Mvc;
using Prestamos.Materials.Contracts.Messages.Materials;

namespace Loans.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MaterialsController
    {
        private readonly IPublishEndpoint _publishEndpoint;
        private readonly IRequestClient<GetMaterialById> _materialByIdClient;
        private readonly IRequestClient<GetAllMaterials> _materialsClient;

        public MaterialsController(
            IPublishEndpoint publishEndpoint,
            IRequestClient<GetMaterialById> materialByIdClient,
            IRequestClient<GetAllMaterials> materialsClient)
        {
            _publishEndpoint = publishEndpoint;
            _materialByIdClient = materialByIdClient;
            _materialsClient = materialsClient;
        }
        
        [HttpPost("CreateMaterial")]
        public async Task CreateMaterial(CreateMaterial createMaterial)
        {
            await _publishEndpoint.Publish(createMaterial);
        }
        
        
        [HttpPost("UpdateMaterial")]
        public async Task UpdateMaterial(UpdateMaterial updateMaterial)
        {
            await _publishEndpoint.Publish(updateMaterial);
        }

        [HttpPost("GetMaterialById")]
        public async Task<GetMaterialByIdResponse> GetMaterialById(GetMaterialById getMaterialById)
        {
            var response = await _materialByIdClient.GetResponse<GetMaterialByIdResponse>(getMaterialById);
            return response.Message;
        }

        [HttpGet("GetAllMaterials")]
        public async Task<GetAllMaterialsResponse> GetAllMaterials()
        {
            var response = await _materialsClient.GetResponse<GetAllMaterialsResponse>(new GetAllMaterials());
            return response.Message;
        }
    }
}

