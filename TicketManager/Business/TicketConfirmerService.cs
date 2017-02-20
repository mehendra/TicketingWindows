using Models;
using Models.Services;
using System;
using System.Linq;

namespace Business
{
    public class TicketConfirmerService : ITicketConfirmer
    {
        private TicketingEntities db = new TicketingEntities();
        ILogger logger;
        public TicketConfirmerService(ILogger logger)
        {
            this.logger = logger;
        }
        public bool ConfirmArrival(ScannedTicket scannedTicket)
        {
            logger.logMessage("Request to mak ticket " + scannedTicket.TicketNumber, LogLevel.debug);
            var ticketScanned = db.TicketsIssueds.FirstOrDefault(a => a.TicketNumber == scannedTicket.TicketNumber);
            if (ticketScanned == null)
            {
                return false;
            }
            else {
                if (ticketScanned.ArrivedAt != null)
                {
                    return false;
                }
                else
                {
                    ticketScanned.ArrivalConfirmedBy = scannedTicket.ScannedBy;
                    ticketScanned.ArrivedAt = DateTime.Now;
                    db.SaveChanges();
                }
            }

            return true;
        }

    }
}
