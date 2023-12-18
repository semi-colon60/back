using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace dotnet.DataAccess.Models {
    [Table("sub_groups")]
    public class SubGroup
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("sub_group_id")]
        public Int64 SubGroupId { get; set; }

        [Column("name")]
        [Required(ErrorMessage = "name is required.")]
        [MaxLength(255, ErrorMessage ="name cannot exceed 255 characters.")]
        public string Name { get; set; } = string.Empty;

        [Column("description")]
        [MaxLength(255, ErrorMessage ="description cannot exceed 255 characters.")]
        public string Description { get; set; } = string.Empty;

        [ForeignKey(nameof(MainGroupId))]
        [Column("main_group_id")]
        [Required(ErrorMessage = "main_group_id is required.")]
        public Int64 MainGroupId { get; set; } = 0;
    }
}