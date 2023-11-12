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
		public int	MaterialId { get; set; }

		[Column("name")]
		public string ?Name { get; set; }

		[Column("description")]
		public string ?Description { get; set; }

		// The unit is stored in an integer value in the database.
		[Column("unit")]
		public UnitType	?Unit {get; set; }

		[Column("unit_price")]
		public string	?UnitPrice { get; set; }

		[Column("mass")]
		public string	?Mass { get; set; }

		[Column("volume")]
		public string	?Volume { get; set; }

		[Column("count")]
		public int	?Count { get; set; }

		[Column("length")]
		public string	?Length { get; set; }

		[ForeignKey(nameof(MainGroupId))]
		[Column("main_group_id")]
		public int MainGroupId { get; set; }

		[ForeignKey(nameof(SubGroupId))]
		[Column("sub_group_id")]
		public int SubGroupId { get; set; }
	}
}