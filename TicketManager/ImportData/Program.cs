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
            {"Amila","AMIL"},
            {"Shashika","SHAK"},
            {"Manori","MANO"},
            {"Ravi","RAVI"},
            {"Chadz","CHAD"},
            {"Mehendra","MEHE"},
            {"Lilupa","LILU"},
            {"Chanaka","CHAN"},
            {"Jayasena","JAYD"},
            {"Harsha","HARS"},
            {"Shashi","SHAN"},
            {"Sold at door","DOOR"},
            {"Kalani","KALA"},
            {"Nal","NALA"},
            {"Nalaka","NALA"},
            {"Unassigned","NONE"},
            {"Sandun","SAND"},
            { "Haritha","HARI"},
            { "", "UNAS"}
        };

        private static string GetBookedPerson(string person)
        {
            if (person.StartsWith("Dharshi"))
            {
                return nameCodes["Dharshi"];
            }
            else
            {
                return nameCodes[person];
            }
        }

        static void Main(string[] args)
        {

            var allTicketsSold = ReadGoogleSheet();


            var db = new MMunasinghe_TicketingEntities();
            var tktNumber = 0;
            
            foreach (TicketRowOnSpredSheet soldTicket in allTicketsSold)
            {
                if (!string.IsNullOrEmpty(soldTicket.Owner))
                {
                    var ticketCategory = GetTicketCategory(soldTicket);
                    
                    tktNumber++;
                    var ticketNumber = "TKT" + tktNumber;

                    if (!db.Agents.Any(a => soldTicket.BookedBy == a.AgentCode))
                    {
                        db.Agents.Add(new Agent { AgentCode = soldTicket.BookedBy, AgentName = soldTicket.BookedBy });
                        db.SaveChanges();
                    }

                    var ticketIssued = new TicketsIssued
                    {
                        AgentCode = soldTicket.BookedBy,
                        Category = ticketCategory,
                        SoldTo = soldTicket.Owner,
                        TicketStatusCode = "INIT",
                        TicketNumber = ticketNumber,
                        Notes = soldTicket.Notes
                    };
                    if(soldTicket.TableNumber > 0)
                    {
                        ticketIssued.TableNumber = soldTicket.TableNumber;
                    }

                    if(!string.IsNullOrEmpty(ticketIssued.City))
                    {
                        ticketIssued.City = soldTicket.City;
                    }

                    

                    if (soldTicket.Paid)
                    {
                        ticketIssued.Paid = DateTime.Now;
                    }

                    db.TicketsIssueds.Add(ticketIssued);

                    db.SaveChanges();
                }
            }
            
        }


        private static string GetTicketCategory(TicketRowOnSpredSheet valueFromSheet)
        {
            if(valueFromSheet.VIP == 1)
            {
                return "VIP";
            }
            else if(valueFromSheet.GeneralAdult == 1)
            {
                return "GEN";
            }
            else if (valueFromSheet.GeneralChild == 1)
            {
                return "KID";
            }
            else if (valueFromSheet.SeatedAdult == 1)
            {
                return "SIA";
            }
            else if (valueFromSheet.SeatedChild == 1)
            {
                return "SCH";
            }
            return "UN";
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

            //String spreadsheetId = "1RIJFHsgYNEMWqC_C2lrI0NbEBQ58lOk2dVTEPW3oNjs";
            String spreadsheetId = "1_z1PpHubNwaIMJKUTH1fvTsCRnvzQHpyxjSHofQ_-QM";            
            String range = "Sheet1!A2:P";

            
            SpreadsheetsResource.ValuesResource.GetRequest request =
                    service.Spreadsheets.Values.Get(spreadsheetId, range);
            request.ValueRenderOption = SpreadsheetsResource.ValuesResource.GetRequest.ValueRenderOptionEnum.UNFORMATTEDVALUE;

            ValueRange response = request.Execute();
            IList<IList<Object>> values = response.Values;
            if (values != null && values.Count > 0)
            {
                Console.WriteLine(string.Format("Totl Number of lines {0}",values.Count));
                Console.WriteLine("Name, Major");
                var rowNumber = 1;
                var tableNumber = 0;
                foreach (var row in values)
                {
                    
                    if (row.Count > 0 && row[0] != null)
                    {
                        if (row[0].ToString().Equals("Total"))
                        {
                            break;
                        }
                        List<object> listOfItems = row.ToList();
                        
                        var t = new TicketRowOnSpredSheet
                        {
                            RowNumber = rowNumber,
                            Owner = row[0].ToString(),
                            VIP = string.IsNullOrEmpty(row[1].ToString()) ? 0 : 1,
                            SeatedAdult = string.IsNullOrEmpty(row[2].ToString()) ? 0 : 1,
                            SeatedChild = string.IsNullOrEmpty(row[3].ToString()) ? 0 : 1,
                            GeneralAdult = string.IsNullOrEmpty(row[4].ToString()) ? 0 : 1,
                            GeneralChild = string.IsNullOrEmpty(row[5].ToString()) ? 0 : 1,
                            Under5 = string.IsNullOrEmpty(row[6].ToString()) ? 0 : 1
                        };
                        
                        //Table number : if the next column is a city
                        if (listOfItems[7].ToString() != "NA" && !string.IsNullOrEmpty(listOfItems[7].ToString()))
                        {
                            tableNumber = int.Parse(listOfItems[7].ToString());
                            t.TableNumber = tableNumber;
                        }
                        if(string.IsNullOrEmpty(listOfItems[7].ToString()))
                        {
                            t.TableNumber = tableNumber;
                        }
                        if (listOfItems[7].ToString() == "NA")
                        {
                            tableNumber = 0;
                        }

                        t.City = listOfItems[9].ToString();
                        t.Notes = string.Format("Booked By:" + listOfItems[10].ToString());
                        t.BookedBy = GetBookedPerson(listOfItems[10].ToString().Trim());
                            
                        ticketOwners.Add(t);
                    rowNumber++;
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

    }

    public class TicketRowOnSpredSheet
    {
        public int RowNumber { get; set; }
        public string Owner { get; set; }
        public int VIP { get; set; }
        public int SeatedAdult { get; set; }
        public int SeatedChild { get; set; }
        public int GeneralAdult { get; set; }
        public int GeneralChild { get; set; }
        public int Under5 { get; set; }
        public int TableNumber { get; set; }
        public string City { get; set; }
        public string BookedBy { get; set; }
        public bool Paid { get; set; }
        public decimal AmoutPaid { get; set; }

        public string Notes { get; set; }
    }
}
