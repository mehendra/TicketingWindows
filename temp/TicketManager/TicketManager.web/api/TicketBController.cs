using Business;
using Models.APIService;
using Models.Services;
using System;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace TicketManager.web.api
{
    public class TicketBController : ApiController
    {
        private ILogger logger = new Logger();
        private TicketManagerService ticketManagerService = new TicketManagerService();

        [System.Web.Http.Authorize]
        // POST: api/TicketB
        public HttpResponseMessage Post(ApiTicketsIssued value)
        {
            var ticketManagerResponse = ticketManagerService.UpdateTicket(new TicketsIssued
            {
                AgentCode = value.Agent,
                TicketNumber = value.TicketNumber,
                TicketStatusCode = value.TicketStatusCode,
                Category = value.Category,
                SoldTo = value.SoldTo,
                Zone = value.Zone,
                Notes = value.Notes,
                TicketId = value.TicketId,
                Paid = GetDateValue(value)
            });

            if (ticketManagerResponse.IsASuccess)
            {
                return Request.CreateResponse(HttpStatusCode.Created);
            }
            else
            {
                return Request.CreateResponse(HttpStatusCode.NotAcceptable, new HttpError(ticketManagerResponse.Errors.First()));
            }
        }

        private DateTime? GetDateValue(ApiTicketsIssued value)
        {
            if(string.IsNullOrEmpty(value.Paid))
            {
                return null;
            }
            else if(value.Paid.Equals("Paid"))
            {
                return DateTime.Now;
            }

                return DateTime.Parse(value.Paid);
            
        }
    }
}
