using Microsoft.AspNetCore.Mvc;
using AppStoreBackend.Data;
using AppStoreBackend.DTOs; // Add this using directive
using AppStoreBackend.Models;

namespace AppStoreBackend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PurchasesController : ControllerBase
    {
        private readonly AppDbContext _context;

        public PurchasesController(AppDbContext context)
        {
            _context = context;
        }

        [HttpPost]
        public IActionResult CreatePurchase([FromBody] PurchaseDTO purchaseDTO)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var purchase = new Purchase
            {
                UserId = purchaseDTO.UserId,
                AppId = purchaseDTO.AppId,
                Price = purchaseDTO.Price,
                PurchaseDate = purchaseDTO.PurchaseDate
            };

            _context.Purchases.Add(purchase);
            _context.SaveChanges();

            return Ok(purchase);
        }
    }
}
