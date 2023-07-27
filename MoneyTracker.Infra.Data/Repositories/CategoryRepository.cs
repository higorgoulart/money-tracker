using MoneyTracker.Domain.Entities;
using MoneyTracker.Domain.Interfaces;
using MoneyTracker.Infra.Data.Contexts;

namespace MoneyTracker.Infra.Data.Repositories;

public class CategoryRepository : ICategoryRepository
{
    private readonly MoneyTrackerContext _context;
    
    public CategoryRepository(MoneyTrackerContext context)
    {
        _context = context;
    }
    
    public Task<IQueryable<Category>> GetByType(Transaction.TypeEnum type)
    {
        return Task.FromResult(_context.Categories.Where(category => category.Type == (int) type));
    }
}