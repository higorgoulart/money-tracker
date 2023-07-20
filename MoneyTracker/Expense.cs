using System.ComponentModel;

namespace MoneyTracker
{
    public class Expense : Transaction
    {
        public new CategoryEnum Category { get; set; }
        
        public Expense(CategoryEnum category) : base(TypeEnum.Expense)
        {
            Category = category;
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
}