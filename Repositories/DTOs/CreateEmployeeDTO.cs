using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.DTOs
{
    public class CreateEmployeeDTO
    {
        public string EmployeeName { get; set; } = null!;
        public DateTime BirthDay { get; set; }
        public int RoleId { get; set; }
    }
}
