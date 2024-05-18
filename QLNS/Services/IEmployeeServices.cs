﻿using QLNS.Models.QuanLiNhanSuModels;

namespace QLNS.Services
{
    public interface IEmployeeServices
    {
        //public Task<EmployeeModel> AddEmployee(EmployeeModel model);
        public Task<string> AddEmployee(EmployeeModel model);
        public Task<List<EmployeeModel>> GetAllEmployees();
        public Task<EmployeeModel> GetEmpById(string id);
        public Task UpdateEmployee(string id, EmployeeModel model);
        public Task DeleteEmployee(string id);
    }
}