using HRMS.Interfaces.Services;
using HRMS.Models;

namespace HRMS.Services.Impelmentation
{
    public class EmployeeServices : IEmployeeServices
    {
        public Task<Employee> AddAsync(Employee employee)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Employee>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Employee>> GetByDepartmentIdAsync(int departmentId)
        {
            throw new NotImplementedException();
        }

        public Task<Employee?> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<decimal> GetTotalSalaryAsync(int departmentId)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateAsync(Employee employee)
        {
            throw new NotImplementedException();
        }
    }
}
