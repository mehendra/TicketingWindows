using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TicketManager.web.Models
{
    public class AddTicketToAgent
    {
        public string ticketNumber { get; set; }
        public string agentCode { get; set; }
    }
}