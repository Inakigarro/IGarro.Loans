using AutoMapper;
using Prestamos.Materials.Contracts.Messages.Materials;
using Prestamos.Materials.Domain.Entities;

namespace Prestamos.Materials.Application.AutoMapperProfiles
{
    public class MaterialProfile : Profile
    {
        public MaterialProfile()
        {
            this.CreateMap<Material, MaterialUpdated>()
                .ForMember(dto => dto.CorrelationId, s => s.MapFrom(entity => entity.CorrelationId))
                .ForMember(dto => dto.DisplayName, s => s.MapFrom(entity => entity.DisplayName))
                .ForMember(dto => dto.TypeCorrelationId, s => s.MapFrom(entity => entity.TypeCorrelationId));

            this.CreateMap<Material, GetMaterialByIdResponse>()
                .ForMember(dto => dto.CorrelationId, s => s.MapFrom(entity => entity.CorrelationId))
                .ForMember(dto => dto.DisplayName, s => s.MapFrom(entity => entity.DisplayName))
                .ForMember(dto => dto.TypeCorrelationId, s => s.MapFrom(entity => entity.TypeCorrelationId));
        }
    }
}
