using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace TicketManager.web.Models
{
    public class TicketSearchInfoViewModel<T>: DropdownListModelView
    {
        public TicketSearchParams SearchParameters { get; set; }
        public SearchResultsWrapper<T> SearchResults { get; set; }

    }
}
