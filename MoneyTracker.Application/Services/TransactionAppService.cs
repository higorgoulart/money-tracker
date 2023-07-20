using MoneyTracker.Application.Interfaces;
using MoneyTracker.Application.ViewModels;

namespace MoneyTracker.Application.Services;

public class TransactionAppService : ITransactionAppService
{
    private readonly List<TransactionViewModel> _transactions;
    
    public TransactionAppService()
    {
        _transactions = new List<TransactionViewModel>
        {
            new TransactionViewModel
            {
                Value = 100.5M,
                Date = DateTime.Today,
                Type = 0,
                Description = "TESTE",
                Category = 1
            }
        };
    }
    
    public Task<List<TransactionViewModel>> GetAll()
    {
        return Task.FromResult(_transactions);
    }
    
    public Task<TransactionViewModel> AddTransaction(TransactionViewModel transaction)
    {
        _transactions.Add(transaction);

        return Task.FromResult(transaction);
    }
}