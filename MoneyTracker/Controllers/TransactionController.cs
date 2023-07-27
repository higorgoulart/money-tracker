using Microsoft.AspNetCore.Mvc;
using MoneyTracker.Application.Interfaces;
using MoneyTracker.Application.ViewModels;
using MoneyTracker.Configuration;

namespace MoneyTracker.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TransactionController : ControllerBase
    {
        private readonly ITransactionAppService _transactionAppService;

        public TransactionController()
        {
            _transactionAppService = IoC.GetInstance<ITransactionAppService>();
        }

        [HttpGet]
        public async Task<IEnumerable<TransactionViewModel>> Get() => await _transactionAppService.GetAll();

        [HttpPost]
        public async Task<ActionResult<int>> Post([FromBody] TransactionViewModel transaction) => await _transactionAppService.AddTransaction(transaction);
    }
}