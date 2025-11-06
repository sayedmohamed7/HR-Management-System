using HRMS.Interfaces.Services;
using HRMS.Models;

namespace HRMS.Services.Impelmentation
{
    public class JobTitleServices : IJobTitleServices
    {
        public Task<JobTitle> AddAsync(JobTitle jobTitle)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<JobTitle>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<JobTitle?> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateAsync(JobTitle jobTitle)
        {
            throw new NotImplementedException();
        }
    }
}
