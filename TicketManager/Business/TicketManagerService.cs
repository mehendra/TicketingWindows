using Models;
using Models.Services;
using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class TicketManagerService
    {
        private TicketingEntities db = new TicketingEntities();
        ILogger logger = new Logger();
        public BusinessHandlerResponse<TicketsIssued> AddOrIssue(TicketsIssued ticket)
        {
            try
            {
                if (db.TicketsIssueds.Any(a => a.TicketNumber == ticket.TicketNumber))
                {
                    var ticketIssued = db.TicketsIssueds.First(b => b.TicketNumber == ticket.TicketNumber);
                    if (ticketIssued.TicketStatusCode != Constants.TicketStatus.Initial)
                    {
                        return new BusinessHandlerResponse<TicketsIssued>()
                        {
                            IsASuccess = false,
                            Errors = new List<string> { string.Format("Ticket {0} already issued to {1} ", ticketIssued.TicketNumber, ticketIssued.Agent.AgentName) }
                        };
                    }
                    else
                    {
                        ticketIssued.TicketStatusCode = Constants.TicketStatus.Issued;
                    }
                }
                else
                {
                    if (string.IsNullOrWhiteSpace(ticket.TicketStatusCode))
                    {
                        ticket.TicketStatusCode = Constants.TicketStatus.Initial;
                    }

                    if (string.IsNullOrWhiteSpace(ticket.AgentCode))
                    {
                        ticket.AgentCode = Constants.FixedAgents.Unassigned;
                    }

                    db.TicketsIssueds.Add(ticket);
                }                
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

        public SearchResultsWrapper<SeachTickets_Result> SeachTickets(TicketSearchParams parameters)
        {
            var ticketNumberFormatted = parameters.TicketNumber;
            if(!string.IsNullOrWhiteSpace(parameters.TicketNumber) && !parameters.TicketNumber.StartsWith("BNS2017"))
            {
                ticketNumberFormatted = "BNS2017" + ticketNumberFormatted;
            }
            ObjectParameter recordCount = new ObjectParameter("TotalRecords", typeof(int));
            var searchResults = db.SeachTickets(ticketNumberFormatted, parameters.AgentCode, parameters.TicketStatusCode, parameters.Category, parameters.TotalRecords, parameters.RecordsPerPage, parameters.PagingStartIndex, recordCount).ToList();
            return new SearchResultsWrapper<SeachTickets_Result> { RecordCiount = (int)recordCount.Value , Results = searchResults };
        }
    }
 }