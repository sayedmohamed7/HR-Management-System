using HRMS.Interfaces.Services;
using HRMS.Models;

namespace HRMS.Services.Impelmentation
{
    public class EmployeeServices : IEmployeeServices
    {
        private readonly IEmployeeRepository _empRepo;

        public EmployeeServices(IEmployeeRepository empRepo)
        {
            _empRepo = empRepo;
        }


        public async Task<IEnumerable<Employee>> GetAllAsync()
        {
            var includes = new string[] { "Department", "JobTitle" };            
            return await _empRepo.FindAllAsync(criteria: null, includes: includes);
        }

        public async Task<Employee?> GetByIdAsync(int id)
        {
            var includes = new string[] { "Department", "JobTitle" };
            return await _empRepo.FindAsync(e => e.EmployeeID == id, includes);
        }

        public async Task<Employee> AddAsync(Employee employee)
        {
            return await _empRepo.AddAsync(employee);
        }

        public async Task<bool> UpdateAsync(Employee employee)
        {
            try
            {
                await _empRepo.UpdateAsync(employee);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var employee = await _empRepo.GetByIdAsync(id);
            if (employee == null)
            {
                return false; 
            }

            try
            {
                await _empRepo.DeleteAsync(employee);
                return true;
            }
            catch
            {
                return false;
            }
        }


        public async Task<IEnumerable<Employee>> GetByDepartmentIdAsync(int departmentId)
        {
            return await _empRepo.GetEmployeesByDepartmentAsync(departmentId);
        }

        public async Task<decimal> GetTotalSalaryAsync(int departmentId)
        {
          
            var employees = await _empRepo.FindAllAsync(
                criteria: e => e.DepartmentID == departmentId,
                includes: null 
            );

            if (employees.Any())
            {
                return employees.Sum(e => e.BasicSalary);
            }

            return 0;
        }
    }
}
