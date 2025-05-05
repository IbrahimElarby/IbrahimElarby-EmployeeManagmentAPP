namespace EmployeeMangement.DAL
{
    public interface IEmployeeRepository
    {
        public  Task<(List<Employee>, int)> GetAll(EmployeeParameters parameters);
        Task<Employee?> GetByIdAsync(int id);

        void Add(Employee entity);

        void Update(Employee entity);

        void Delete(Employee entity);

        Task<List<string>> GetPositionsAsync();


        Task<int> SaveChangesAsync();
    }
}