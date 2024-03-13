using BusinessObjects.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Repositories.DTOs;
using Repositories.EmployeeRepositories;

namespace EmployeeManagementAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        private readonly IEmployeeRepository _repo;

        public EmployeesController(IEmployeeRepository repo)
        {
            _repo = repo;
        }

        [HttpGet]
        public IActionResult GetAllEmployee(int page, int pageSize)
        {
            var listEmp = _repo.GetEmployees(page, pageSize);
            return Ok(listEmp);
        }

        [HttpGet("{id}")]
        public IActionResult GetEmployeeById(int id)
        {
            var emp = _repo.GetEmployeeById(id);
            if(emp == null) return NotFound("Employee does not exist!");
            return Ok(emp);
        }

        [HttpPut]
        public IActionResult UpdateEmployee(UpdateEmployeeDTO employee)
        {
            var isSuccess = _repo.UpdateEmployee(employee);
            return isSuccess ? Ok("Update successfull!") : BadRequest("Employee does not exist!");
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteEmployee(int id) {
            var isSuccess = _repo.DeleteEmployee(id);
            return isSuccess ? Ok("Delete successfull!") : NotFound("Employee does not exist!");
        }
    }
}
