using AutoMapper;
using Prestamos.Users.Application.Contracts;
using Prestamos.Users.Domain.Entities;

namespace Prestamos.Users.Application.AutoMapperProfiles
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            this.CreateMap<User, UserUpdated>()
                .ForMember(dto => dto.CorrelationId, s => s.MapFrom(entity => entity.CorrelationId))
                .ForMember(dto => dto.DisplayName, s => s.MapFrom(entity => entity.DisplayName))
                .ForMember(dto => dto.Email, s => s.MapFrom(entity => entity.Email));
            
            this.CreateMap<User, GetUsersByIdResponse>()
                .ForMember(dto => dto.CorrelationId, s => s.MapFrom(entity => entity.CorrelationId))
                .ForMember(dto => dto.DisplayName, s => s.MapFrom(entity => entity.DisplayName))
                .ForMember(dto => dto.Email, s => s.MapFrom(entity => entity.Email));
        }
    }
}