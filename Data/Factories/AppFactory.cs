using AppStoreBackend.Models;
using Bogus;
using System.Collections.Generic;

public static class AppFactory
{
    public static List<App> GenerateApps(int count, List<Category> categories)
    {
        var faker = new Faker<App>()
            .RuleFor(a => a.Name, f => f.Commerce.ProductName())
            .RuleFor(a => a.Description, f => f.Commerce.ProductDescription())
            .RuleFor(a => a.Price, f => f.Random.Decimal(0.99M, 99.99M))
            .RuleFor(a => a.Rating, f => f.Random.Double(1, 5))
            .RuleFor(a => a.IsPopular, f => f.Random.Bool())
            .RuleFor(a => a.CategoryId, f => f.PickRandom(categories).Id);

        return faker.Generate(count);
    }
}
