using Microsoft.AspNetCore.Mvc;
using AppStoreBackend.Data;
using AppStoreBackend.Models;
using System.Collections.Generic;
using System.Linq;

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
            // Correcting the type reference here
            List<App> apps = _context.Apps.ToList(); // Change ApplicationData to App if incorrect
            return Ok(apps);
        }
    }
}
