using Business.Constants;
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
    class TicketSubInfo
    {
        public string Category { get; set; }
        public string Zone { get; set; }
    }

    public class TicketManagerService
    {
        private TicketingEntities db;
        private StaticDataService staticData;
        ILogger logger = new Logger();

        public TicketManagerService()
        {
            db = new TicketingEntities();
            staticData = new StaticDataService();
            db.Configuration.ProxyCreationEnabled = false;
        }


        public BusinessHandlerResponse<TicketsIssued> UpdateTicketStatusAndNotes(int ticketId, string StatusCode, string Notes)
        {
            try
            {

                db.UpdateTicketNotesAndPaymentState(ticketId, StatusCode, Notes);

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

        public BusinessHandlerResponse<TicketsIssued> UpdateTicket(TicketsIssued ticket)
        {
            try
            {
                var ticketFromDb = db.TicketsIssueds.FirstOrDefault(a => a.TicketId == ticket.TicketId);
                if (ticketFromDb != null)
                {
                    if (ticketFromDb.AgentCode != ticket.AgentCode)
                    {
                        ticketFromDb.AgentCode = ticket.AgentCode;
                    }
                    if (ticketFromDb.Category != ticket.Category)
                    {
                        ticketFromDb.Category = ticket.Category;
                    }
                    if (ticketFromDb.TicketStatusCode != ticket.TicketStatusCode)
                    {
                        ticketFromDb.TicketStatusCode = ticket.TicketStatusCode;
                    }
                    if (ticketFromDb.Zone != ticket.Zone)
                    {
                        ticketFromDb.Zone = ticket.Zone;
                    }
                    if (ticketFromDb.Notes != ticket.Notes)
                    {
                        ticketFromDb.Notes = (string.IsNullOrWhiteSpace(ticket.Notes)) ? ticket.Notes : ticket.Notes.Trim();
                    }
                    if (ticketFromDb.SoldTo != ticket.SoldTo)
                    {
                        ticketFromDb.SoldTo = (string.IsNullOrWhiteSpace(ticket.SoldTo)) ? ticket.SoldTo : ticket.SoldTo.Trim();
                    }
                    if (ticketFromDb.TicketNumber != ticket.TicketNumber)
                    {
                        ticketFromDb.TicketNumber = ticket.TicketNumber;
                    }
                    ticketFromDb.Paid = ticket.Paid;
                }
                else
                {
                    throw new Exception("Unknown Ticket " + ticket.TicketNumber);
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
        public BusinessHandlerResponse<TicketsIssued> AddOrIssue(TicketsIssued ticket)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(ticket.Category))
                {
                    var ticketCategoryCode = GetTheCategoryFromTicketNumber(ticket.TicketNumber);
                    if (string.IsNullOrEmpty(ticketCategoryCode.Category))
                    {
                        ticket.Category = Defaults.TicketCategory;
                    }
                    else
                    {
                        ticket.Category = ticketCategoryCode.Category;
                    }
                    ticket.Zone = ticketCategoryCode.Zone;
                }
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

        private TicketSubInfo GetTheCategoryFromTicketNumber(string ticketNumber)
        {
            var ticketSubInfo = new TicketSubInfo();
            var allCategories = staticData.GetTicketCategory();
            var strippedTicketNumber = ticketNumber.Replace(Constants.Defaults.TicketNumberPrefix, "");
            var category = allCategories.FirstOrDefault(a => strippedTicketNumber.StartsWith(a.Key)).Key;
            if (category == ZonedCategories.ZoneA)
            {
                ticketSubInfo.Zone = "Zone1";
            }
            else if (category == ZonedCategories.ZoneBLeft)
            {
                ticketSubInfo.Zone = "ZoneBLeft";
            }
            else if (category == ZonedCategories.ZoneBRight)
            {
                ticketSubInfo.Zone = "ZoneBRight";
            }
            else
            {
                ticketSubInfo.Zone = "UnZoned";
            }
            ticketSubInfo.Category = category;
            return ticketSubInfo;
        }

        public BusinessHandlerResponse<TicketsIssued> GetTicket(int ticketId)
        {
            try
            {
                var ticketCats = staticData.GetTicketCategory();
                var ticketStatus = staticData.GetTicketStatuses();
                var tickets = db.TicketsIssueds.Include("Agent").Include("TicketStatu").FirstOrDefault(a => a.TicketId == ticketId);
                if (tickets != null)
                {
                    var item = new BusinessHandlerResponse<TicketsIssued>()
                    {
                        IsASuccess = true,
                        ItemReturned = tickets
                    };
                    item.ItemReturned.AgentName = tickets.Agent.AgentName;
                    if (item.ItemReturned.TicketStatusCode == null)
                    {
                        item.ItemReturned.TicketStatusCode = Constants.TicketStatus.Initial;
                        item.ItemReturned.TicketStatusDescription = ticketStatus.First(a => a.TicketStatusCode == Constants.TicketStatus.Initial).TicketStatus;
                    }
                    else {
                        item.ItemReturned.TicketStatusDescription = tickets.TicketStatu.TicketStatus;
                        item.ItemReturned.TicketStatu = null;
                    }
                    if (!string.IsNullOrEmpty(item.ItemReturned.Category))
                    {
                        item.ItemReturned.CategoryDescription = ticketCats.First(a => a.Key == item.ItemReturned.Category).Value;
                    }
                    item.ItemReturned.Agent = null;
                    return item;
                }
                else
                {
                    return new BusinessHandlerResponse<TicketsIssued>()
                    {
                        IsASuccess = false,
                        Errors = new List<string> { "Unable to find the ticket number " + ticketId }
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

        public SearchResultsWrapper<SeachTicketsWithWildCards_Result> SeachTicketsWithWildCards(TicketSearchParams parameters)
        {
            ObjectParameter recordCount = new ObjectParameter("TotalRecords", typeof(int));
            var searchResults = db.SeachTicketsWithWildCards(parameters.TicketNumber, parameters.Category,parameters.AgentCode,parameters.SoldTo, parameters.TableNo,parameters.TotalRecords, parameters.RecordsPerPage, parameters.PagingStartIndex, recordCount).ToList();
            return new SearchResultsWrapper<SeachTicketsWithWildCards_Result> { RecordCount = (int)recordCount.Value, Results = searchResults };
        }

        public SearchResultsWrapper<SeachTickets_Result> SeachTickets(TicketSearchParams parameters)
        {
            var ticketNumberFormatted = parameters.TicketNumber;
            var allCategories = staticData.GetTicketCategory();
            if (!string.IsNullOrWhiteSpace(parameters.TicketNumber) && !parameters.TicketNumber.StartsWith(Constants.Defaults.TicketNumberPrefix))
            {
                ticketNumberFormatted = Constants.Defaults.TicketNumberPrefix + ticketNumberFormatted;
            }
            ObjectParameter recordCount = new ObjectParameter("TotalRecords", typeof(int));
            var searchResults = db.SeachTickets(ticketNumberFormatted, parameters.AgentCode, parameters.TicketStatusCode, parameters.Category, parameters.SoldTo, parameters.TableNo, parameters.TotalRecords, parameters.RecordsPerPage, parameters.PagingStartIndex, recordCount).ToList();
            for (int i = 0; i < searchResults.Count; i++)
            {
                searchResults[i].SearchCategoryDescription = allCategories.First(a => a.Key == searchResults[i].Category).Value;
            }
            return new SearchResultsWrapper<SeachTickets_Result> { RecordCount = (int)recordCount.Value, Results = searchResults };
        }

        public bool DeleteTicket(int ticketId) {
            var ticket = db.TicketsIssueds.FirstOrDefault(a => a.TicketId == ticketId);
            if (ticket != null)
            {
                db.TicketsIssueds.Remove(ticket);
                db.SaveChanges();
                return true;
            }
            return false;
        }

        public List<ReportTicketSummary_Result> GetTicketsSummary()
        {
            return db.ReportTicketSummary().ToList<ReportTicketSummary_Result>();
        }


        public List<ReportTicketAllUnpaid_Result> GetAllUnpaid()
        {
            return db.ReportTicketAllUnpaid().ToList<ReportTicketAllUnpaid_Result>();
        }

        public List<GetTableAllocations_Result> GetTableAllocations()
        {
            return db.GetTableAllocations().ToList<GetTableAllocations_Result>();
        }

    }
 }