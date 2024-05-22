using QLNS.Models.QuanLiNhanSuModels;

namespace QLNS.Services
{
    public interface IDepartmentServices
    {
        public Task<int> AddDepartment(DepartmentModel model);
        public Task<List<DepartmentModel>> GetAllDepartments();
        public Task<DepartmentModel> GetDepById(int id);
        public Task UpdateDepartment(int id, DepartmentModel model);
        public Task DeleteDepartment(int id);
    }
}
