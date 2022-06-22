using Models.APIService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketManagerFirebaseDb
{
    internal class TestDriver
    {

        static void Main(String[] args) {
            FireBaseDbService dbservice = new FireBaseDbService();
            dbservice.Init();
            ApiTicketsIssued ticketsIssued = new ApiTicketsIssued()
            {
                TicketId = 0001,
                Agent = "SHAN",
                Category = "VIP",
                TicketStatusCode = "SPAD",
                Zone = "VIP",
                SoldTo = "Shasinda",
                TicketNumber = "VIP001",
                Paid = "22/06/2022",
                Notes = "Great Guy, Free tickets for future okm events"

            };

            dbservice.writeToDb(ticketsIssued);
 
         }
    }
}
