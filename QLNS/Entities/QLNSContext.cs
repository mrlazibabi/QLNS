using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using QLNS.Models.QuanLiNhanSuModels;

namespace QLNS.Entities
{
    public class QLNSContext : IdentityDbContext<ApplicationUsers>
    {
        public QLNSContext(DbContextOptions<QLNSContext> opt) : base(opt)
        {

        }

        #region DbSet
        public DbSet<Employee>? Employees { get; set; }
        public DbSet<Department>? Departments { get; set; }
        public DbSet<EmployeeModel>? EmployeeModel { get; set; }
        public DbSet<DepartmentModel>? DepartmentModel { get; set; }
        #endregion
    }
}
