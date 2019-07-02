using Models.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class LoginService
    {
        private TicketingEntities db = new TicketingEntities();
        ILogger logger = new Logger();

        public LoginService()
        {
            db = new TicketingEntities();
            db.Configuration.ProxyCreationEnabled = false;
        }

        public bool IsUserValid(string userName, string password)
        {
            return db.TicketSiteUsers.Any(a => a.UserName == userName && a.Password == password);
        }
    }
}
