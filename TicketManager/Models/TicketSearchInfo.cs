using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace Models
{
    public class TicketSearchInfoViewModel<T>
    {
        public TicketSearchParams SearchParameters { get; set; }
        public SearchResultsWrapper<T> SearchResults { get; set; }


        public IEnumerable<SelectListItem> Categories { get; set; }

        public IEnumerable<SelectListItem> Agents { get; set; }

        public IEnumerable<SelectListItem> TicketStatus { get; set; }

        public IEnumerable<SelectListItem> RecordsPerPage { get; set; }

        public IEnumerable<SelectListItem> Zones { get; set; }

    }
}
