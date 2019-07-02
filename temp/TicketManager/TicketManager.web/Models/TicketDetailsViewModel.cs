using Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TicketManager.web.Models
{
    public class TicketDetailsViewModel : DropdownListModelView
    {
        public TicketsIssued TicketDetails { get; set; }
    }
}