using EmployeeMangement.DAL;
using static EmployeeMangement.BL.EmployeeManager;

namespace EmployeeMangement.BL
{
    public interface IEmployeeManager
    {
        public  Task<PagedResult<EmployeeDto>> GetAll(EmployeeParameters parameters);

        public Task<EmployeeDto> GetById(int id);

        public Task<GeneralResult> UpdateAsync(EmployeeDto item);

        public Task<GeneralResult> AddAsync(EmployeeCreate item);

        Task<List<string>> GetPositionsAsync();
        public Task<GeneralResult> DeleteAsync(int id);
    }
}