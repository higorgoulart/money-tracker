namespace MoneyTracker.Domain.Entities;

public class Category
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Type { get; set; }

    public Category(int id, string name, int type)
    {
        Id = id;
        Name = name;
        Type = type;
    }
}