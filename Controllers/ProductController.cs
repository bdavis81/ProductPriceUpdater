using Microsoft.AspNetCore.Mvc;
using ProductPriceUpdater.Models;
using System.Collections.Generic;

namespace ProductPriceUpdater.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductController : ControllerBase
    {
        [HttpPost("update-prices")]
        public IActionResult UpdatePrices([FromBody] List<ProductUpdateRequest> updateRequests)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            // Assume this is where you integrate with your database or service layer to update prices.
            try
            {
                foreach (var request in updateRequests)
                {
                    // Update logic here
                    // Example: Update product price in the database
                    Console.WriteLine($"Updating Product {request.ProductId} to Price {request.NewPrice}");
                }

                return Ok("Prices updated successfully.");
            }
            catch (System.Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }
    }
}