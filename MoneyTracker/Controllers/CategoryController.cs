using Microsoft.AspNetCore.Mvc;
using MoneyTracker.Application.Interfaces;
using MoneyTracker.Configuration;
using MoneyTracker.Domain.Entities;

namespace MoneyTracker.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryAppService _categoryAppService;

        public CategoryController()
        {
            _categoryAppService = IoC.GetInstance<ICategoryAppService>();
        }

        [HttpGet]
        public async Task<IEnumerable<Category>> Get(int type) => await _categoryAppService.GetByType((Transaction.TypeEnum) type);
    }
}