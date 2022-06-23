using AutoMapper;
using Prestamos.Materials.Contracts.Messages.MaterialTypes;
using Prestamos.Materials.Domain.Entities;

namespace Prestamos.Materials.Application.AutoMapperProfiles
{
    public class MaterialTypeProfile : Profile
    {
        public MaterialTypeProfile()
        {
            this.CreateMap<MaterialType, MaterialTypeUpdated>()
                .ForMember(dto => dto.CorrelationId, s => s.MapFrom(entity => entity.CorrelationId))
                .ForMember(dto => dto.DisplayName, s => s.MapFrom(entity => entity.DisplayName))
                .ForMember(dto => dto.Code, s => s.MapFrom(entity => entity.CorrelationId));

            this.CreateMap<MaterialType, GetMaterialTypeByIdResponse>()
                .ForMember(dto => dto.CorrelationId, s => s.MapFrom(entity => entity.CorrelationId))
                .ForMember(dto => dto.DisplayName, s => s.MapFrom(entity => entity.DisplayName))
                .ForMember(dto => dto.Code, s => s.MapFrom(entity => entity.Code));
        }
    }
}