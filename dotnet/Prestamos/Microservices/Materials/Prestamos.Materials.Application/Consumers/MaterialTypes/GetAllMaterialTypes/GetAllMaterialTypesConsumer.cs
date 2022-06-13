using AutoMapper;
using MassTransit;
using Prestamos.Materials.Contracts.Messages.MaterialTypes;
using Prestamos.Materials.Persistence.Repositories;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Prestamos.Materials.Application.Consumers
{
    public class GetAllMaterialTypesConsumer : IConsumer<GetAllMaterialTypes>
    {
        private readonly IMaterialTypeRepository _repository;
        private readonly IMapper _mapper;

        public GetAllMaterialTypesConsumer(IMaterialTypeRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task Consume(ConsumeContext<GetAllMaterialTypes> context)
        {
            var materialTypeList = await _repository.GetAll();

            await context.RespondAsync(new GetAllMaterialTypesResponse
            {
                MaterialTypes = _mapper.Map<IEnumerable<MaterialTypeUpdated>>(materialTypeList)
            });
        }
    }
}
