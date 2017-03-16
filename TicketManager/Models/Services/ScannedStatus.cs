using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Services
{
    public enum TicketScannedStatus
    {
        Ok,
        TicketDoesNotExist,
        TicketAlreadyScanned,
        TicketIsNotPaid
    }
    public class ScannedStatus
    {
        public TicketScannedStatus StatusOfScan { get; set; }

        public string TicketScannedMessage { get; set; }

        public bool TicketNotPaid { get; set; }

        public string Zone { get; set; }

        public int TicketId { get; set; }
    }
}
