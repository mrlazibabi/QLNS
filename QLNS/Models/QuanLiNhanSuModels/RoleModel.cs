using QLNS.Entities;
using System.ComponentModel.DataAnnotations;

namespace QLNS.Models.QuanLiNhanSuModels
{
    public class RoleModel
    {
        [Key]
        public int? Id { get; set; }
        public string Name { get; set; } = null!;

        public virtual ICollection<User>? Users { get; set; }
    }
}
