using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace QLNS.Entities
{
    [Table("User")]
    public class User
    { 
        [Key]
        [Required]
        public string Id { get; set; } = null!;
        [Required]
        public string FullName { get; set; } = null!;
        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; } = null!;
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; } = null!;
        [Required]
        public string Phone { get; set; } = null!;
        [Required]
        [ForeignKey("Department")]
        public virtual Department? Departments { get; set; }
        public string? DepId { get; set; }
        [Required]
        [ForeignKey("Role")]
        public virtual Role? Roles { get; set; }
        public int? RoleId { get; set; }
    }
}
