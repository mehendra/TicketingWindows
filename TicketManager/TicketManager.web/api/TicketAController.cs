using Business;
using Models.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TicketManager.web.Models;

namespace TicketManager.web.Controllers
{
    public class TicketAController : ApiController
    {
        private TicketingEntities db = new TicketingEntities();
        private ILogger logger = new Logger();
        
        // GET: api/TicketA
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/TicketA/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/TicketA
        public HttpResponseMessage Post(AddTicketToAgent value)
        {
            db.TicketsIssueds.Add(new TicketsIssued { AgentCode = value.agentCode, TicketNumber = value.ticketNumber });
            db.SaveChanges();
            try
            {
                return Request.CreateResponse(HttpStatusCode.Created);
            }
            catch (Exception ex)
            {
                logger.logMessage(ex.Message, LogLevel.error);
                return Request.CreateResponse(HttpStatusCode.Conflict);                
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
