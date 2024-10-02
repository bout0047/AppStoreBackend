using AppStoreBackend.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AppStoreBackend.Services
{
    public interface IAppService
    {
        Task<IEnumerable<App>> GetAllAppsAsync();
        Task<App> GetAppByIdAsync(int id); // Ensure the return type is consistent
        Task CreateAppAsync(App app);
        Task UpdateAppAsync(int id, App app);
        Task<bool> DeleteAppAsync(int id); // Return type should match the implementation
    }
}
