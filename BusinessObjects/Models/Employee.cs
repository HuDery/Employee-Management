using System;
using System.Collections.Generic;

namespace BusinessObjects.Models
{
    public partial class Employee
    {
        public int Id { get; set; }
        public string EmployeeCode { get; set; } = null!;
        public string EmployeeName { get; set; } = null!;
        public DateTime BirthDay { get; set; }
        public int Age { get; set; }
        public int RoleId { get; set; }

        public virtual Role Role { get; set; } = null!;
    }
}
