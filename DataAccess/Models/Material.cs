using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace dotnet.DataAccess.Models
{
	// This enum is used to determine the unit of the material.
	public enum UnitType
	{
		Length,
		Mass,
		Volume,
		Count
	}

	[Table("materials")]
	public class Material
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		[Column("material_id")]
		public Int64 MaterialId { get; set; }

		[Column("material_code")]
		[MaxLength(255, ErrorMessage ="material_code cannot exceed 255 characters.")]
		[Required(ErrorMessage = "material_code is required.")]
		public string MaterialCode { get; set; } = string.Empty;

		[Column("description")]
		[MaxLength(255, ErrorMessage ="description cannot exceed 255 characters.")]
		public string Description { get; set; } = string.Empty;

		// The unit is stored in an integer value in the database.
		[Column("unit")]
		[Required(ErrorMessage = "unit is required.")]
		public UnitType	Unit {get; set; } = UnitType.Count;

		[Column("unit_price")]
		[MaxLength(255, ErrorMessage ="unit_price cannot exceed 255 characters.")]
		[Required(ErrorMessage = "unit_price is required.")]
		public string	UnitPrice { get; set; } = string.Empty;

		[Column("mass")]
		[MaxLength(255, ErrorMessage ="mass cannot exceed 255 characters.")]
		public string	Mass { get; set; } = string.Empty;

		[Column("volume")]
		[MaxLength(255, ErrorMessage ="volume cannot exceed 255 characters.")]
		public string	Volume { get; set; } = string.Empty;

		[Column("count")]
		public int	Count { get; set; } = 0;

		[Column("length")]
		[MaxLength(255, ErrorMessage ="length cannot exceed 255 characters.")]
		public string	Length { get; set; } = string.Empty;

		[ForeignKey(nameof(MainGroupId))]
		[Column("main_group_id")]
		[Required(ErrorMessage = "main_group_id is required.")]
		public Int64 MainGroupId { get; set; } = 0;

		[ForeignKey(nameof(SubGroupId))]
		[Column("sub_group_id")]
		[Required(ErrorMessage ="sub_group_id is required.")]
		public Int64 SubGroupId { get; set; } = 0;
	}
}