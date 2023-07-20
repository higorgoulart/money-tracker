using System.ComponentModel;
using Newtonsoft.Json;

namespace MoneyTracker
{
    public class Transaction : ITransaction
    {
        [JsonProperty("value")]
        public decimal Value { get; set; }
        
        [JsonProperty("date")]
        public DateTime Date { get; set; }
        
        [JsonProperty("type")]
        public Enum Type { get; set; }
        
        [JsonProperty("description")]
        public string? Description { get; set; }
        
        [JsonProperty("category")]
        public int Category { get; set; }

        public Transaction(TypeEnum type)
        {
            Type = type;
        }
        
        [JsonConstructor]
        public Transaction(int type)
        {
            Type = (TypeEnum) type;
        }

        public enum TypeEnum
        {
            [Description("Despesa")] Expense = 0,
            [Description("Receita")] Revenue = 1
        }
    }
}