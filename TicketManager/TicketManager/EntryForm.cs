using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicketManager
{
    public partial class TickerManagerForm : Form
    {
        public TickerManagerForm()
        {
            InitializeComponent();
        }

        private void ScanningModeButton_Click(object sender, EventArgs e)
        {
            var frm = new SearchTicketsForm();
            frm.Show(this);
        }

        private void AdministratorModeButton_Click(object sender, EventArgs e)
        {

        }
    }
}
