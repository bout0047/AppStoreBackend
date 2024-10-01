using Microsoft.AspNetCore.Mvc;
using PurchaseModel = AppStoreBackend.Models.Purchase; // Use alias to disambiguate
using AppStoreBackend.Data;

namespace AppStoreBackend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PurchasesController : ControllerBase
    {
        private readonly AppDbContext _context;

        public PurchasesController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetPurchases()
        {
            List<PurchaseModel> purchases = _context.Purchases.ToList(); // Use alias 'PurchaseModel' to disambiguate
            return Ok(purchases);
        }
    }
}
