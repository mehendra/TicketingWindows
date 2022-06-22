using FireSharp.Config;
using FireSharp.Interfaces;
using Models.APIService;

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
                Console.Write("Problem COnnection to the Firebase");
                System.Diagnostics.Debug.WriteLine(ex.Message);
            }
        
        }

        public void writeToDb(ApiTicketsIssued ticketIssued) { 
        
           var setter = client.Set("ticketIssued/"+ticketIssued.TicketId, ticketIssued);
            Console.Write("Succeefully written to db");
        
        }
    }
}