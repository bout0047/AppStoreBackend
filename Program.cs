using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using Microsoft.EntityFrameworkCore;
using AppStoreBackend.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Add CORS policy to allow access from specific domains (such as Flutter frontend)
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowFlutterApp", builder =>
    {
        builder.AllowAnyOrigin()
               .AllowAnyMethod()
               .AllowAnyHeader();
    });
});

// Add Swagger for API documentation
builder.Services.AddSwaggerGen();

// Add database context for SQL Server
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// Configure Authentication Middleware (JWT)
builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
    .AddJwtBearer(options =>
    {
        options.Authority = builder.Configuration["JwtSettings:Issuer"]; // Configured authority
        options.Audience = builder.Configuration["JwtSettings:Audience"]; // Update audience value
        options.RequireHttpsMetadata = false;
        options.TokenValidationParameters = new TokenValidationParameters
        {
            ValidateIssuer = true,
            ValidateAudience = true,
            ValidateLifetime = true,
            ValidateIssuerSigningKey = true,
            IssuerSigningKey = new SymmetricSecurityKey(System.Text.Encoding.UTF8.GetBytes(builder.Configuration["JwtSettings:SecretKey"]))
        };
    });

// Add controllers
builder.Services.AddControllers();

// Configure Kestrel to use HTTPS
builder.WebHost.ConfigureKestrel(options =>
{
    options.ListenAnyIP(5001, listenOptions =>
    {
        listenOptions.UseHttps("certificates/localhost.pfx", "your_certificate_password"); // Path to SSL certificate
    });
});

var app = builder.Build();

// Use Swagger
if (builder.Configuration.GetValue<bool>("Swagger:Enabled"))
{
    app.UseSwagger();
    app.UseSwaggerUI(c =>
    {
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "AppStoreBackend API v1");
    });
}

// Use HTTPS redirection
app.UseHttpsRedirection();

// Use CORS
app.UseCors("AllowFlutterApp");

// Use Authentication and Authorization
app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();
