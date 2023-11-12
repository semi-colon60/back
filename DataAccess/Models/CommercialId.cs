using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace dotnet.DataAccess.Models
{
    [Table("commercial_ids")]
    public class CommercialId
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("commercial_id")]
        public int CommercialID { get; set; }

        [Column("name")]
        public string ?Name { get; set; }

        [Column("surname")]
        public string ?Surname { get; set; }

        [Column("commercial_title")]
        public string ?CommercialTitle { get; set; }

        [Column("phone")]
        public string ?Phone { get; set; }

        [Column("email")]
        public string ?Email { get; set; }

        [Column("address")]
        public string ?Address {get; set; }

        [Column("username")]
        public string ?Username { get; set; }

        [Column("password")]
        public string ?Password { get; set; }
    }
}