using QLNS.Entities;
using System.ComponentModel.DataAnnotations;

namespace QLNS.Models.QuanLiNhanSuModels
{
    public class RoleModel
    {
        public int? Id { get; set; }
        public string Name { get; set; } = null!;

    }
}
