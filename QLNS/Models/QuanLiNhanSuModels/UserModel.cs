using QLNS.Entities;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QLNS.Models.QuanLiNhanSuModels
{
    public class UserModel
    {
        public string? Id { get; set; } = null!;
        public string FullName { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string Password { get; set; } = null!;
        public string Phone { get; set; } = null!;
        public string DepId { get; set; }
        public string RoleId { get; set; } = null!;
    }
}
