namespace Models.APIService
{
    public class ApiTicketsIssued
    {
        public int TicketId { get; set; }
        public string Agent { get; set; }
        public string Category { get; set; }
        public string TicketStatusCode { get; set; }
        public string SoldTo { get; set; }
        public string Zone { get; set; }
        public string Notes { get; set; }
        public string TicketNumber { get; set; }

        public string Paid { get; set; }
    }
}
