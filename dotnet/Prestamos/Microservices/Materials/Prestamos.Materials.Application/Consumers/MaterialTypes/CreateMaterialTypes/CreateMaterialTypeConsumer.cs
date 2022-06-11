using System.Threading.Tasks;
using AutoMapper;
using MassTransit;
using Prestamos.Materials.Contracts.Messages.MaterialTypes;
using Prestamos.Materials.Persistence.Repositories;

namespace Prestamos.Materials.Application.Consumers
{
    public class CreateMaterialTypeConsumer : IConsumer<CreateMaterialType>
    {
        private readonly IMaterialTypeRepository _repository;
        private readonly IMapper _mapper;

        public CreateMaterialTypeConsumer(IMaterialTypeRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        
        public async Task Consume(ConsumeContext<CreateMaterialType> context)
        {
            var materialType = await _repository.Add(context.Message);
            await context.Publish(_mapper.Map<MaterialTypeUpdated>(materialType));
        }
    }
}