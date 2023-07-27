using AutoMapper;
using MoneyTracker.Application.Interfaces;
using MoneyTracker.Application.ViewModels;
using MoneyTracker.Domain.Entities;
using MoneyTracker.Domain.Interfaces;

namespace MoneyTracker.Application.Services;

public class TransactionAppService : ITransactionAppService
{
    private readonly IMapper _mapper;
    private readonly ITransactionRepository _transactionRepository;
    
    public TransactionAppService(
        IMapper mapper,
        ITransactionRepository transactionRepository)
    {
        _mapper = mapper;
        _transactionRepository = transactionRepository;
    }
    
    public async Task<List<TransactionViewModel>> GetAll()
    {
        return _mapper.Map<List<TransactionViewModel>>(await _transactionRepository.GetAll());
    }
    
    public async Task<int> AddTransaction(TransactionViewModel transaction)
    {
        return await _transactionRepository.Add(_mapper.Map<Transaction>(transaction));
    }
}