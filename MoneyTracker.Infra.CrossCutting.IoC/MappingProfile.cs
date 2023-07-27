using AutoMapper;
using MoneyTracker.Application.ViewModels;
using MoneyTracker.Domain.Entities;

namespace MoneyTracker.Infra.CrossCutting.IoC;

public class MappingProfile : Profile
{
    public MappingProfile() 
    {
        CreateMap<Transaction, TransactionViewModel>();
        CreateMap<TransactionViewModel, Transaction>();
    }
}