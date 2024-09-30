using Microsoft.EntityFrameworkCore;
using AppStoreBackend.Data;
using AppStoreBackend.Data.Seeders;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddControllers();

var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
    var dbContext = scope.ServiceProvider.GetRequiredService<AppDbContext>();
    dbContext.Database.Migrate(); // Apply migrations
    AppDbContextSeeder.Seed(dbContext); // Seed data
}

app.MapControllers();
app.Run();
