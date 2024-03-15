using BusinessObjects.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Caching;
using System.Text;
using System.Text.RegularExpressions;
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
                    var result = context.Employees
                        .Select(e => new Employee
                        {
                            EmployeeCode = e.EmployeeCode,
                            EmployeeName = e.EmployeeName,
                            BirthDay = e.BirthDay,
                        })
                        .Skip((currentPage - 1) * pageSize)
                        .Take(pageSize)
                        .ToList();

                    return result;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static int CountEmployeeCode()
        {
            //[NV]_[YYYY]_[MM]_[DD]_[n]
            try
            {
                const string key = "lastNumber";
                ObjectCache cache = MemoryCache.Default;
                int maxNumber = (int)(cache[key] ?? 0);

                if (maxNumber == 0)
                {
                    using (var context = new EmployeeManagementContext())
                    {
                        var employeeCodes = context.Employees.Select(e => e.EmployeeCode).ToList();

                        foreach (var code in employeeCodes)
                        {
                            Match match = Regex.Match(code, @"\d+$");
                            if (match.Success)
                            {
                                int number = int.Parse(match.Value);

                                if (number > maxNumber)
                                {
                                    maxNumber = number;
                                }
                            }
                        }
                        cache.Set(key, maxNumber, DateTimeOffset.Now.AddDays(1));
                    }
                }
                else
                {
                    maxNumber++;
                    cache.Set(key, maxNumber, DateTimeOffset.Now.AddDays(1));
                }
                return maxNumber;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


        public static Employee GetEmployeeById(int id)
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
