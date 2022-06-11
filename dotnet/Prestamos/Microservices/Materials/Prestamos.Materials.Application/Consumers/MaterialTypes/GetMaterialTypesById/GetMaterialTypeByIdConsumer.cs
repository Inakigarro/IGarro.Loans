using System.Threading.Tasks;
using AutoMapper;
using MassTransit;
using Prestamos.Materials.Contracts.Messages.MaterialTypes;
using Prestamos.Materials.Persistence.Repositories;

namespace Prestamos.Materials.Application.Consumers
{
    public class GetMaterialTypeByIdConsumer : IConsumer<GetMaterialTypeById>
    {
        private readonly IMaterialTypeRepository _repository;
        private readonly IMapper _mapper;

        public GetMaterialTypeByIdConsumer(IMaterialTypeRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public async Task Consume(ConsumeContext<GetMaterialTypeById> context)
        {
            var materialType = await _repository.GetById(context.Message.CorrelationId);
            await context.RespondAsync<GetMaterialTypeByIdResponse>(
                _mapper.Map<GetMaterialTypeByIdResponse>(materialType));
        }
    }
}