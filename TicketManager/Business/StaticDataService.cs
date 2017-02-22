using Models.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class StaticDataService
    {
        private TicketingEntities db = new TicketingEntities();
        ILogger logger = new Logger();

        public List<Agent> GetAgents()
        {
            return db.Agents.ToList();
        }

        public List<TicketStatu> GetTicketStatuses()
        {
            return db.TicketStatus.ToList();
        }

        public Dictionary<string, string> GetRecordsPerPage()
        {
            var recordCounts = new Dictionary<string, string>();
            recordCounts.Add("25", "25");
            recordCounts.Add("50", "50");
            recordCounts.Add("100", "100");
            recordCounts.Add("150", "150");
            recordCounts.Add("200", "200");
            return recordCounts;
        }

        public Dictionary<string, string> GetTicketCategory()
        {
            var allCats = new Dictionary<string, string>();
            allCats.Add("GA", "General Admission");
            allCats.Add("VIP", "VIP Admission");
            return allCats;
        }
    }
}
