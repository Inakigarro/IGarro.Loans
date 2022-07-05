using AutoMapper;
using Prestamos.Loans.Contracts;
using Prestamos.Loans.Contracts.GetLoansById;
using Prestamos.Loans.Domain.Entities;

namespace Prestamos.Loans.Application.AutoMapperProfiles
{
    public class LoanProfile : Profile
    {
        public LoanProfile()
        {
            this.CreateMap<Loan, LoanUpdated>()
                .ForMember(dto => dto.CorrelationId, s => s.MapFrom(entity => entity.CorrelationId))
                .ForMember(dto => dto.InitialDate, s => s.MapFrom(entity => entity.InitialDate))
                .ForMember(dto => dto.EndDate, s => s.MapFrom(entity => entity.EndDate))
                .ForMember(dto => dto.EstimatedEndDate, s => s.MapFrom(entity => entity.EstimatedEndDate))
                .ForMember(dto => dto.OwnerCorrelationId, s => s.MapFrom(entity => entity.OwnerCorrelationId))
                .ForMember(dto => dto.LoanLines, s => s.MapFrom(entity => entity.LoanLines));
            
            this.CreateMap<Loan, GetLoanByIdResponse>()
                .ForMember(dto => dto.CorrelationId, s => s.MapFrom(entity => entity.CorrelationId))
                .ForMember(dto => dto.InitialDate, s => s.MapFrom(entity => entity.InitialDate))
                .ForMember(dto => dto.EndDate, s => s.MapFrom(entity => entity.EndDate))
                .ForMember(dto => dto.EstimatedEndDate, s => s.MapFrom(entity => entity.EstimatedEndDate))
                .ForMember(dto => dto.OwnerCorrelationId, s => s.MapFrom(entity => entity.OwnerCorrelationId))
                .ForMember(dto => dto.LoanLines, s => s.MapFrom(entity => entity.LoanLines));
        }
    }
}