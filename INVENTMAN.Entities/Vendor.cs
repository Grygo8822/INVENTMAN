using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INVENTMAN.Entities
{
    public class Vendor
    {
        public Guid VendorId { get; set; }
        [Required]
        public string Name { get; set; } = string.Empty;
        public string Adress { get; set; } = string.Empty;
        [Required]
        public string EmailAdress { get; set; } = string.Empty;
    }
}
