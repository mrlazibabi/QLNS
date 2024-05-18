using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace QLNS.Entities
{
    [Table("Employee")]
    public class Employee
    {
        [Key]
        public string Id { get; set; }
        public string FullName { get; set; }
        public string Sex { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public Department? Department { get; set; }
    }
}
