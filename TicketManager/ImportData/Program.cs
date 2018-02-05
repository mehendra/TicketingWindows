using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImportData
{
    class Program
    {

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
            {"Sandun","SAND"}
        };

        static void Main(string[] args)
        {
            var db = new MMunasinghe_TicketingEntities();
            var tktNumber = 0;
            var allText = File.ReadAllText(@"C:\Dev\TicketingWindows\TicketManager\ImportData\Data\TicketData.csv");
            var csvFile = Csv.CsvReader.ReadFromText(allText, new Csv.CsvOptions()
            {
                HeaderMode = Csv.HeaderMode.HeaderPresent,
                Separator = ',',
                TrimData = true
                }
            );
            foreach (Csv.ICsvLine line in csvFile)
            {
                if (!string.IsNullOrEmpty(line[1]))
                {
                    var agentName = line[7];
                    var sold = line[0];
                    var ticketCategory = string.Empty;
                    if (string.IsNullOrEmpty(line[1]))
                    {
                        ticketCategory = "Gold";
                    }

                    if (string.IsNullOrEmpty(line[2]))
                    {
                        ticketCategory = "Silver Adult";
                    }

                    if (string.IsNullOrEmpty(line[3]))
                    {
                        ticketCategory = "Silver Child";
                    }

                    if (string.IsNullOrEmpty(line[4]))
                    {
                        ticketCategory = "General Adult";
                    }

                    if (string.IsNullOrEmpty(line[5]))
                    {
                        ticketCategory = "General Kid";
                    }


                    tktNumber++;
                    var ticketNumber = "TKT" + tktNumber;

                    var agentCode = GetCode(agentName);
                    var lineCode = GetTicketCode(ticketCategory);
                    if (!db.Agents.Any(a => agentCode == a.AgentCode))
                    {
                        db.Agents.Add(new Agent { AgentCode = agentCode, AgentName = agentName });
                        db.SaveChanges();
                    }

                    db.TicketsIssueds.Add(new TicketsIssued {
                        AgentCode = agentCode,
                        Category = lineCode,
                        SoldTo = sold,
                        TicketStatusCode = "INIT",
                        TicketNumber = tktNumber.ToString()
                    });

                    db.SaveChanges();
                }
            }
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

        public static string GetCode(string name)
        {
            if (nameCodes.Keys.Contains(name))
            {
                return nameCodes[name];
            }
            else
            {
                throw new KeyNotFoundException(string.Format("Unable to find a matching name code for {0}", name));
            }
        }

    }
}
