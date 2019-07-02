using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TicketManager.web.Models
{
    public class MyTicketViewModel
    {
        public bool IsPaid { get; set; }
        public string SoldTo { get; set; }
        public string  TicketNumber { get; set; }
        public string Zone { get; set; }

        public string Category { get; set; }        
    }
}