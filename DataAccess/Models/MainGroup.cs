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
        public int MainGroupId { get; set; }

        [Column("name")]
        public string ?Name { get; set; }

        [Column("description")]
        public string ?Description { get; set; }
    }
}