using Microsoft.AspNetCore.Mvc;

namespace MoneyTracker.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TransactionController : ControllerBase
    {
        private static List<Transaction> _transactions = new List<Transaction>
        {
            new Expense(Expense.CategoryEnum.House)
            {
                Value = 100.50m,
                Date = DateTime.Today,
                Description = "TESTE"
            }
        };

        private readonly ILogger<TransactionController> _logger;

        public TransactionController(ILogger<TransactionController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<Transaction> Get()
        {
            return _transactions;
        }
        
        [HttpPost]
        public ActionResult<Transaction> Post([FromBody] Transaction transaction)
        {
            _transactions.Add(transaction);

            return transaction;
        }
    }
}