using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StorageLocker.Models
{
    public class Ticket
    {
        public int TicketId { get; set; } //PK
        public int LockerId { get; set; } //FK
        public bool StillCurrent { get; set; }
        public int Archived { get; set; }

    }
}
