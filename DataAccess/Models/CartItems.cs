using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace dotnet.DataAccess.Models
{
    [Table("cartitems")]
    public class CartItems
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("cart_item_id")]
        public Int64 CartItemId { get; set; }

        [Column("commercial_id")]
        public Int64 CommercialID { get; set; }

        [Column("material_id")]
        public Int64 MaterialID { get; set; }

        [Column("quantity")]
        public Int64 Quantity { get; set; }
    }
}