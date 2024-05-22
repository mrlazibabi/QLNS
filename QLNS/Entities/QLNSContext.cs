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
        #endregion
    }
}
