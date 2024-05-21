﻿using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace QLNS.Entities
{
    [Table("Department")]
    public class Department
    {
        [Key]

        public string? Id { get; set; } = null!;
        public string Name { get; set; } = null!;

        public virtual ICollection<User>? Users { get; set; }
    }
}
