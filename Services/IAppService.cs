using AppStoreBackend.Models;

namespace AppStoreBackend.Services
{
    public interface IAppService
    {
        Task<IEnumerable<App>> GetAllAppsAsync();
        Task<App> GetAppByIdAsync(int id);
        Task AddAppAsync(App app);
        // Other methods as needed
    }
}
