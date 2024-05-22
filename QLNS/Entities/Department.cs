using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace QLNS.Entities
{
    [Table("Department")]
    public class Department
    {
        [Key]

        public int DepartmentId { get; set; } 
        public string Name { get; set; } 

        public virtual ICollection<User>? Users { get; set; }
    }
}
