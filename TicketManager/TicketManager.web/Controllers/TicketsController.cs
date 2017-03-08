using Business;
using Models;
using Models.Services;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using TicketManager.web;
using TicketManager.web.Models;

namespace TicketManager.web.Controllers
{
    public class TicketsController : Controller
    {
        private TicketingEntities db = new TicketingEntities();
        TicketManagerService ticketService = new TicketManagerService();
        StaticDataService staticDataService = new StaticDataService();
        ILogger loggerService = new Logger();

        public ActionResult AssignTicket(string agentCode)
       {
            var ticketsIssueds = db.TicketsIssueds.Where(a=>a.AgentCode == agentCode);
            var agent = db.Agents.First(a => a.AgentCode == agentCode);
            ViewData.Add("agentCode", agentCode);
            ViewData.Add("agentName", agent.AgentName);
            return View(ticketsIssueds.ToList());
        }

        [Authorize]
        public ActionResult Index()
        {
            var searchInfo = new TicketSearchInfoViewModel<Business.SeachTickets_Result>();
            if (searchInfo.SearchParameters == null)
            {
                searchInfo.SearchParameters = new TicketSearchParams()
                {
                    RecordsPerPage = 50,
                    PagingStartIndex = 1
                };
            }
            AddViewData(searchInfo);
            searchInfo.SearchResults = ticketService.SeachTickets(searchInfo.SearchParameters);
            return View(searchInfo);
        }

        [Authorize]
        [HttpPost]
        public ActionResult Index(TicketSearchInfoViewModel<Business.SeachTickets_Result> searchInfo)
        {
            SearchRecordsAndUpdateView(searchInfo);
            return View(searchInfo);
        }


        private void SearchRecordsAndUpdateView(TicketSearchInfoViewModel<Business.SeachTickets_Result> searchInfo)
        {
            if (searchInfo.SearchParameters == null)
            {
                searchInfo.SearchParameters = new TicketSearchParams()
                {
                    RecordsPerPage = 50,
                    PagingStartIndex = 1
                };
            }
            searchInfo.SearchResults = ticketService.SeachTickets(searchInfo.SearchParameters);
            AddViewData(searchInfo);
        }

        private void AddViewData(DropdownListModelView searchViewModel)
        {
            searchViewModel.Agents = staticDataService.GetAgents().Select(a =>
            new SelectListItem
            {
                Text = a.AgentName,
                Value = a.AgentCode
            });

            searchViewModel.TicketStatus = staticDataService.GetTicketStatuses().Select(a =>
            new SelectListItem
            {
                Text = a.TicketStatus,
                Value = a.TicketStatusCode
            });

            searchViewModel.Categories = staticDataService.GetTicketCategory().Select(a =>
            new SelectListItem
            {
                Text = a.Value,
                Value = a.Key
            });


            searchViewModel.RecordsPerPage = staticDataService.GetRecordsPerPage().Select(a =>
            new SelectListItem
            {
                Text = a.Value,
                Value = a.Key
            });

            searchViewModel.Zones = staticDataService.GetZones().Select(a =>
            new SelectListItem
            {
                Text = a.Value,
                Value = a.Key
            });
        }

        // GET: Tickets/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TicketsIssued ticketsIssued = db.TicketsIssueds.Find(id);
            if (ticketsIssued == null)
            {
                return HttpNotFound();
            }
            return View(ticketsIssued);
        }

        [Authorize]
        public ActionResult Create()
        {
            var emptyMdoel = new TicketDetailsViewModel();
            AddViewData(emptyMdoel);
            return View(emptyMdoel);
        }

        [Authorize]
        [HttpPost]
        public ActionResult Create(TicketDetailsViewModel data)
        {
            ticketService.AddOrIssue(data.TicketDetails);
            return RedirectToAction("index");
        }

        [Authorize]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult BulkCreate(string ticketsIssued)
        {
            if (ModelState.IsValid && !string.IsNullOrWhiteSpace(ticketsIssued))
            {
                var allTickets = ticketsIssued.Replace(Environment.NewLine,",").Split(',').Select(a => a.Trim());
                var allErrors = new List<string>();
                foreach (var ticket in allTickets)
                {
                    try
                    {
                        if (!string.IsNullOrWhiteSpace(ticket))
                        {
                            var savedFailiur = ticketService.AddOrIssue(new TicketsIssued { TicketNumber = ticket, TicketStatusCode = Business.Constants.TicketStatus.Initial, AgentCode = Business.Constants.FixedAgents.Unassigned });
                            if (!savedFailiur.IsASuccess)
                            {
                                allErrors.AddRange(savedFailiur.Errors);
                            }
                        }                        
                    }
                    catch (Exception ex)
                    {
                        allErrors.Add("Failed to add ticket number " + ticket);
                        loggerService.logMessage("Failed to add ticket number " + ticket + " with error: " + ex.Message, LogLevel.error);
                    }
                }
                if (allErrors.Count > 0)
                {
                    ViewBag.Errors = allErrors;
                }
                else {
                    return RedirectToAction("Index");
                }                
            }
            return View();
        }

        [Authorize]
        public ActionResult BulkCreate() {
            return View();
        }
        
        public ActionResult SummaryByAgent()
        {
            var ticketSummary = ticketService.GetTicketsSummary();
            return View(ticketSummary);
        }

        public ActionResult UnpaidByAgent()
        {
            var ticketSummary = ticketService.GetAllUnpaid();
            return View(ticketSummary);
        }


        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
