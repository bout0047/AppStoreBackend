using AppStoreBackend.Models;

public class ApplicationData
{
    // Assuming this is similar to App or provides extended information
    public int Id { get; set; }
    public required string Name { get; set; }
    public required string Description { get; set; }
    public required Category Category { get; set; }
    // Other properties...
}
