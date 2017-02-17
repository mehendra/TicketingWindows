﻿using Models;
using Models.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class TicketManagerService
    {
        private TicketingEntities db = new TicketingEntities();
        ILogger logger = new Logger();
        public BusinessHandlerResponse<TicketsIssued> AddTicket(TicketsIssued ticket)
        {
            try
            {
                if (db.TicketsIssueds.Any(a => a.TicketNumber == ticket.TicketNumber))
                {
                    var ticketIssued = db.TicketsIssueds.First(b => b.TicketNumber == ticket.TicketNumber);
                    return new BusinessHandlerResponse<TicketsIssued>()
                    {
                        IsASuccess = false,
                        Errors = new List<string> { "Ticket already issued to " + ticketIssued.Agent.AgentName }
                    };
                }
                db.TicketsIssueds.Add(ticket);
                db.SaveChanges();
                return new BusinessHandlerResponse<TicketsIssued>()
                {
                    IsASuccess = true
                };
            }
            catch (Exception ex)
            {
                logger.logMessage(ex.Message, LogLevel.error);
                return new BusinessHandlerResponse<TicketsIssued>()
                {
                    IsASuccess = false,
                    Errors = new List<string> { "Failed due to an unknown error please check the logs" }
                };
            }
        }
        public BusinessHandlerResponse<TicketsIssued> GetTicket(string ticketNumber)
        {
            try
            {
                var tickets = db.TicketsIssueds.FirstOrDefault(a => a.TicketNumber == ticketNumber);
                if (tickets != null)
                {
                    return new BusinessHandlerResponse<TicketsIssued>()
                    {
                        IsASuccess = true,
                        ItemResuested = tickets
                    };
                }
                else
                {
                    return new BusinessHandlerResponse<TicketsIssued>()
                    {
                        IsASuccess = false,
                        Errors = new List<string> { "Unable to find the ticket number " + ticketNumber }
                    };
                }

            }
            catch (Exception ex)
            {
                logger.logMessage(ex.Message, LogLevel.error);
                return new BusinessHandlerResponse<TicketsIssued>()
                {
                    IsASuccess = false,
                    Errors = new List<string> { "Unknown error trying to get the ticket" }
                };
            }
        }

    }
    }