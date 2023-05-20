using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace INVENTMAN.Entities
{
    public class Event
    {
        public Guid EventId { get; set; }

        public Guid ItemId { get; set; }

        public Item? Item { get; set; }

        public Guid TransferedFromId { get; set; }

        public Employee? TransferedFrom { get; set; }

        public Guid TransferedToId { get; set; }

        public Employee? TransferedToFrom { get; set; }

        public DateTime Timestamp { get; set; }

        public string Username { get; set; } = string.Empty;

        public EventType EventType { get; set; }
    }
}
