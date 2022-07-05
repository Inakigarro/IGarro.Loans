using AutoMapper;
using Prestamos.Loans.Contracts;
using Prestamos.Loans.Contracts.GetLoanLinesById;
using Prestamos.Loans.Domain.Entities;

namespace Prestamos.Loans.Application.AutoMapperProfiles
{
    public class LoanLineProfile : Profile
    {
        public LoanLineProfile()
        {
            this.CreateMap<LoanLine, LoanLineUpdated>()
                .ForMember(dto => dto.CorrelationId, s => s.MapFrom(entity => entity.CorrelationId))
                .ForMember(dto => dto.Number, s => s.MapFrom(entity => entity.Number))
                .ForMember(dto => dto.MaterialCorrelationId, s => s.MapFrom(entity => entity.MaterialCorrelationId));
            
            this.CreateMap<LoanLine, GetLoanLineByIdResponse>()
                .ForMember(dto => dto.CorrelationId, s => s.MapFrom(entity => entity.CorrelationId))
                .ForMember(dto => dto.Number, s => s.MapFrom(entity => entity.Number))
                .ForMember(dto => dto.MaterialCorrelationId, s => s.MapFrom(entity => entity.MaterialCorrelationId));
        }
    }
}