using System.Threading.Tasks;
using AutoMapper;
using MassTransit;
using Prestamos.Materials.Contracts.Messages.MaterialTypes;
using Prestamos.Materials.Persistence.Repositories;

namespace Prestamos.Materials.Application.Consumers
{
    public class UpdateMaterialTypeConsumer : IConsumer<UpdateMaterialType>
    {
        private readonly IMaterialTypeRepository _repository;
        private readonly IMapper _mapper;

        public UpdateMaterialTypeConsumer(IMaterialTypeRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        
        public async Task Consume(ConsumeContext<UpdateMaterialType> context)
        {
            var materialType = await _repository.Update(context.Message);
            await context.Publish(_mapper.Map<MaterialTypeUpdated>(materialType));
        }
    }
}