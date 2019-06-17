using Business;
using Models.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Utilities;

namespace TicketManager
{
    public partial class TicketDetails : Form
    {
        private int? ticketNumber;
        private Business.TicketsIssued currentTicket;
        private Business.TicketManagerService ticketManagerService;
        private Business.TicketConfirmerService ticketConfirmationService;
        ILogger logger = new Logger();

        public TicketDetails(int? ticketNumber = null, string message = null)
        {
            ticketManagerService = new Business.TicketManagerService();
            ticketConfirmationService = new Business.TicketConfirmerService(logger);
            if (ticketNumber.HasValue)
            {
                this.ticketNumber = ticketNumber;
                currentTicket = ticketManagerService.GetTicket(this.ticketNumber.Value).ItemReturned;
            }
            InitializeComponent();
            if (!string.IsNullOrEmpty(message))
            {
                MessageLabel.Text = message;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void TicketDetails_Load(object sender, EventArgs e)
        {
            TicketNumberTextBox.Text = currentTicket.TicketNumber;
            AgentTextBox.Text = currentTicket.AgentName;
            TicketCategoryTextBox.Text = currentTicket.CategoryDescription;
            TicketStatusTextBox.Text = currentTicket.TicketStatusDescription;
            ZoneTextBox.Text = currentTicket.Zone;
            NotesTextBox.Text = currentTicket.Notes;
            SoldToTextBox.Text = currentTicket.SoldTo;
            ScannedTextBox.Text = (currentTicket.ArrivedAt.HasValue) ? currentTicket.ArrivedAt.Value.ToString() : "";
            ScannedByTextBox.Text = currentTicket.ArrivalConfirmedBy;
            TableNumberTextBox.Text = currentTicket.TableNumber;
        }

        private void MarkedPaidButton_Click(object sender, EventArgs e)
        {
            try
            {
                ticketManagerService.UpdateTicketStatusAndNotes(this.ticketNumber.Value, Business.Constants.TicketStatus.Paid, NotesTextBox.Text);
                ticketConfirmationService.ConfirmArrival(new Models.ScannedTicket(TicketNumberTextBox.Text, new CurrentSysInfo()), true);
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to update " + ex.Message);
            }
           
        }

        private void IncompletePaymentButton_Click(object sender, EventArgs e)
        {
            ticketManagerService.UpdateTicketStatusAndNotes(this.ticketNumber.Value, Business.Constants.TicketStatus.PariallyPaid, NotesTextBox.Text);
            ticketConfirmationService.ConfirmArrival(new Models.ScannedTicket(TicketNumberTextBox.Text, new CurrentSysInfo()),true);
            Close();
        }

        private void TicketDetails_Leave(object sender, EventArgs e)
        {

        }

        private void TicketDetails_Deactivate(object sender, EventArgs e)
        {

        }

        private void MarkAsArrivedButton_Click(object sender, EventArgs e)
        {
            ticketManagerService.UpdateTicketStatusAndNotes(this.ticketNumber.Value, Business.Constants.TicketStatus.Paid, NotesTextBox.Text);
            ticketConfirmationService.ConfirmArrival(new Models.ScannedTicket(TicketNumberTextBox.Text, new CurrentSysInfo()), true);
            Close();
        }
    }
}
