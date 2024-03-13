using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace BusinessObjects.Models
{
    public partial class Role
    {
        public Role()
        {
            Employees = new HashSet<Employee>();
        }

        public int Id { get; set; }
        public string RoleName { get; set; } = null!;
        [JsonIgnore]
        public virtual ICollection<Employee> Employees { get; set; }
    }
}
