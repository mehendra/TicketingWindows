using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Google.Apis.Sheets.v4;
using Google.Apis.Sheets.v4.Data;
using Google.Apis.Services;
using Google.Apis.Util.Store;
using System.Threading;
using Google.Apis.Auth.OAuth2;

namespace ImportData
{
    class Program
    {

        static string[] Scopes = { SheetsService.Scope.SpreadsheetsReadonly };
        static string ApplicationName = "TicketManager";

        public static Dictionary<string, string> nameCodes = new Dictionary<string, string>()
        {
            {"Sarath","SARA"},
            {"Dharshi","DHAR"},
            {"Dharahi","DHAR"},
            {"Amila","AMIL"},
            {"Shashika","SHAK"},
            {"Manori","MANO"},
            {"Ravi","RAVI"},
            {"Chadz","CHAD"},
            {"Mehendra","MEHE"},
            {"Lilupa","LILU"},
            {"Chanaka","CHAN"},
            {"Jay","JAYD"},
            {"Harsha","HARS"},
            {"Shashi","SHAN"},
            {"Sold at door","DOOR"},
            {"Kalani","KALA"},
            {"Nal","NALA"},
            {"Nalaka","NALA"},
            {"Unassigned","NONE"},
            {"Sandun","SAND"},
            { "", "UNAS"}
        };

        static void Main(string[] args)
        {

            var allTicketsSold = ReadGoogleSheet();

            var db = new MMunasinghe_TicketingEntities();
            var tktNumber = 0;
            foreach (TicketRowOnSpredSheet soldTicket in allTicketsSold)
            {
                if (!string.IsNullOrEmpty(soldTicket.Owner))
                {
                    var ticketCategory = string.Empty;

                    if (soldTicket.Gold > 0)
                    {
                        ticketCategory = "Gold";
                    }

                    if (soldTicket.Silver > 0)
                    {
                        ticketCategory = "Silver Adult";
                    }

                    if (soldTicket.SilverChild > 0)
                    {
                        ticketCategory = "Silver Child";
                    }

                    if (soldTicket.GeneralAdult > 0)
                    {
                        ticketCategory = "General Adult";
                    }

                    if (soldTicket.GeneralChild > 0)
                    {
                        ticketCategory = "General Kid";
                    }


                    tktNumber++;
                    var ticketNumber = "TKT" + tktNumber;

                    var agentCode = GetAgentCode(soldTicket.BookedBy);
                    var lineCode = GetTicketCode(ticketCategory);
                    if (!db.Agents.Any(a => agentCode == a.AgentCode))
                    {
                        db.Agents.Add(new Agent { AgentCode = agentCode, AgentName = soldTicket.BookedBy });
                        db.SaveChanges();
                    }

                    var ticketIssued = new TicketsIssued
                    {
                        AgentCode = agentCode,
                        Category = lineCode,
                        SoldTo = soldTicket.Owner,
                        TicketStatusCode = "INIT",
                        TicketNumber = ticketNumber
                    };

                    if (soldTicket.Paid)
                    {
                        ticketIssued.Paid = DateTime.Now;
                    }

                    db.TicketsIssueds.Add(ticketIssued);

                    db.SaveChanges();
                }
            }
        }


        public static List<TicketRowOnSpredSheet> ReadGoogleSheet()
        {
            List<TicketRowOnSpredSheet> ticketOwners = new List<TicketRowOnSpredSheet>();
            UserCredential credential;
            using (var stream =
                new FileStream("client_secret.json", FileMode.Open, FileAccess.Read))
            {
                string credPath = System.Environment.GetFolderPath(
                    System.Environment.SpecialFolder.Personal);
                credPath = Path.Combine(credPath, ".credentials/sheets.googleapis.com-dotnet-quickstart.json");

                credential = GoogleWebAuthorizationBroker.AuthorizeAsync(
                    GoogleClientSecrets.Load(stream).Secrets,
                    Scopes,
                    "user",
                    CancellationToken.None,
                    new FileDataStore(credPath, true)).Result;
                Console.WriteLine("Credential file saved to: " + credPath);
            }

            // Create Google Sheets API service.
            var service = new SheetsService(new BaseClientService.Initializer()
                {
                    HttpClientInitializer = credential,
                    ApplicationName = ApplicationName,
                });

            // Define request parameters.

            //https://docs.google.com/spreadsheets/d/1RIJFHsgYNEMWqC_C2lrI0NbEBQ58lOk2dVTEPW3oNjs/edit#gid=242709292

            String spreadsheetId = "1RIJFHsgYNEMWqC_C2lrI0NbEBQ58lOk2dVTEPW3oNjs";
            String range = "Sheet1!A2:K";
            SpreadsheetsResource.ValuesResource.GetRequest request =
                    service.Spreadsheets.Values.Get(spreadsheetId, range);
            
            ValueRange response = request.Execute();
            IList<IList<Object>> values = response.Values;
            if (values != null && values.Count > 0)
            {
                Console.WriteLine(string.Format("Totl Number of lines {0}",values.Count));
                Console.WriteLine("Name, Major");
                foreach (var row in values)
                {

                    if (row.Count > 0 && row[0] != null)
                    {
                        if (row[0].ToString().Equals("Total"))
                        {
                            break;
                        }

                        var t = new TicketRowOnSpredSheet
                        {
                            Owner = row[0].ToString(),
                            Gold = string.IsNullOrEmpty(row[1].ToString()) ? 0 : 1,
                            Silver = string.IsNullOrEmpty(row[2].ToString()) ? 0 : 1,
                            SilverChild = string.IsNullOrEmpty(row[3].ToString()) ? 0 : 1,
                            GeneralAdult = string.IsNullOrEmpty(row[4].ToString()) ? 0 : 1,
                            GeneralChild = string.IsNullOrEmpty(row[5].ToString()) ? 0 : 1,
                            City = row[6].ToString(),
                            
                        };
                        if (row.Count > 7)
                        {
                            t.BookedBy = row[7].ToString();
                            if (row.Count > 8)
                            {
                                var paidYN = row[8].ToString();
                                t.Paid = paidYN.Equals("Yes", StringComparison.CurrentCultureIgnoreCase) ? true : false;
                            }
                        }
                        ticketOwners.Add(t);
                    }    
                }
                    // Print columns A and E, which correspond to indices 0 and 4.
                    
                }
            else
            {
                Console.WriteLine("No data found.");
            }
            return ticketOwners;
        }


        public static string GetTicketCode(string ticketCategory)
        {

            switch (ticketCategory)
            {
                case "Gold":
                    return "VIP";
                case "Silver Adult":
                    return "SIA";
                case "Silver Child":
                    return "SCH";
                case "General Adult":
                    return "GEN";
                case "General Kid":
                    return "KID";
                default:
                    throw new Exception(string.Format("Unexpected ticket category"));
            }
        }

        public static string GetAgentCode(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                return nameCodes[""];
            }
            else if (nameCodes.Keys.Contains(name.Trim()))
            {
                return nameCodes[name.Trim()];
            }
            else
            {
                throw new KeyNotFoundException(string.Format("Unable to find a matching name code for {0}", name));
            }
        }

    }

    public class TicketRowOnSpredSheet
    {
        public string Owner { get; set; }
        public int Gold { get; set; }
        public int Silver { get; set; }
        public int SilverChild { get; set; }
        public int GeneralAdult { get; set; }
        public int GeneralChild { get; set; }
        public string City { get; set; }
        public string BookedBy { get; set; }
        public bool Paid { get; set; }
        public decimal AmoutPaid { get; set; }
    }
}
