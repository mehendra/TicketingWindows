using Business;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using TicketManager.web;

namespace TicketManager.web.Controllers
{
    public class TicketsController : Controller
    {
        private TicketingEntities db = new TicketingEntities();

        public ActionResult AssignTicket(string agentCode)
       {
            var ticketsIssueds = db.TicketsIssueds.Where(a=>a.AgentCode == agentCode);
            var agent = db.Agents.First(a => a.AgentCode == agentCode);
            ViewData.Add("agentCode", agentCode);
            ViewData.Add("agentName", agent.AgentName);
            return View(ticketsIssueds.ToList());
        }
        
        // GET: Tickets
        public ActionResult Index()
        {
            var ticketsIssueds = db.TicketsIssueds.Include(t => t.Agent).Include(t => t.TicketStatu);
            return View(ticketsIssueds.ToList());
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

        // GET: Tickets/Create
        public ActionResult Create()
        {
            ViewBag.AgentCode = new SelectList(db.Agents, "AgentCode", "AgentName");
            ViewBag.TicketStatusCode = new SelectList(db.TicketStatus, "TicketStatusCode", "TicketStatus");
            return View();
        }

        // POST: Tickets/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "TicketNumber,AgentCode,Category,TicketStatusCode,ArrivedAt,ArrivalConfirmedBy")] TicketsIssued ticketsIssued)
        {
            if (ModelState.IsValid)
            {
                db.TicketsIssueds.Add(ticketsIssued);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.AgentCode = new SelectList(db.Agents, "AgentCode", "AgentName", ticketsIssued.AgentCode);
            ViewBag.TicketStatusCode = new SelectList(db.TicketStatus, "TicketStatusCode", "TicketStatus", ticketsIssued.TicketStatusCode);
            return View(ticketsIssued);
        }

        // GET: Tickets/Edit/5
        public ActionResult Edit(string id)
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
            ViewBag.AgentCode = new SelectList(db.Agents, "AgentCode", "AgentName", ticketsIssued.AgentCode);
            ViewBag.TicketStatusCode = new SelectList(db.TicketStatus, "TicketStatusCode", "TicketStatus", ticketsIssued.TicketStatusCode);
            return View(ticketsIssued);
        }

        // POST: Tickets/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "TicketNumber,AgentCode,Category,TicketStatusCode,ArrivedAt,ArrivalConfirmedBy")] TicketsIssued ticketsIssued)
        {
            if (ModelState.IsValid)
            {
                db.Entry(ticketsIssued).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.AgentCode = new SelectList(db.Agents, "AgentCode", "AgentName", ticketsIssued.AgentCode);
            ViewBag.TicketStatusCode = new SelectList(db.TicketStatus, "TicketStatusCode", "TicketStatus", ticketsIssued.TicketStatusCode);
            return View(ticketsIssued);
        }

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
                        db.TicketsIssueds.Add(new TicketsIssued { TicketNumber = ticket });
                        db.SaveChanges();
                    }
                    catch (Exception)
                    {
                        allErrors.Add("Failed to add ticket number " + ticket);
                    }
                }
                return RedirectToAction("Index");
            }
            throw new Exception("Ahhhh!");
        }

        public ActionResult BulkCreate() {
            return View();
        }
        // GET: Tickets/Delete/5
        public ActionResult Delete(string id)
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

        // POST: Tickets/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            TicketsIssued ticketsIssued = db.TicketsIssueds.Find(id);
            db.TicketsIssueds.Remove(ticketsIssued);
            db.SaveChanges();
            return RedirectToAction("Index");
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
