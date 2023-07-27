using System.Configuration;
using Microsoft.EntityFrameworkCore;
using MoneyTracker.Domain.Entities;

namespace MoneyTracker.Infra.Data.Contexts;

public class MoneyTrackerContext : DbContext
{
    public DbSet<Transaction> Transactions { get; set; }
    public DbSet<Category> Categories { get; set; }

    public MoneyTrackerContext()
    {
        
    }
    
    public MoneyTrackerContext(DbContextOptions<MoneyTrackerContext> options) : base(options)
    {
        
    }
    
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        var connection = ConfigurationManager.ConnectionStrings["SQLite"];

        optionsBuilder.UseSqlite(connection.ToString());
    }
    
    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.Entity<Transaction>(entity =>
        {
            entity.HasIndex(transaction => transaction.Id);
            entity.Property(transaction => transaction.CategoryId);
            entity.HasOne<Category>(transaction => transaction.Category);
        });
        
        builder.Entity<Category>(entity =>
        {
            entity.HasKey(category => category.Id);
            entity.HasData(new List<Category>
            {
                new(1, "Casa", 0),
                new(2, "Educação", 0),
                new(3, "Eletrônicos", 0),
                new(4, "Lazer", 0),
                new(5, "Restaurante", 0),
                new(6, "Saúde", 0),
                new(7, "Serviços", 0),
                new(8, "Supermercado", 0),
                new(9, "Transporte", 0),
                new(10, "Vestuário", 0),
                new(11, "Viagem", 0),
                new(12, "Outros", 0),
                new(13, "Investimentos", 1),
                new(14, "Presente", 1),
                new(15, "Prêmios", 1),
                new(16, "Salário", 1),
                new(17, "Outros", 1),
            });
        });
        
        base.OnModelCreating(builder);
    }
}