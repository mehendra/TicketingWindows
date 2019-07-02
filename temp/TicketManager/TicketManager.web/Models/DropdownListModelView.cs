using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TicketManager.web.Models
{
    public class DropdownListModelView
    {
        public IEnumerable<SelectListItem> Categories { get; set; }

        public IEnumerable<SelectListItem> Agents { get; set; }

        public IEnumerable<SelectListItem> TicketStatus { get; set; }

        public IEnumerable<SelectListItem> RecordsPerPage { get; set; }

        public IEnumerable<SelectListItem> Zones { get; set; }
    }
}