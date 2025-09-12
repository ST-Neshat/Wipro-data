using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RoleBasedProducts.Models
{
    public class Products
    {
        public int Id { get; set; }
        [Required, StringLength(100)]
        public string Name { get; set; } = string.Empty;
        //Persisted protected value
        [Required]
        public string Price; set; } = string.Empty;
        // Not mapped: plain decimal used in UI and converted to/from PriceStored
        [NotMapped]
        [Range(0, 1000000)]
        [Display(Name = "Price")]
        public decimal Price { get; set; }
    }
}
