using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class TicketSearchParams
    {
        public int MyProperty { get; set; }
        public string TicketNumber { get; set; }
        public string AgentCode { get; set; }
        public string TicketStatusCode { get; set; }
        public string Category { get; set; }
        public int? RcordCount { get; set; }
        public int? RecordsPerPage { get; set; }
        public int? PagingStartIndex { get; set; }
        public int TotalRecords { get; set; }
    }
}
