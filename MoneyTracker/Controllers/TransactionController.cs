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
        private ITransactionAppService _transactionAppService;
        private readonly ILogger<TransactionController> _logger;

        public TransactionController(ILogger<TransactionController> logger)
        {
            _transactionAppService = IoC.GetInstance<ITransactionAppService>();
            _logger = logger;
        }

        [HttpGet]
        public async Task<IEnumerable<TransactionViewModel>> Get() => await _transactionAppService.GetAll();

        [HttpPost]
        public async Task<ActionResult<TransactionViewModel>> Post([FromBody] TransactionViewModel transaction) => await _transactionAppService.AddTransaction(transaction);
    }
}