using AutoMapper;
using BusinessObjects.Models;
using DataAccsess.DAO;
using Repositories.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.EmployeeRepositories
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly IMapper _mapper;

        public EmployeeRepository(IMapper mapper)
        {
            _mapper = mapper;
        }

        public List<Employee> GetEmployees(int page, int pageSize)
        {
            return EmployeeDAO.GetAllEmployee(page, pageSize);
        }

        public Employee GetEmployeeById(int id)
        {
            return EmployeeDAO.GetAllEmployeeById(id);
        }
        public bool CreateEmployee(CreateEmployeeDTO emp)
        {
            throw new NotImplementedException();
        }

        public bool UpdateEmployee(UpdateEmployeeDTO emp)
        {
            var check = EmployeeDAO.GetAllEmployeeById(emp.Id);
            if(check == null) return false;
            var employee = _mapper.Map(emp, check);
            EmployeeDAO.UpdateEmployee(employee);
            return true;
        }

        public bool DeleteEmployee(int id)
        {
            var check = EmployeeDAO.GetAllEmployeeById(id);
            if (check == null) return false;
            EmployeeDAO.DeleteEmployee(id);
            return true;

        }

    }
}
