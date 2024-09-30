using Microsoft.AspNetCore.Mvc;
using AppStoreBackend.DTOs; // Ensure this is added
using AppStoreBackend.Data;
using AppStoreBackend.Models;

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
        public ActionResult<List<PurchaseDTO>> GetPurchases()
        {
            var purchases = _context.Purchases.Select(p => new PurchaseDTO
            {
                Id = p.Id,
                UserId = p.UserId,
                AppId = p.AppId,
                PurchaseDate = p.PurchaseDate,
                Price = p.Price
            }).ToList();

            return Ok(purchases);
        }
    }
}
