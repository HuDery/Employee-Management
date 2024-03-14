using BusinessObjects.Models;
using Microsoft.EntityFrameworkCore;
using Repositories.Heper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccsess.DAO
{
    public class EmployeeDAO
    {
        public static List<Employee> GetAllEmployee(int currentPage, int pageSize)
        {
            try
            {
                using (var context = new EmployeeManagementContext())
                {
                    return context.Employees.Include(r => r.Role).Skip((currentPage - 1) * pageSize).Take(pageSize).ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static Employee GetAllEmployeeById(int id)
        {
            try
            {
                using (var context = new EmployeeManagementContext())
                {
                    return context.Employees.Where(e => e.Id == id).Include(r => r.Role).FirstOrDefault();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static void CreateEmployee(Employee emp)
        {
            try
            {
                using (var context = new EmployeeManagementContext())
                {
                    context.Employees.Add(emp);
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static void UpdateEmployee(Employee emp)
        {
            var empToUpdate = new Employee
            {
                Id = emp.Id,
                EmployeeCode = emp.EmployeeCode,
                EmployeeName = emp.EmployeeName,
                BirthDay = emp.BirthDay,
                Age = DateTime.Now.Year - emp.BirthDay.Year,
                RoleId = emp.RoleId,
                Role = null
            };
            try
            {
                using (var context = new EmployeeManagementContext())
                {
                    context.Employees.Update(empToUpdate);
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static void DeleteEmployee(int id)
        {
            try
            {
                using (var context = new EmployeeManagementContext())
                {
                    var emp = context.Employees.Find(id);
                    context.Remove(emp);
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
