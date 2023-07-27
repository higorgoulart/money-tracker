using MoneyTracker.Domain.Entities;
using MoneyTracker.Domain.Interfaces;
using MoneyTracker.Infra.Data.Contexts;

namespace MoneyTracker.Infra.Data.Repositories;

public class TransactionRepository : ITransactionRepository
{
    private readonly MoneyTrackerContext _context;
    
    public TransactionRepository(MoneyTrackerContext context)
    {
        _context = context;
    }
    
    public Task<IQueryable<Transaction>> GetAll()
    {
        return Task.FromResult(_context.Transactions.AsQueryable());
    }

    public async Task<int> Add(Transaction transaction)
    {
        transaction.Id = (await GetAll())
            .Select(trans => trans.Id)
            .OrderByDescending(trans => trans)
            .FirstOrDefault() + 1;
        
        _context.Transactions.Add(transaction);
        await _context.SaveChangesAsync();
        return transaction.Id;
    }
}