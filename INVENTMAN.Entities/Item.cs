using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INVENTMAN.Entities
{
    public class Item
    {
        public Guid ItemId { get; set; }
        [Required]
        public string Name { get; set; } = string.Empty;
        [Required]
        public string SerialNumber { get; set; } = string.Empty;

        public Guid VendorId { get; set; }
        public Vendor? Vendor { get; set; }

        public ItemState ItemState { get; set; }
        public string InvoiceId { get; set; }

        public Guid ManufacturerId { get; set; }
        public Manufacturer? Manufacturer { get; set; }

        public ItemType ItemType { get; set; }
        public string Description { get; set; } = string.Empty;
        public Guid? EmployeeId { get; set; }
        public Employee? Employee { get; set; }


    }
}
