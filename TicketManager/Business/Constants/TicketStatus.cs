using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public struct TicketStatus
    {
        public const string Cancelled = "CANC";
        public const string Initial ="INIT";
        public const string Issued  = "ISSU";
        public const string SoldCollectMoney ="SCOL";
        public const string Paid = "SPAD";
        public const string PaidNoCharge = "SUNP";
    }
}
