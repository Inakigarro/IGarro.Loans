using System.Threading.Tasks;
using AutoMapper;
using MassTransit;
using Prestamos.Materials.Contracts.Messages.Materials;
using Prestamos.Materials.Persistence.Repositories.Materials;

namespace Prestamos.Materials.Application.Consumers
{
    public class CreateMaterialConsumer : IConsumer<CreateMaterial>
    {
        private readonly IMaterialRepository _materialRepository;
        private readonly IMapper _mapper;

        public CreateMaterialConsumer(
            IMaterialRepository materialRepository,
            IMapper mapper)
        {
            _materialRepository = materialRepository;
            _mapper = mapper;
        }

        public async Task Consume(ConsumeContext<CreateMaterial> context)
        {
            var material = await _materialRepository.Add(context.Message);

            await context.Publish(_mapper.Map<MaterialUpdated>(material));
        }
    }
}