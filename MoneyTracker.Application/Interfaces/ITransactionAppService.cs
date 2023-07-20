using MoneyTracker.Application.ViewModels;

namespace MoneyTracker.Application.Interfaces;

public interface ITransactionAppService
{
    Task<List<TransactionViewModel>> GetAll();
    Task<TransactionViewModel> AddTransaction(TransactionViewModel transaction);
}