// File: Program.cs
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using IdentityServer4.AccessTokenValidation;
using AppStoreBackend.Services;

var builder = WebApplication.CreateBuilder(args);

// Register services for DI
builder.Services.AddControllers();

// Configure IdentityServer Authentication
builder.Services.AddAuthentication(IdentityServerAuthenticationDefaults.AuthenticationScheme)
    .AddIdentityServerAuthentication(options =>
    {
        options.Authority = "https://localhost:5001"; // Adjust according to your Identity Server address
        options.ApiName = "appstore_api";
        options.RequireHttpsMetadata = false; // Set to true in production
    });

builder.Services.AddAuthorization();

// Register custom services
builder.Services.AddScoped<IAppService, AppService>();
builder.Services.AddScoped<ICategoryService, CategoryService>();
builder.Services.AddScoped<IUserService, UserService>();

var app = builder.Build();

// Middleware configuration
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}

app.UseHttpsRedirection();
app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();
