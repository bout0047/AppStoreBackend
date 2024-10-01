using AppStoreBackend.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

public class Startup
{
    // This method gets called by the runtime to add services to the container.
    public void ConfigureServices(IServiceCollection services)
    {
        // Define your connection string for the SQL Server instance.
        string connectionString = "Server=LAPTOP-MK9OLVPF\\SQLEXPRESS;Database=AppStoreDB;Trusted_Connection=True;TrustServerCertificate=True;";

        // Register the AppDbContext to the dependency injection container, with SQL Server as the provider.
        services.AddDbContext<AppDbContext>(options =>
            options.UseSqlServer(connectionString));

        // Register support for controllers (which includes API endpoints).
        services.AddControllers();

        // Optional: Configure Cross-Origin Resource Sharing (CORS) to allow any origin, method, and header.
        services.AddCors(options =>
        {
            options.AddPolicy("AllowAll", builder =>
            {
                builder.AllowAnyOrigin()
                       .AllowAnyMethod()
                       .AllowAnyHeader();
            });
        });

        // Optional: Add other services like Authentication, Logging, etc.
    }

    // This method gets called by the runtime to configure the HTTP request pipeline.
    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
        // Enable the developer exception page only in development mode for easier debugging.
        if (env.IsDevelopment())
        {
            app.UseDeveloperExceptionPage();
        }

        // Use routing middleware to determine which endpoints are called by incoming requests.
        app.UseRouting();

        // Setup CORS policies allowing the previously defined policy.
        app.UseCors("AllowAll");

        // Map endpoint routing to controllers. This is necessary to activate the routing system.
        app.UseEndpoints(endpoints =>
        {
            endpoints.MapControllers();
        });

        // If you want to add any middlewares like authentication or static file serving, 
        // you can add them here (e.g., `app.UseAuthentication();` or `app.UseStaticFiles();`).
    }
}
