using Business;
using Models;
using Models.Services;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Utilities;

namespace TicketManager
{
    public partial class SearchTicketsForm : Form
    {        

        ILogger logger = new Logger();
        TicketConfirmerService ticketConfirmationService;
        TicketManagerService ticketManagerService;
        StaticDataService staticDataService;

        private TicketManagerService GetTicketManagerService()
        {
            if (ticketManagerService == null)
            {
                ticketManagerService = new TicketManagerService();
            }
            return ticketManagerService;
        }

        private TicketConfirmerService GetTicketConfirmationService()
        {
            if (ticketConfirmationService == null)
            {
                ticketConfirmationService = new TicketConfirmerService(logger);
            }
            return ticketConfirmationService;
        }

        private StaticDataService GetStaticDataService()
        {
            if (staticDataService == null)
            {
                staticDataService = new StaticDataService();
            }
            return staticDataService;
        }


        //public bool ScannedTextBoxInError { get; set; }

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
            SimpleTicketNumberTextBox.KeyDown += new KeyEventHandler(tb_KeyDown);
        }

        private void tb_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ScannerTabPage.BackColor = Color.Yellow;
                UpdateTicketStatus(((TextBox)sender).Text);
            }
        }

        private void UpdateTicketStatus(string ticketNumber)
        {

                logger.logMessage(string.Format("Ticket {0} scanned", ticketNumber), LogLevel.message);
                var scannedTicket = new ScannedTicket(ticketNumber, currentSystemInformation);
                var ticketMarked = new Business.TicketConfirmerService(logger).ConfirmArrival(scannedTicket);
                var userMessage = new StringBuilder();
                if (ticketMarked.StatusOfScan == TicketScannedStatus.Ok)
                {
                    Console.WriteLine(ticketNumber);

                    if (ticketMarked.Zone == Business.Constants.ZonedCategories.ZoneBLeft || ticketMarked.Zone == Business.Constants.ZonedCategories.ZoneBRight)
                {
                    MessageBox.Show(string.Format(@"This is a {0} Ticket", ticketMarked.Zone));
                    }
                    if (ticketMarked.TicketNotPaid)
                    {
                        var ticketDetailsForm = new TicketDetails(ticketMarked.TicketId, "This ticket is not paid for, Please collect money");
                        ticketDetailsForm.FormClosed += new FormClosedEventHandler(ob_FormClosed);
                        ticketDetailsForm.Show(this);
                    }
                    SimpleTicketNumberTextBox.Clear();

                    ScannerTabPage.BackColor = Color.LightGreen;
                    //ScannedTextBoxInError = false;
                }
                else
                {
                    if (ticketMarked.StatusOfScan == TicketScannedStatus.TicketAlreadyScanned)
                    {
                        SimpleTicketNumberTextBox.SelectAll();
                        ScannerTabPage.BackColor = Color.Red;
                        //ScannedTextBoxInError = true;
                        MessageBox.Show(ticketMarked.TicketScannedMessage);
                    }
                    else
                    {
                        SimpleTicketNumberTextBox.SelectAll();
                        ScannerTabPage.BackColor = Color.Red;
                        //ScannedTextBoxInError = true;
                        MessageBox.Show("Ticket not found.");
                    }
                }
            }

        private void DataSearchTab_Selected(object sender, TabControlEventArgs e)
        {
            if (e.TabPage.Name == "ScannerTabPage")
            {
                SimpleTicketNumberTextBox.Focus();
                SimpleTicketNumberTextBox.Select();
            }            
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            SearchTickets();
        }

        private void AdavancedTabSearch_Enter(object sender, EventArgs e)
        {
            //Load the drop down values
            var cats = GetStaticDataService().GetTicketCategory();
            cats.Add("", "");
            CategoryCombo.DataSource =cats.Keys.Select(a => new DropdownValus { DropdownValue = a, DropdownText = cats[a] }).ToList();
            CategoryCombo.Text = "";
        }

        private void TicketListGridView_SelectionChanged(object sender, EventArgs e)
        {

        }

        private void SearchTickets()
        {
            string categoryComboValue = null;
            if (CategoryCombo.SelectedValue != null && !string.IsNullOrWhiteSpace(CategoryCombo.SelectedValue.ToString()))
            {
                categoryComboValue = CategoryCombo.SelectedValue.ToString();
            }

            var ticketSearchParameter = new TicketSearchParams
            {
                TicketNumber = TicketNumberTextBox.Text,
                Category = categoryComboValue,
                AgentCode = SoldByTextBox.Text,
                SoldTo = SoldToTextBox.Text,
                PagingStartIndex = 1,
                RecordsPerPage = 100,
            };
            int tableNo = 0;
            if (!string.IsNullOrEmpty(TableNoTextbox.Text))
            {
                if (!int.TryParse(TableNoTextbox.Text, out tableNo))
                {
                    MessageBox.Show("Table No has to be number");
                    return;
                }
                else
                {
                    ticketSearchParameter.TableNo = tableNo;
                }
            }
            
            
            
            var searchedResult = GetTicketManagerService().SeachTicketsWithWildCards(ticketSearchParameter);
            TicketListGridView.DataSource = searchedResult.Results;
        }

        private void ob_FormClosed(object sender, FormClosedEventArgs e)
        {

            //SearchTickets();
        }


        private void TicketListGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = TicketListGridView.CurrentRow;
            if (row != null)
            {
                var id = (int)(row.Cells[0].Value);
                var ticketDetailsForm = new TicketDetails(id);
                ticketDetailsForm.FormClosed += new FormClosedEventHandler(ob_FormClosed);
                ticketDetailsForm.Show(this);

            }
        }



        private void ScannerTabPage_Click(object sender, EventArgs e)
        {
        }

        private void UIUpdateTimer_Tick(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void seachTicketsResultBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
