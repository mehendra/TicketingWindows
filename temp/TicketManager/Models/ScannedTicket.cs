using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class ScannedTicket
    {
        public ScannedTicket(string ticketNumber, ISystemInformation sysInformation)
        {
            ScannedBy = sysInformation.GetMachineName();
            ScannedAt = sysInformation.GetCurrentDateTime();
            TicketNumber = ticketNumber;
        }
        public string ScannedBy { get; set; }
        public DateTime ScannedAt { get; set; }
        public string TicketNumber { get; set; }

    }
}
