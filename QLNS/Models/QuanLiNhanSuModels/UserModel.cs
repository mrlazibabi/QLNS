using QLNS.Entities;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QLNS.Models.QuanLiNhanSuModels
{
    public class UserModel
    {
        public string Id { get; set; } 
        public string FullName { get; set; } 
        public string Email { get; set; } 
        public string Password { get; set; } 
        public string Phone { get; set; } 
        public int DepartmenId { get; set; }
        public int RoleId { get; set; } 
    }
}
