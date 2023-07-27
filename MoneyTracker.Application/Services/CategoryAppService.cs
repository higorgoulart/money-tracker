using AutoMapper;
using MoneyTracker.Application.Interfaces;
using MoneyTracker.Application.ViewModels;
using MoneyTracker.Domain.Entities;
using MoneyTracker.Domain.Interfaces;

namespace MoneyTracker.Application.Services;

public class CategoryAppService : ICategoryAppService
{
    private readonly IMapper _mapper;
    private readonly ICategoryRepository _categoryRepository;
    
    public CategoryAppService(
        IMapper mapper,
        ICategoryRepository categoryRepository)
    {
        _mapper = mapper;
        _categoryRepository = categoryRepository;
    }
    
    public async Task<List<Category>> GetByType(Transaction.TypeEnum type)
    {
        return (await _categoryRepository.GetByType(type)).ToList();
    }
}