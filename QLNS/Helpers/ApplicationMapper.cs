using AutoMapper;
using QLNS.Entities;
using QLNS.Models.QuanLiNhanSuModels;

namespace QLNS.Helpers
{
    public class ApplicationMapper : Profile
    {
        public ApplicationMapper()
        {
            CreateMap<Employee, EmployeeModel>().ReverseMap();
            CreateMap<Department, DepartmentModel>().ReverseMap();
        }
    }
}
