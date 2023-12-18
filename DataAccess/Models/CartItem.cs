using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace dotnet.DataAccess.Models
{
	[Table("cartitems")]
	public class CartItem
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		[Column("cart_item_id")]
		public Int64 CartItemId { get; set; }

		[ForeignKey(nameof(MaterialId))]
		[Required(ErrorMessage ="material_id is required.")]
		[Column("material_id")]
		public Int64 MaterialId { get; set; }

		[ForeignKey(nameof(CommercialId))]
		[Required(ErrorMessage ="commercial_id is required.")]
		[Column("commercial_id")]
		public Int64 CommercialId { get; set; }

		[Required(ErrorMessage ="amount is required.")]
		[Column("quantity")]
		public Int64 Quantity { get; set; }
	}
}