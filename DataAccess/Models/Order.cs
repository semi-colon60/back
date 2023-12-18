using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace dotnet.DataAccess.Models
{
	[Table("order")]
	public class Order
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		[Column("order_id")]
		public Int64 OrderId { get; set; }

		[ForeignKey(nameof(CommercialId))]
		[Column("commercial_id")]
		[Required(ErrorMessage = "commercial_id is required.")]
		public Int64 CommercialId { get; set; }

		[Column("order_date")]
		[MaxLength(11, ErrorMessage ="order date cannot exceed 11 characters.")]
		public string OrderDate { get; set; } = string.Empty;

		//approval can be an integer??
		[Column("approval")]
		[MaxLength(255, ErrorMessage ="approval cannot exceed 255 characters.")]
		public string Approval { get; set; } = string.Empty;

		// can be an integer??
		[Column("export_status")]
		[MaxLength(255, ErrorMessage ="export_status cannot exceed 255 characters.")]
		public string ExportStatus { get; set; } = string.Empty;
		
		[Column("address_id")]
		public Int64 AddressId { get; set; }	
	}
}