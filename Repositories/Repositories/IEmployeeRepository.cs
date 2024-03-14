using BusinessObjects.Models;
using Repositories.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.EmployeeRepositories
{
    public interface IEmployeeRepository
    {
        List<ListEmployeeDTO> GetEmployees(int page, int pageSize);
        Employee GetEmployeeById(int id);
        bool CreateEmployee(CreateEmployeeDTO emp);
        bool UpdateEmployee(UpdateEmployeeDTO emp);
        bool DeleteEmployee(int id);
    }
}
