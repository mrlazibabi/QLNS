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
        public DbSet<User>? Users { get; set; }
        public DbSet<Department>? Departments { get; set; }
        public DbSet<Role>? Roles { get; set; }
        public DbSet<UserModel>? UserModel { get; set; }
        public DbSet<DepartmentModel>? DepartmentModel { get; set; }
        public DbSet<RoleModel>? RoleModel { get; set; }
        #endregion
    }
}
