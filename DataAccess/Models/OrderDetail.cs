using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace dotnet.DataAccess.Models
{
	[Table("order_detail")]
	public class OrderDetail
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		[Column("order_detail_id")]
		public Int64 OrderDetailId { get; set; }

		[ForeignKey(nameof(OrderId))]
		[Required(ErrorMessage ="order_id is required.")]
		[Column("order_id")]
		public Int64 OrderId { get; set; }

		[ForeignKey(nameof(MaterialId))]
		[Required(ErrorMessage ="material_id is required.")]
		[Column("material_id")]
		public Int64 MaterialId { get; set; }

		[Required(ErrorMessage ="quantity is required.")]
		[Column("quantity")]
		public int Quantity { get; set; }

		[Column("price")]
		[MaxLength(255, ErrorMessage = "price cannot exceed 255 characters.")]
		public string Price { get; set; } = string.Empty;
	}
}