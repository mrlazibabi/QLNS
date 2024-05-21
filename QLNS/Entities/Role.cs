using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QLNS.Entities
{
    [Table("Role")]
    public class Role
    {
        [Key]
        public int? Id { get; set; }
        public string Name { get; set; } = null!;

        public virtual ICollection<User>? Users { get; set; }
    }
}
