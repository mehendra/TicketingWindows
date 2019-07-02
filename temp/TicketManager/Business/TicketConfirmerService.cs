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
        public ScannedStatus ConfirmArrival(ScannedTicket scannedTicket, bool forceUpdate = false)
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
                ticketScannedOutcome.TableNumber = ticketScanned.TableNumber;
                ticketScannedOutcome.TicketNumber = ticketScanned.TicketNumber;

                ticketScannedOutcome.TicketId = ticketScanned.TicketId;
                if (ticketScanned.ArrivedAt != null)
                {
                    ticketScannedOutcome.StatusOfScan = TicketScannedStatus.TicketAlreadyScanned;
                    ticketScannedOutcome.TicketScannedMessage = string.Format("Ticket was scanned at {0} and was sold by {1} to {2}", ticketScanned.ArrivedAt, ticketScanned.Agent.AgentName, ticketScanned.SoldTo);

                }
                else
                {
                    ticketScanned.ArrivalConfirmedBy = scannedTicket.ScannedBy;
                    ticketScanned.ArrivedAt = DateTime.Now;
                    ticketScannedOutcome.StatusOfScan = TicketScannedStatus.Ok;
                    ticketScannedOutcome.Zone = ticketScanned.Zone;
                    ticketScannedOutcome.TicketNotPaid = ticketScanned.TicketStatusCode != Constants.TicketStatus.Paid && ticketScanned.TicketStatusCode != Constants.TicketStatus.PaidNoCharge;
                    if (ticketScannedOutcome.TicketNotPaid)
                    {
                        if (forceUpdate)
                        {
                            db.SaveChanges();
                        }
                    }
                    else
                    {
                        db.SaveChanges();
                    }                    
                }
            }
            return ticketScannedOutcome;

        }
    }
}
