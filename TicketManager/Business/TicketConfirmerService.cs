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
        public ScannedStatus ConfirmArrival(ScannedTicket scannedTicket)
        {
            logger.logMessage("Request to mak ticket " + scannedTicket.TicketNumber, LogLevel.debug);
            var ticketScanned = db.TicketsIssueds.FirstOrDefault(a => a.TicketNumber == scannedTicket.TicketNumber);
            var ticketScannedOutcome = new ScannedStatus();
            if (ticketScanned == null)
            {
                return new ScannedStatus { StatusOfScan = TicketScannedStatus.TicketDoesNotExist};
            }
            else
            {
                if (ticketScanned.ArrivedAt != null)
                {
                    ticketScannedOutcome.StatusOfScan = TicketScannedStatus.TicketAlreadyScanned;
                    ticketScannedOutcome.TicketScannedMessage = string.Format("Ticket was scanned at {0} using machine {1}", ticketScanned.ArrivedAt, ticketScanned.ArrivalConfirmedBy);

                }
                else
                {
                    ticketScanned.ArrivalConfirmedBy = scannedTicket.ScannedBy;
                    ticketScanned.ArrivedAt = DateTime.Now;
                    db.SaveChanges();
                    ticketScannedOutcome.StatusOfScan = TicketScannedStatus.Ok;
                    ticketScannedOutcome.ZoneBTicket = ticketScanned.Zone == Constants.ZonedCategories.ZoneB;
                    ticketScannedOutcome.TicketNotPaid = ticketScanned.TicketStatusCode != Constants.TicketStatus.Paid && ticketScanned.TicketStatusCode != Constants.TicketStatus.PaidNoCharge;                    
                }
            }
            return ticketScannedOutcome;

        }
    }
}
