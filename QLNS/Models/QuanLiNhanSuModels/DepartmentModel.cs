using QLNS.Entities;
using System.ComponentModel.DataAnnotations;

namespace QLNS.Models.QuanLiNhanSuModels
{
    public class DepartmentModel
    {
        [Key]
        public string? Id { get; set; } = null!;
        public string Name { get; set; } = null!;

        public virtual ICollection<User>? Users { get; set; }
    }
}
