using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StorageLocker.Models
{
    public class Lockers
    {
        public enum LockerSize {Small, Medium, Large};
        public int LockerId { get; set; }
        public bool IsRented { get; set; }
        public LockerSize Size { get; set; }
        public Ticket TicketId { get; set; }



    }
}
