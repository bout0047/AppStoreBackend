using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using AppStoreBackend.Data; // Reference your Data folder
using AppStoreBackend.Services; // Custom services

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

// Configure Database Context with Connection String
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(
        builder.Configuration.GetConnectionString("DefaultConnection")
    ));

// Add Controllers
builder.Services.AddControllers();

// Configure Swagger
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo
    {
        Title = "App Store API",
        Version = "v1",
        Description = "API for managing the App Store backend"
    });
});

// Add Custom Application Services (Dependency Injection)
builder.Services.AddScoped<IAppService, AppService>();
builder.Services.AddScoped<ICategoryService, CategoryService>();
builder.Services.AddScoped<IUserService, UserService>();

// Enable CORS (Cross-Origin Resource Sharing)
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAllOrigins", policy =>
    {
        policy.AllowAnyOrigin()
              .AllowAnyMethod()
              .AllowAnyHeader();
    });
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c =>
    {
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "App Store API v1");
    });
}

app.UseHttpsRedirection();

app.UseRouting();

// Enable CORS
app.UseCors("AllowAllOrigins");

app.UseAuthorization();

app.MapControllers();

app.Run();
