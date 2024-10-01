using Microsoft.AspNetCore.Mvc;
using AppStoreBackend.Data; // To use AppDbContext and ApplicationData

namespace AppStoreBackend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AppsController : ControllerBase
    {
        private readonly AppDbContext _context;

        public AppsController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetApps()
        {
            // Updated type to 'ApplicationData' after renaming
            List<ApplicationData> apps = _context.Apps.ToList();
            return Ok(apps);
        }
    }
}
