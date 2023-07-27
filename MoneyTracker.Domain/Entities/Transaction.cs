using System.ComponentModel;

namespace MoneyTracker.Domain.Entities;

public class Transaction
{
    public int Id { get; set; }
    public decimal Value { get; set; }
    public DateTime Date { get; set; }
    public int Type { get; set; }
    public string? Description { get; set; }
    public int CategoryId { get; set; }
    public Category Category { get; set; }

    public enum TypeEnum
    {
        [Description("Despesa")] Expense = 0,
        [Description("Receita")] Revenue = 1
    }
}