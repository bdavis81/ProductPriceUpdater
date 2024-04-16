using System.ComponentModel.DataAnnotations;

namespace ProductPriceUpdater.Models
{
    public class ProductUpdateRequest
    {
        [Required]
        public int? ProductId { get; set; }

        [Required]
        [Range(0.01, double.MaxValue, ErrorMessage = "NewPrice must be greater than 0")]
        public decimal? NewPrice { get; set; }
    }
}
