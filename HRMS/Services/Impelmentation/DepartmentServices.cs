using HRMS.Interfaces.Services;
using HRMS.Models;

namespace HRMS.Services.Impelmentation
{
    public class DepartmentServices : IDepartmentServices
    {
        public Task<Department> AddAsync(Department department)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Department>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Department?> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateAsync(Department department)
        {
            throw new NotImplementedException();
        }
    }
}
