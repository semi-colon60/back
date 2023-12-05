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
        public Int64 CommercialID { get; set; }

        [Column("name")]
        [Required(ErrorMessage = "name is required.")]
        [MaxLength(255, ErrorMessage ="name cannot exceed 255 characters.")]
        public string ?Name { get; set; } = string.Empty;

        [Column("surname")]
        [Required(ErrorMessage = "surname is required.")]
        [MaxLength(255, ErrorMessage ="surname cannot exceed 255 characters.")]
        public string ?Surname { get; set; } = string.Empty;

        [Column("commercial_title")]
        [Required(ErrorMessage = "commercial_title is required.")]
        [MaxLength(255, ErrorMessage ="commercial_title cannot exceed 255 characters.")]
        public string ?CommercialTitle { get; set; } = string.Empty;

        [Column("phone")]
        [Required(ErrorMessage = "phone is required.")]
        [Phone(ErrorMessage = "Invalid phone number.")]
        [MaxLength(15, ErrorMessage ="phone cannot exceed 15 characters.")]
        public string ?Phone { get; set; } = string.Empty;

        [Column("email")]
        [Required(ErrorMessage = "email is required.")]
        [EmailAddress(ErrorMessage = "Invalid email address.")]
        [MaxLength(255, ErrorMessage ="email cannot exceed 255 characters.")]
        public string ?Email { get; set; } = string.Empty;

        [Column("address")]
        [Required(ErrorMessage = "address is required.")]
        [MaxLength(600, ErrorMessage ="address cannot exceed 600 characters.")]
        public string ?Address {get; set; } = string.Empty;

        [Column("username")]
        [Required(ErrorMessage = "username is required.")]
        [MaxLength(255, ErrorMessage ="username cannot exceed 255 characters.")]
        public string ?Username { get; set; } = string.Empty;

        [Column("password")]
        [Required(ErrorMessage = "password is required.")]
        [MaxLength(255, ErrorMessage ="password cannot exceed 255 characters.")]
        public string ?Password { get; set; } = string.Empty;

        [Column("is_admin")]
        [Required(ErrorMessage = "is_admin is required.")]
        public Boolean IsAdmin { get; set; }
    }
}