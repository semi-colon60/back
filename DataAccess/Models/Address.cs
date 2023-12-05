using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace dotnet.DataAccess.Models
{
	[Table("addresses")]
	public class Address
	{
		[Key]
		[Column("adress_id")]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public Int64 AddressId { get; set; }

		[ForeignKey(nameof(CommercialId))]
		[Column("commercial_id")]
		[Required(ErrorMessage = "commercial_id is required.")]
		public Int64 CommercialId { get; set; }

		[Column("name")]
		[MaxLength(15, ErrorMessage = "name cannot exceed 15 characters.")]
		public string ?Name { get; set; } = string.Empty;

		[Column("city")]
		[MaxLength(15, ErrorMessage = "city cannot exceed 15 characters.")]
		public string ?City { get; set; } = string.Empty;

		[Column("district")]
		[MaxLength(15, ErrorMessage = "district cannot exceed 15 characters.")]
		public string ?District { get; set; } = string.Empty;

		[Column("hood")]
		[MaxLength(15, ErrorMessage = "hood cannot exceed 15 characters.")]
		public string ?Hood { get; set; } = string.Empty;

		[Column("zip_code")]
		public Int64 ZipCode { get; set; }

		[Column("description")]
		[MaxLength(30, ErrorMessage = "description cannot exceed 30 characters.")]
		public string ?Description { get; set; } = string.Empty;

		[Column("email")]
		[EmailAddress(ErrorMessage = "Invalid email address.")]
		[MaxLength(25, ErrorMessage = "email cannot exceed 25 characters.")]
		public string ?Email { get; set; } = string.Empty;

		[Column("phone")]
		[Phone(ErrorMessage = "Invalid phone number.")]
		[MaxLength(11, ErrorMessage = "phone cannot exceed 11 characters.")]
		public string ?Phone { get; set; } = string.Empty;
	}
}