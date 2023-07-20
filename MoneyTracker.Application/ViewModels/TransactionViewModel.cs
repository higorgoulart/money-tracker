using Newtonsoft.Json;

namespace MoneyTracker.Application.ViewModels;

public class TransactionViewModel
{
    [JsonProperty("id")]
    public int Id { get; set; }
    
    [JsonProperty("value")]
    public decimal Value { get; set; }
        
    [JsonProperty("date")]
    public DateTime Date { get; set; }
        
    [JsonProperty("type")]
    public int Type { get; set; }
        
    [JsonProperty("description")]
    public string? Description { get; set; }
        
    [JsonProperty("category")]
    public int Category { get; set; }
}