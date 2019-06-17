﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Business
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class TicketingEntities : DbContext
    {
        public TicketingEntities()
            : base("name=TicketingEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<TicketStatu> TicketStatus { get; set; }
        public virtual DbSet<Agent> Agents { get; set; }
        public virtual DbSet<TicketCategory> TicketCategories { get; set; }
        public virtual DbSet<TicketsIssued> TicketsIssueds { get; set; }
        public virtual DbSet<TicketSiteUser> TicketSiteUsers { get; set; }
    
        public virtual ObjectResult<ReportTicketSummary_Result> ReportTicketSummary()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<ReportTicketSummary_Result>("ReportTicketSummary");
        }
    
        public virtual ObjectResult<ReportTicketAllUnpaid_Result> ReportTicketAllUnpaid()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<ReportTicketAllUnpaid_Result>("ReportTicketAllUnpaid");
        }
    
        public virtual ObjectResult<SeachTicketsWithWildCards_Result> SeachTicketsWithWildCards(string ticketNumber, string category, string soldBy, string soldTo, Nullable<int> tableNo, Nullable<int> rcordCount, Nullable<int> recordsPerPage, Nullable<int> pagingStartIndex, ObjectParameter totalRecords)
        {
            var ticketNumberParameter = ticketNumber != null ?
                new ObjectParameter("TicketNumber", ticketNumber) :
                new ObjectParameter("TicketNumber", typeof(string));
    
            var categoryParameter = category != null ?
                new ObjectParameter("Category", category) :
                new ObjectParameter("Category", typeof(string));
    
            var soldByParameter = soldBy != null ?
                new ObjectParameter("SoldBy", soldBy) :
                new ObjectParameter("SoldBy", typeof(string));
    
            var soldToParameter = soldTo != null ?
                new ObjectParameter("SoldTo", soldTo) :
                new ObjectParameter("SoldTo", typeof(string));
    
            var tableNoParameter = tableNo.HasValue ?
                new ObjectParameter("TableNo", tableNo) :
                new ObjectParameter("TableNo", typeof(int));
    
            var rcordCountParameter = rcordCount.HasValue ?
                new ObjectParameter("RcordCount", rcordCount) :
                new ObjectParameter("RcordCount", typeof(int));
    
            var recordsPerPageParameter = recordsPerPage.HasValue ?
                new ObjectParameter("RecordsPerPage", recordsPerPage) :
                new ObjectParameter("RecordsPerPage", typeof(int));
    
            var pagingStartIndexParameter = pagingStartIndex.HasValue ?
                new ObjectParameter("PagingStartIndex", pagingStartIndex) :
                new ObjectParameter("PagingStartIndex", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SeachTicketsWithWildCards_Result>("SeachTicketsWithWildCards", ticketNumberParameter, categoryParameter, soldByParameter, soldToParameter, tableNoParameter, rcordCountParameter, recordsPerPageParameter, pagingStartIndexParameter, totalRecords);
        }
    
        public virtual int UpdateTicketNotesAndPaymentState(Nullable<int> ticketId, string ticketStatusCode, string notes)
        {
            var ticketIdParameter = ticketId.HasValue ?
                new ObjectParameter("TicketId", ticketId) :
                new ObjectParameter("TicketId", typeof(int));
    
            var ticketStatusCodeParameter = ticketStatusCode != null ?
                new ObjectParameter("TicketStatusCode", ticketStatusCode) :
                new ObjectParameter("TicketStatusCode", typeof(string));
    
            var notesParameter = notes != null ?
                new ObjectParameter("Notes", notes) :
                new ObjectParameter("Notes", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("UpdateTicketNotesAndPaymentState", ticketIdParameter, ticketStatusCodeParameter, notesParameter);
        }
    
        public virtual ObjectResult<SeachTickets_Result> SeachTickets(string ticketNumber, string agentCode, string ticketStatusCode, string zone, string category, string soldTo, Nullable<int> rcordCount, Nullable<int> recordsPerPage, Nullable<int> pagingStartIndex, ObjectParameter totalRecords)
        {
            var ticketNumberParameter = ticketNumber != null ?
                new ObjectParameter("TicketNumber", ticketNumber) :
                new ObjectParameter("TicketNumber", typeof(string));
    
            var agentCodeParameter = agentCode != null ?
                new ObjectParameter("AgentCode", agentCode) :
                new ObjectParameter("AgentCode", typeof(string));
    
            var ticketStatusCodeParameter = ticketStatusCode != null ?
                new ObjectParameter("TicketStatusCode", ticketStatusCode) :
                new ObjectParameter("TicketStatusCode", typeof(string));
    
            var zoneParameter = zone != null ?
                new ObjectParameter("Zone", zone) :
                new ObjectParameter("Zone", typeof(string));
    
            var categoryParameter = category != null ?
                new ObjectParameter("Category", category) :
                new ObjectParameter("Category", typeof(string));
    
            var soldToParameter = soldTo != null ?
                new ObjectParameter("SoldTo", soldTo) :
                new ObjectParameter("SoldTo", typeof(string));
    
            var rcordCountParameter = rcordCount.HasValue ?
                new ObjectParameter("RcordCount", rcordCount) :
                new ObjectParameter("RcordCount", typeof(int));
    
            var recordsPerPageParameter = recordsPerPage.HasValue ?
                new ObjectParameter("RecordsPerPage", recordsPerPage) :
                new ObjectParameter("RecordsPerPage", typeof(int));
    
            var pagingStartIndexParameter = pagingStartIndex.HasValue ?
                new ObjectParameter("PagingStartIndex", pagingStartIndex) :
                new ObjectParameter("PagingStartIndex", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SeachTickets_Result>("SeachTickets", ticketNumberParameter, agentCodeParameter, ticketStatusCodeParameter, zoneParameter, categoryParameter, soldToParameter, rcordCountParameter, recordsPerPageParameter, pagingStartIndexParameter, totalRecords);
        }
    }
}
