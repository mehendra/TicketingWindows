using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Services
{
    public interface ITicketConfirmer
    {
        bool ConfirmArrival(ScannedTicket scannedTicket);
    }
}
