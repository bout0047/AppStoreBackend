using Microsoft.EntityFrameworkCore;
using AppStoreBackend.Data;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using AppStoreBackend.Services.Implementations;
using AppStoreBackend.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// Add CORS policy to allow your Flutter app to access the backend
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowFlutterApp",
        builder => builder
            .AllowAnyOrigin()  // Allow any origin (use specific domains in production)
            .AllowAnyMethod()
            .AllowAnyHeader());
});

// Configure Authentication Middleware (JWT)
builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
    .AddJwtBearer(options =>
    {
        options.Authority = "https://localhost:5001"; // Adjust this to your authority if needed
        options.Audience = "your-api-audience"; // Update the audience to match your backend configuration
        options.RequireHttpsMetadata = false;
        options.TokenValidationParameters = new TokenValidationParameters
        {
            ValidateIssuer = true,
            ValidateAudience = true,
            ValidateLifetime = true,
            ValidateIssuerSigningKey = true
        };
    });

// Add services to the DI container
builder.Services.AddScoped<IAppService, AppService>();
builder.Services.AddControllers();

var app = builder.Build();

// Use CORS
app.UseCors("AllowFlutterApp");

// Configure the HTTP request pipeline
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}

app.UseHttpsRedirection();
app.UseRouting();
app.UseAuthentication();  // Use Authentication
app.UseAuthorization();

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllers();
});

app.Run();
