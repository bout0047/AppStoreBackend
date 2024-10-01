using Microsoft.AspNetCore.Mvc;
using AppStoreBackend.Data;
using AppStoreBackend.DTOs;
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
            var apps = _context.Apps.Select(app => new AppDTO
            {
                Id = app.Id,
                Name = app.Name,
                Description = app.Description,
                CategoryId = app.CategoryId,
                CategoryName = app.Category.CategoryName
            }).ToList();

            return Ok(apps);
        }
    }
}
