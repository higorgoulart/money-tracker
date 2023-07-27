using MoneyTracker.Domain.Entities;

namespace MoneyTracker.Application.Interfaces;

public interface ICategoryAppService
{
    Task<List<Category>> GetByType(Transaction.TypeEnum type);
}