using EmployeeMangement.DAL;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeMangement.BL
{
    public class EmployeeManager : IEmployeeManager
    {
        private readonly IEmployeeRepository repository;

        public EmployeeManager(IEmployeeRepository _repository)
        {
            repository = _repository;
        }
        public async Task<PagedResult<EmployeeDto>> GetAll(EmployeeParameters parameters)
        {
            var (employees, totalCount) = await repository.GetAll(parameters);

            return new PagedResult<EmployeeDto>
            {
                Items = employees.Select(e => new EmployeeDto
                {
                    Id = e.Id,
                    FirstName = e.FirstName,
                    LastName = e.LastName,
                    Email = e.Email,
                    Position = e.Position
                }).ToList(),
                TotalCount = totalCount,
                PageNumber = parameters.PageNumber,
                PageSize = parameters.PageSize
            };
        }

        // Add PagedResult class
       

        public async Task<EmployeeDto> GetById(int id)
        {
            var employee = await repository.GetByIdAsync(id);
            if (employee == null)
            {
                return null;
            }
            return new EmployeeDto
            {
                Id = employee.Id,
                FirstName = employee.FirstName,
                LastName = employee.LastName,
                Email = employee.Email,
                Position = employee.Position,
            };
        }
        public async Task<GeneralResult> AddAsync(EmployeeCreate item)
        {
            try
            {
                if (item == null)
                {
                    return new GeneralResult
                    {
                        Success = false,
                        Errors = [new ResultError { Code = "NullInput", Message = "Employee cannot be null" }]
                    };
                }
                var employee = new Employee
                {
                   FirstName = item.FirstName,
                   LastName = item.LastName,
                   Email = item.Email,
                   Position = item.Position
                };
                repository.Add(employee);
                var saveResult = await repository.SaveChangesAsync();

                return saveResult > 0
                    ? new GeneralResult { Success = true }
                    : new GeneralResult { Success = false, Errors = [new ResultError { Code = "SaveFailed", Message = "No changes persisted" }] };
            }
            catch (DbUpdateException ex)
            {
                return new GeneralResult
                {
                    Success = false,
                    Errors = [new ResultError
            {
                Code = "DatabaseError",
                Message = $"Failed to save Employee: {ex.InnerException?.Message ?? ex.Message}"
            }]
                };
            }
            catch (Exception ex)
            {
                return new GeneralResult
                {
                    Success = false,
                    Errors = [new ResultError
            {
                Code = "AddFailed",
                Message = $"Unexpected error: {ex.Message}"
            }]
                };
            }
        }


        public async Task<GeneralResult> DeleteAsync(int id)
        {
            try
            {
                var employee = await repository.GetByIdAsync(id);
                if (employee == null)
                {
                    return new GeneralResult
                    {
                        Success = false,
                        Errors = [new ResultError { Code = "EmployeeNotFound", Message = "Employee not found" }]
                    };
                }
                repository.Delete(employee);
                
                var saveResult = await repository.SaveChangesAsync();

                return saveResult > 0
                    ? new GeneralResult { Success = true }
                    : new GeneralResult { Success = false, Errors = [new ResultError { Code = "SaveFailed", Message = "No changes persisted" }] };
            }
            catch (DbUpdateException ex)
            {
                return new GeneralResult
                {
                    Success = false,
                    Errors = [new ResultError
        {
            Code = "DatabaseError",
            Message = $"Failed to save Employee: {ex.InnerException?.Message ?? ex.Message}"
        }]
                };
            }
            catch (Exception ex)
            {
                return new GeneralResult
                {
                    Success = false,
                    Errors = [new ResultError
        {
            Code = "UnexpectedError",
            Message = $"Unexpected error: {ex.Message}"
        }]
                };
            }
        }
        public async Task<List<string>> GetPositionsAsync()
        {
            return await repository.GetPositionsAsync();
        }

        public async Task<GeneralResult> UpdateAsync(EmployeeDto item)
        {
            try
            {
                if (item == null)
                {
                    return new GeneralResult
                    {
                        Success = false,
                        Errors = [new ResultError { Code = "NullInput", Message = "Employee cannot be null" }]
                    };

                }
                var employee = await repository.GetByIdAsync(item.Id);
                if (employee == null)
                {
                    return new GeneralResult
                    {
                        Success = false,
                        Errors = [new ResultError { Code = "EmployeeNotFound", Message = "Employee not found" }]
                    };
                }
                employee.FirstName = item.FirstName;
                employee.LastName = item.LastName;
                employee.Email = item.Email;
                employee.Position = item.Position;
                var saveResult = await repository.SaveChangesAsync();

                return saveResult > 0
                    ? new GeneralResult { Success = true }
                    : new GeneralResult { Success = false, Errors = [new ResultError { Code = "SaveFailed", Message = "No changes persisted" }] };
            }
            catch (DbUpdateException ex)
            {
                return new GeneralResult
                {
                    Success = false,
                    Errors = [new ResultError
        {
            Code = "DatabaseError",
            Message = $"Failed to Employee: {ex.InnerException?.Message ?? ex.Message}"
        }]
                };
            }
            catch (Exception ex)
            {
                return new GeneralResult
                {
                    Success = false,
                    Errors = [new ResultError
        {
            Code = "UnexpectedError",
            Message = $"Unexpected error: {ex.Message}"
        }]
                };
            }
        }
    }
}
