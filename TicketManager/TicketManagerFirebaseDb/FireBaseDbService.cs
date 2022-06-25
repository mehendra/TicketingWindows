using FireSharp.Config;
using FireSharp.Interfaces;
using Models.APIService;
using System.Collections.Generic;

namespace TicketManagerFirebaseDb
{
    public class FireBaseDbService
    {
        IFirebaseConfig fcon = new FirebaseConfig()
        {
            AuthSecret = "uKVAjhyoZeCyEIAENT1ZW59AuQjs4KKv80nBs9WP",
            BasePath = "https://okmeventticketing-dev.firebaseio.com/"
        };

        IFirebaseClient client;

        public void Init()
        {
            try
            {
                client = new FireSharp.FirebaseClient(fcon);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Problem COnnection to the Firebase");
                System.Diagnostics.Debug.WriteLine(ex.Message);
            }
        
        }

        public void writeToDb(ApiTicketsIssued ticketIssued) { 
        
           var setter = client.Set("ticketIssued/"+ticketIssued.TicketId, ticketIssued);
           Console.WriteLine("Succeefully written to db");
                 
        }

        public void GetAll() {

            var result = client.Get("ticketIssued/").ResultAs<List<ApiTicketsIssued>>()
                .Where(ti => ti != null && ti.TicketNumber.Equals("VIP001"));

            foreach (ApiTicketsIssued ticketIssuesd in result)
            {
                if (ticketIssuesd != null)
                {
                    Console.WriteLine(ticketIssuesd.TicketNumber);
                }
            }

        }


        public ApiTicketsIssued? GetTicket(String ticketNumber) {

            List<ApiTicketsIssued> result = client.Get("ticketIssued/").ResultAs<List<ApiTicketsIssued>>()
                .Where(ti => ti != null && ti.TicketNumber.Equals(ticketNumber)).ToList();

           return result.First();

        }


        public List<ApiTicketsIssued>? GetTicketsByAgent(String agentCode)
        {

             List<ApiTicketsIssued> result = client.Get("ticketIssued/").ResultAs<List<ApiTicketsIssued>>()
                .Where(ti => ti != null && ti.Agent.Equals(agentCode)).ToList();

            return result;
        }


        public ApiTicketsIssued? GetTicketsByCategory(String catCode)
        {

            var result = client.Get("ticketIssued/").ResultAs<List<ApiTicketsIssued>>()
                .Where(ti => ti != null && ti.Category.Equals(catCode));

            foreach (ApiTicketsIssued ticketIssuesd in result)
            {
                return ticketIssuesd;
            }
            return null;

        }
    }
}