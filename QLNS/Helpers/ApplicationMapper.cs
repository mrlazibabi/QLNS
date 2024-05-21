using AutoMapper;
using QLNS.Entities;
using QLNS.Models.QuanLiNhanSuModels;

namespace QLNS.Helpers
{
    public class ApplicationMapper : Profile
    {
        public ApplicationMapper()
        {
            CreateMap<User, UserModel>().ReverseMap();
            CreateMap<Role, RoleModel>().ReverseMap();
            CreateMap<Department, DepartmentModel>().ReverseMap();
        }
    }
}
