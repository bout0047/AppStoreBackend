public class AppDTO
{
    // Option 1: Make properties nullable if they can be null
    public string? Name { get; set; }
    public string? Description { get; set; }

    // Option 2: Assign default values to avoid null issues
    // public string Name { get; set; } = string.Empty;
    // public string Description { get; set; } = string.Empty;

    // Option 3 (C# 11 or later): Add 'required' modifier
    // public required string Name { get; set; }
    // public required string Description { get; set; }
}
