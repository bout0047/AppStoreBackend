using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using AppStoreBackend.Data;
using AppStoreBackend.Models;

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
            var apps = _context.Apps.Include(a => a.Category).ToList();
            return Ok(apps);
        }
    }
}
