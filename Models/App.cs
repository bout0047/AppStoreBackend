using AppStoreBackend.Models;
using System.Text.Json.Serialization;

public class App
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public decimal Price { get; set; }
    public int CategoryId { get; set; }

    [JsonIgnore] // Prevents circular reference when serializing
    public Category Category { get; set; }
}
