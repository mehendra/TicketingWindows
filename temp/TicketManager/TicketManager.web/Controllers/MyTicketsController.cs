using Business;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TicketManager.web.Models;

namespace TicketManager.web.Controllers
{
    public class MyTicketsController : Controller
    {
        TicketManagerService ticketService = new TicketManagerService();
        // GET: MyTickets
        public ActionResult Index(string agentCode)
        {
            var tickets = ticketService.SeachTickets(new TicketSearchParams {
                AgentCode = agentCode,
                RecordsPerPage = 150,
                PagingStartIndex = 1
            });

            ViewData["agentName"] = tickets.Results.First().AgentName;

            return View(tickets.Results.Select(a=> new MyTicketViewModel {
                Category = a.Category,
                SoldTo = a.SoldTo,
                TicketNumber = a.TicketNumber,
                Zone= a.Zone,
                IsPaid = (a.TicketStatusCode == "SPAD")
            }));
        }
    }
}