using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using MassTransit;
using Prestamos.Materials.Contracts.Messages.Materials;
using Prestamos.Materials.Persistence.Repositories.Materials;

namespace Prestamos.Materials.Application.Consumers
{
    public class GetAllMaterialsConsumer : IConsumer<GetAllMaterials>
    {
        private readonly IMaterialRepository _materialRepository;
        private readonly IMapper _mapper;

        public GetAllMaterialsConsumer(IMaterialRepository materialRepository, IMapper mapper)
        {
            _materialRepository = materialRepository;
            _mapper = mapper;
        }
        
        public async Task Consume(ConsumeContext<GetAllMaterials> context)
        {
            var materialList = await _materialRepository.GetAll();
            
            await context.RespondAsync(new GetAllMaterialsResponse
            {
                Materials = _mapper.Map<IEnumerable<MaterialUpdated>>(materialList)
            });
        }
    }
}
