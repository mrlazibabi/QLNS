using QLNS.Entities;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QLNS.Models.QuanLiNhanSuModels
{
    public class UserModel
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
        public string? DepId { get; set; }
        public virtual Department? Departments { get; set; }
        [Required]
        [ForeignKey("Role")]
        public int? RoleId { get; set; }
        public virtual Role? Roles { get; set; } 
    }
}
