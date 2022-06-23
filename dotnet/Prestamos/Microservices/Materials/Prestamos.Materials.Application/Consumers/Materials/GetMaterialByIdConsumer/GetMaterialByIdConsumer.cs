using System.Threading.Tasks;
using AutoMapper;
using MassTransit;
using Prestamos.Materials.Contracts.Messages.Materials;
using Prestamos.Materials.Persistence.Repositories.Materials;

namespace Prestamos.Materials.Application.Consumers.GetMaterialByIdConsumer
{
    public class GetMaterialByIdConsumer : IConsumer<GetMaterialById>
    {
        private readonly IMaterialRepository _materialRepository;
        private readonly IMapper _mapper;

        public GetMaterialByIdConsumer(IMaterialRepository materialRepository, IMapper mapper)
        {
            _materialRepository = materialRepository;
            _mapper = mapper;
        }

        public async Task Consume(ConsumeContext<GetMaterialById> context)
        {
            var material = await _materialRepository.GetById(context.Message.CorrelationId);
            await context.RespondAsync(_mapper.Map<GetMaterialByIdResponse>(material));
        }
    }
}