using Microsoft.EntityFrameworkCore;
using AppStoreBackend.Data;
using AppStoreBackend.Services;
using AppStoreBackend.Services.Implementations;
using AppStoreBackend.Services.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// Register your services
builder.Services.AddScoped<IAppService, AppService>();
builder.Services.AddScoped<ICategoryService, CategoryService>(); // If you have a category service
builder.Services.AddScoped<IUserService, UserService>(); // If you have a user service

// Add other services such as controllers
builder.Services.AddControllers();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}

app.UseHttpsRedirection();
app.UseAuthorization();

app.MapControllers();

app.Run();
