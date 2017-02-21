using Business;
using Models.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Results;
using System.Web.Mvc;
using TicketManager.web.Models;

namespace TicketManager.web.Controllers
{
    public class TicketAController : ApiController
    {
        private TicketingEntities db = new TicketingEntities();
        private ILogger logger = new Logger();
        private TicketManagerService ticketManagerService = new TicketManagerService();

        // GET: api/TicketA
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/TicketA/5
        public JsonResult Get(string ticketNumber)
        {
            var ticketManagerResponse = ticketManagerService.GetTicket(ticketNumber);
            var foundData = new TicketsIssued() { Category = ticketManagerResponse.ItemResuested.Category, TicketNumber = ticketManagerResponse.ItemResuested.TicketNumber };
            return new JsonResult { Data = foundData };
        }

        // POST: api/TicketA
        public HttpResponseMessage Post(AddTicketToAgent value)
        {
            var ticketManagerResponse = ticketManagerService.AddOrIssue(new TicketsIssued { AgentCode = value.agentCode, TicketNumber = value.ticketNumber });
            if (ticketManagerResponse.IsASuccess)
            {
                return Request.CreateResponse(HttpStatusCode.Created);
            }
            else
            {
                return Request.CreateResponse(HttpStatusCode.NotAcceptable, new HttpError(ticketManagerResponse.Errors.First()));
            }
        }

        // PUT: api/TicketA/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/TicketA/5
        public void Delete(int id)
        {
        }
    }
}
