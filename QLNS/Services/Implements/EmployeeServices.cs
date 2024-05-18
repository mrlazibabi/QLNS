using AutoMapper;
using QLNS.Entities;
using QLNS.Models.QuanLiNhanSuModels;

namespace QLNS.Services.Implements
{
    public class EmployeeServices : IEmployeeServices
    {
        private QLNSContext _context;
        private IMapper _mapper;

        public EmployeeServices(QLNSContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;

        }

        public async Task<string> AddEmployee(EmployeeModel model)
        {

            try
            {
                var newEmp = _mapper.Map<Employee>(model);
                _context.Employees!.Add(newEmp);
                await _context.SaveChangesAsync();

                return newEmp.Id;
            }
            catch (Exception ex)
            {
                return ex.InnerException.Message;
            }
        }

        //public async Task<EmployeeModel> AddEmployee(EmployeeModel model)
        //{
        //    try
        //    {
        //        var newEmp = _mapper.Map<Employee>(model);
        //        newEmp.Department = _depRepo!.GetById(model.DepartmentId).Result;
        //        await _empRepo.AddEmpEntityAsync(newEmp);

        //        return _mapper!.Map<EmployeeModel>(model);
        //    }
        //    catch (Exception ex)
        //    {
        //        return null;
        //    }
        //}

        public async Task DeleteEmployee(string id)
        {
            var deleteEmp = _context.Employees!.SingleOrDefault(x => x.Id == id);
            if (deleteEmp != null)
            {
                _context.Employees!.Remove(deleteEmp);
                await _context.SaveChangesAsync();
            }
        }

        public Task<List<EmployeeModel>> GetAllEmployees()
        {
            throw new NotImplementedException();
        }

        public Task<EmployeeModel> GetEmpById(string id)
        {
            throw new NotImplementedException();
        }

        //public async Task<List<EmployeeModel>> GetAllEmployees()
        //{
        //    var emps = await _context.Employees!.ToListAsync();
        //    return _mapper.Map<List<EmployeeModel>>(emps);
        //}

        //public async Task<EmployeeModel> GetEmpById(string id)
        //{
        //    var emp = await _context.Employees!.FindAsync(id);
        //    return _mapper.Map<EmployeeModel>(emp);
        //}

        public async Task UpdateEmployee(string id, EmployeeModel model)
        {
            if (id == model.Id)
            {
                var updateEmp = _mapper.Map<Employee>(model);
                _context.Employees!.Update(updateEmp);
                await _context.SaveChangesAsync();
            }

        }
    }
}
