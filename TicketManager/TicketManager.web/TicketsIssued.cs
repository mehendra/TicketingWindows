//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TicketManager.web
{
    using System;
    using System.Collections.Generic;
    
    public partial class TicketsIssued
    {
        public string TicketNumber { get; set; }
        public string AgentCode { get; set; }
        public string Category { get; set; }
        public string TicketStatusCode { get; set; }
        public Nullable<System.DateTime> ArrivedAt { get; set; }
        public string ArrivalConfirmedBy { get; set; }
    
        public virtual Agent Agent { get; set; }
        public virtual TicketStatu TicketStatu { get; set; }
    }
}
