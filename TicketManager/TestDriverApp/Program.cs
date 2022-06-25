using Models.APIService;
using TicketManagerFirebaseDb;

class Program {


    public static void Main(String[] args)
    {
        Console.Write("Hello World ");

        FireBaseDbService dbservice = new FireBaseDbService();
        dbservice.Init();
        //ApiTicketsIssued ticketsIssued = new ApiTicketsIssued()
        //{
        //    TicketId = 0005,
        //    Agent = "SHAN",
        //    Category = "VIP",
        //    TicketStatusCode = "SPAD",
        //    Zone = "VIP",
        //    SoldTo = "Micheal",
        //    TicketNumber = "VIP001",
        //    Paid = "22/06/2022",
        //    Notes = "Great Guy, Free tickets for future okm events"

        //};

        //dbservice.writeToDb(ticketsIssued);

        ApiTicketsIssued apiTicketsIssued = dbservice.GetTicket("VIP003");

        Console.WriteLine(apiTicketsIssued.SoldTo);
    }

}