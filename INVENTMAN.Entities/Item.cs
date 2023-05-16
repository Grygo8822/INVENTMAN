using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INVENTMAN.Entities
{
    public class Item
    {
        public Guid ItemId { get; set; }
        public string Name { get; set; } = string.Empty;
        public string SerialNumber { get; set; } = string.Empty;
        public string Vendor { get; set; } = string.Empty;
        public string Manufacturer { get; set; } = string.Empty;

    }
}
