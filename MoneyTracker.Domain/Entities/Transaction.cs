using System.ComponentModel;
using Newtonsoft.Json;

namespace MoneyTracker.Domain.Entities;

public class Transaction
{
    public int Id { get; set; }
    public decimal Value { get; set; }
    public DateTime Date { get; set; }
    public TypeEnum Type { get; set; }
    public string? Description { get; set; }
    public CategoryEnum Category { get; set; }

    public Transaction(TypeEnum type)
    {
        Type = type;
    }

    public enum TypeEnum
    {
        [Description("Despesa")] Expense = 0,
        [Description("Receita")] Revenue = 1
    }
    
    public enum CategoryEnum
    {
        [Description("Casa")] House = 0,
        [Description("Educação")] Education = 1,
        [Description("Eletrônicos")] Electronics = 3,
        [Description("Lazer")] Lounge = 4,
        [Description("Restaurante")] Restaurant = 5,
        [Description("Saúde")] Health = 6,
    }
}