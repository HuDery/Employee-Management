using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.DTOs
{
    public class CreateEmployeeDTO
    {
        [Required]
        public string EmployeeName { get; set; } = null!;
        [Required]
        public DateTime BirthDay { get; set; }
        [Required]
        public int RoleId { get; set; }
    }
}
