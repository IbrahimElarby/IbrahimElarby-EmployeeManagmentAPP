using EmployeeMangement.BL;
using EmployeeMangement.DAL;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeMangement.API.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeManager employeeManager;

        public EmployeeController(IEmployeeManager _employeeManager) 
        {
           employeeManager = _employeeManager;
        }

        [HttpGet]
        public async Task<ActionResult<PagedResult<EmployeeDto>>> GetAll(
    [FromQuery] int pageNumber = 1,
    [FromQuery] int pageSize = 10,
    [FromQuery] string searchTerm = "",
    [FromQuery] string positionFilter = "")
        {
            var parameters = new EmployeeParameters
            {
                PageNumber = pageNumber,
                PageSize = pageSize,
                SearchTerm = searchTerm,
                PositionFilter = positionFilter
            };

            var result = await employeeManager.GetAll(parameters);
            return Ok(result);
        }

        [HttpGet("positions")]
        public async Task<ActionResult<List<string>>> GetPositions()
        {
            try
            {
                var positions = await employeeManager.GetPositionsAsync();
                return Ok(positions);
            }
            catch (Exception ex)
            {
                return StatusCode(500, new
                {
                    Success = false,
                    Errors = new[] { new { Code = "ServerError", Message = ex.Message } }
                });
            }
        }
        [HttpGet("{id}")]
        
        public async Task<Results<Ok<EmployeeDto>, NotFound>> GetByIdWithIngridents(int id)
        {
            var employeedto = await employeeManager.GetById(id);
            if (employeedto == null)
            {
                return TypedResults.NotFound();
            }
            return TypedResults.Ok(employeedto);
        }


        [HttpPost]
        public async Task<Results<Ok<GeneralResult>, BadRequest<GeneralResult>>> Add(EmployeeCreate employee)
        {
            var result = await employeeManager.AddAsync(employee);
            if (result.Success)
            {
                return TypedResults.Ok(result);
            }
            return TypedResults.BadRequest(result);
        }

        [HttpPut]
        public async Task<Results<Ok<GeneralResult>, BadRequest<GeneralResult>>> Update(EmployeeDto employee)
        {
            var result = await employeeManager.UpdateAsync(employee);
            if (result.Success)
            {

                return TypedResults.Ok(result);
            }
            return TypedResults.BadRequest(result);
        }

        [HttpDelete]
        public async Task<Results<Ok<GeneralResult>, BadRequest<GeneralResult>>> Delete(int id)
        {
            var result = await employeeManager.DeleteAsync(id);
            if (result.Success)
            {
                return TypedResults.Ok(result);
            }
            return TypedResults.BadRequest(result);
        }

    }
}
