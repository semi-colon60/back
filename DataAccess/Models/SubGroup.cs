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
        public int SubGroupId { get; set; }

        [Column("name")]
        public string ?Name { get; set; }

        [Column("description")]
        public string ?Description { get; set; }

        [ForeignKey(nameof(MainGroupId))]
        [Column("main_group_id")]
        public int MainGroupId { get; set; }
    }
}