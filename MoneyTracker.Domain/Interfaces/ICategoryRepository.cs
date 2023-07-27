using MoneyTracker.Domain.Entities;

namespace MoneyTracker.Domain.Interfaces;

public interface ICategoryRepository
{
    Task<IQueryable<Category>> GetByType(Transaction.TypeEnum type);
}