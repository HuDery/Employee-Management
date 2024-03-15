using AutoMapper;
using BusinessObjects.Models;
using DataAccsess.DAO;
using Repositories.DTOs;
using Repositories.Heper;
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

        public List<ListEmployeeDTO> GetEmployees(int page, int pageSize)
        {
            List<Employee> employees = EmployeeDAO.GetAllEmployee(page, pageSize);
            List<ListEmployeeDTO> listEmployees = _mapper.Map<List<ListEmployeeDTO>>(employees);
            foreach(var employee in listEmployees)
            {
                employee.Age = AgeCalculator.CalculatorAge(employee.BirthDay);
            }
            return listEmployees;
        }

        public Employee GetEmployeeById(int id)
        {
            return EmployeeDAO.GetEmployeeById(id);
        }
        public bool CreateEmployee(CreateEmployeeDTO emp)
        {
            if(emp == null) return false;
            int count = EmployeeDAO.CountEmployeeCode();
            var employee = _mapper.Map<Employee>(emp);
            employee.EmployeeCode = GenerateCode.GenerateEmployeeCode(count);
            EmployeeDAO.CreateEmployee(employee);
            return true;
        }

        public bool UpdateEmployee(UpdateEmployeeDTO emp)
        {
            var check = EmployeeDAO.GetEmployeeById(emp.Id);
            if(check == null) return false;
            var employee = _mapper.Map(emp, check);
            EmployeeDAO.UpdateEmployee(employee);
            return true;
        }

        public bool DeleteEmployee(int id)
        {
            var check = EmployeeDAO.GetEmployeeById(id);
            if (check == null) return false;
            EmployeeDAO.DeleteEmployee(id);
            return true;

        }

    }
}
