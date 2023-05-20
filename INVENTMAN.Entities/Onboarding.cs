using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace INVENTMAN.Entities
{
    public class Onboarding
    {
        public int OnboardingId { get; set; }
        public Guid EmployeeId { get; set; }
        public Employee? Employee { get; set; }
        public DateTime StartDate { get; set; }
        public string CreatedBy { get; set; } = string.Empty;
    }
}
