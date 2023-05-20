using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INVENTMAN.Entities
{
    public class Employee
    {
        public Guid EmployeeId { get; set; }
        public string Name { get; set; } = string.Empty;    
        public string Surname { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string ManagerEmail { get; set; } = string.Empty;
        public ICollection<Item>? Items { get; set; }
    }
}
