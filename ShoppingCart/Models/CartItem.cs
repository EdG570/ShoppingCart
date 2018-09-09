using System.ComponentModel.DataAnnotations;

namespace ShoppingCart.Models
{
    public class CartItem
    {
        [Key]
        public int Id { get; set; }

        public int ProductId { get; set; }
     
        public int CartId { get; set; }
        public int Quantity { get; set; }
        public decimal ItemPrice { get; set; }

    }
}