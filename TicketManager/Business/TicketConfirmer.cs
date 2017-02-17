using Models;
using Models.Services;

namespace Business
{
    public class TicketConfirmer : ITicketConfirmer
    {
        public bool ConfirmArrival(ScannedTicket scannedTicket)
        {
            return true;
        }

    }
}
