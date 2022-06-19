using System;
using System.Threading.Tasks;
using AutoMapper;
using MassTransit;
using Prestamos.Materials.Contracts.Messages.Materials;
using Prestamos.Materials.Domain.Entities;
using Prestamos.Materials.Persistence.Repositories;
using Prestamos.Materials.Persistence.Repositories.Materials;

namespace Prestamos.Materials.Application.Consumers
{
    public class CreateMaterialConsumer : IConsumer<CreateMaterial>
    {
        private readonly IMaterialRepository _materialRepository;
        private readonly IMaterialTypeRepository _materialTypeRepository;
        private readonly IMapper _mapper;

        public CreateMaterialConsumer(
            IMaterialRepository materialRepository,
            IMaterialTypeRepository materialTypeRepository,
            IMapper mapper)
        {
            _materialRepository = materialRepository;
            _materialTypeRepository = materialTypeRepository;
            _mapper = mapper;
        }

        public async Task Consume(ConsumeContext<CreateMaterial> context)
        {
            var materialType = await _materialTypeRepository.GetById(context.Message.TypeCorrelationId);

            if(materialType == null)
            {
                throw new InvalidOperationException($"An error occured while creating a material. There is no material type with given CorrelationId: {context.Message.TypeCorrelationId}");
            }

            var material = new Material();

            material.SetDisplayName(context.Message.DisplayName);
            material.SetMaterialType(materialType);

            await _materialRepository.Add(material);

            await context.Publish(_mapper.Map<MaterialUpdated>(material));
        }
    }
}