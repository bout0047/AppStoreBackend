using System.Collections.Generic;
using System.Text.Json.Serialization;

public class Category
{
    public int Id { get; set; }
    public string CategoryName { get; set; }
    public string IconPath { get; set; }

    [JsonIgnore] // Prevents circular reference when serializing
    public ICollection<App> Apps { get; set; }
}
