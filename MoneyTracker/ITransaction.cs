namespace MoneyTracker
{
    public interface ITransaction
    {
        decimal Value { get; set; }
        DateTime Date { get; set; }
        Enum Type { get; set; }
        string? Description { get; set; }
        int Category { get; set; }
    }
}