using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace dotnet.DataAccess.Models
{
    [Table("main_groups")]
    public class MainGroup
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("main_group_id")]
        public Int64 MainGroupId { get; set; }

        [Column("name")]
        [Required(ErrorMessage = "name is required.")]
        [MaxLength(255, ErrorMessage ="name cannot exceed 255 characters.")]
        public string Name { get; set; } = string.Empty;

        [Column("description")]
        [MaxLength(255, ErrorMessage ="description cannot exceed 255 characters.")]
        public string Description { get; set; } = string.Empty;
    }
}