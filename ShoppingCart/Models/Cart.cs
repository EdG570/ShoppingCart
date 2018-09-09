using System.ComponentModel.DataAnnotations;

namespace ShoppingCart.Models
{
    public class Cart
    {
        [Key]
        public int Id { get; set; }

        public ApplicationUser User { get; set; }
        public decimal TotalPrice { get; set; }

    }
}