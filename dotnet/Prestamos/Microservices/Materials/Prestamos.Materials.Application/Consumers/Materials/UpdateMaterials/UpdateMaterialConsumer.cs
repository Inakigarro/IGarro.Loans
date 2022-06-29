using System.Threading.Tasks;
using AutoMapper;
using MassTransit;
using Prestamos.Materials.Contracts.Messages.Materials;
using Prestamos.Materials.Persistence.Repositories.Materials;

namespace Prestamos.Materials.Application.Consumers
{
    public class UpdateMaterialConsumer : IConsumer<UpdateMaterial>
    {
        private readonly IMaterialRepository _materialRepository;
        private readonly IMapper _mapper;

        public UpdateMaterialConsumer(
            IMaterialRepository materialRepository,
            IMapper mapper)
        {
            _materialRepository = materialRepository;
            _mapper = mapper;
        }

        public async Task Consume(ConsumeContext<UpdateMaterial> context)
        {
            var materialUpdated = await _materialRepository.Update(context.Message);
            await context.Publish(_mapper.Map<MaterialUpdated>(materialUpdated));
        }
    }
}