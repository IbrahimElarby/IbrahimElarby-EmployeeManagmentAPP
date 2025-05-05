using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeMangement.DAL
{
    public class EmployeeRepository : IEmployeeRepository
    {
        protected AppContext context;

        public EmployeeRepository(AppContext Context)
        {
            context = Context;
        }
        public virtual async Task<(List<Employee>, int)> GetAll(EmployeeParameters parameters)
        {
            var query = context.Set<Employee>().AsNoTracking().AsQueryable();

            // Search
            if (!string.IsNullOrWhiteSpace(parameters.SearchTerm))
            {
                query = query.Where(e =>
                    e.FirstName.Contains(parameters.SearchTerm) ||
                    e.LastName.Contains(parameters.SearchTerm) ||
                    e.Email.Contains(parameters.SearchTerm));
            }

            // Filter
            if (!string.IsNullOrWhiteSpace(parameters.PositionFilter))
            {
                query = query.Where(e => e.Position == parameters.PositionFilter);
            }

            // Total count before pagination
            var totalCount = await query.CountAsync();

            // Pagination
            var employees = await query
                .Skip((parameters.PageNumber - 1) * parameters.PageSize)
                .Take(parameters.PageSize)
                .ToListAsync();

            return (employees, totalCount);
        }
        public virtual async Task<Employee?> GetByIdAsync(int id)
        {
            return await context.Set<Employee>().FindAsync(id);
        }

        public virtual void Add(Employee entity)
        {
            context.Set<Employee>().Add(entity);
        }
        public void Update(Employee entity)
        {

        }

        public virtual void Delete(Employee entity)
        {
            context.Set<Employee>().Remove(entity);
        }

        public async Task<List<string>> GetPositionsAsync()
        {
            return await context.Employees
                .Select(e => e.Position)
                .Distinct()
                .OrderBy(p => p)
                .ToListAsync();
        }
        public async Task<int> SaveChangesAsync()
        {
            return await context.SaveChangesAsync();
        }

    }
}
