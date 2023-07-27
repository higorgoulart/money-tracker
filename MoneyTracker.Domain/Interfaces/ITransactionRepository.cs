using MoneyTracker.Domain.Entities;

namespace MoneyTracker.Domain.Interfaces;

public interface ITransactionRepository
{
    Task<IQueryable<Transaction>> GetAll();
    Task<int> Add(Transaction transaction);
}