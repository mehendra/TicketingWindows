using Business;
using Models;
using Models.Services;
using System;
using System.Drawing;
using System.Windows.Forms;
using Utilities;

namespace TicketManager
{
    public partial class SearchTicketsForm : Form
    {        

        ILogger logger = new Logger();
        TicketConfirmerService ticketService;

        private TicketConfirmerService GetTicketService()
        {
            if (ticketService == null)
            {
                ticketService = new TicketConfirmerService(logger);
            }
            return ticketService;
        }

        public bool ScannedTextBoxInError { get; set; }

        ISystemInformation currentSystemInformation;
        int numberOfIterationForScanner = 0;
        public SearchTicketsForm()
        {
            logger.logMessage("Form Loading", LogLevel.debug);
            InitializeComponent();
            ScannerTabPage.BackColor = Color.LightGreen;
            this.ActiveControl = SimpleTicketNumberTextBox;
            currentSystemInformation = new CurrentSysInfo();
            logger.logMessage("Ready for action", LogLevel.debug);
        }

        private void SimpleTicketNumberTextBox_TextChanged(object sender, EventArgs e)
        {
            ScannerTimer.Enabled = true;
            ScannerTabPage.BackColor = Color.Yellow;
        }

        private void ScannerTimer_Tick(object sender, EventArgs e)
        {
            var currentText = SimpleTicketNumberTextBox.Text.ToUpper();
            numberOfIterationForScanner++;
            if (currentText.Length == 14)
            {
                logger.logMessage(string.Format("Ticket {0} scanned", currentText), LogLevel.message);
                var scannedTicket = new ScannedTicket(currentText, currentSystemInformation);
                var ticketMarked = new Business.TicketConfirmerService(logger).ConfirmArrival(scannedTicket);
                if (ticketMarked)
                {
                    Console.WriteLine(currentText);
                    SimpleTicketNumberTextBox.Clear();
                    ScannerTimer.Enabled = false;
                    ScannerTabPage.BackColor = Color.LightGreen;
                    ScannedTextBoxInError = false;
                }
                else
                {
                    ScannerTabPage.BackColor = Color.Red;
                    ScannerTimer.Enabled = false;
                    ScannedTextBoxInError = true;
                    MessageBox.Show("Failed to mark the ticket as scanned.");
                }

            }
            else if (numberOfIterationForScanner < 14)
            {
                logger.logMessage(string.Format("Unable to find ticket {0}", currentText), LogLevel.debug);
                Console.WriteLine("Please wait");
            }
            else
            {
                logger.logMessage(string.Format("Ticket {0} failed due to format error", currentText), LogLevel.error);
                ScannerTabPage.BackColor = Color.Red;
                ScannerTimer.Enabled = false;
                if (!ScannedTextBoxInError)
                {
                    MessageBox.Show(string.Format("Scanned text {0} should be exactly 8 characters long", currentText));
                }                
                ScannedTextBoxInError = true;
            }

        }
    }
}
