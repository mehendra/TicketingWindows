namespace TicketManager
{
    partial class SearchTicketsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.AdavancedTabSearch = new System.Windows.Forms.TabPage();
            this.ScannerTabPage = new System.Windows.Forms.TabPage();
            this.SimpleTicketNumberTextBox = new System.Windows.Forms.TextBox();
            this.DataSearchTab = new System.Windows.Forms.TabControl();
            this.ScannerTimer = new System.Windows.Forms.Timer(this.components);
            this.ScannerTabPage.SuspendLayout();
            this.DataSearchTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // AdavancedTabSearch
            // 
            this.AdavancedTabSearch.Location = new System.Drawing.Point(4, 22);
            this.AdavancedTabSearch.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.AdavancedTabSearch.Name = "AdavancedTabSearch";
            this.AdavancedTabSearch.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.AdavancedTabSearch.Size = new System.Drawing.Size(539, 160);
            this.AdavancedTabSearch.TabIndex = 1;
            this.AdavancedTabSearch.Text = "Advanced";
            this.AdavancedTabSearch.UseVisualStyleBackColor = true;
            // 
            // ScannerTabPage
            // 
            this.ScannerTabPage.Controls.Add(this.SimpleTicketNumberTextBox);
            this.ScannerTabPage.Location = new System.Drawing.Point(4, 22);
            this.ScannerTabPage.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ScannerTabPage.Name = "ScannerTabPage";
            this.ScannerTabPage.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ScannerTabPage.Size = new System.Drawing.Size(539, 160);
            this.ScannerTabPage.TabIndex = 0;
            this.ScannerTabPage.Text = "Simple";
            this.ScannerTabPage.UseVisualStyleBackColor = true;
            // 
            // SimpleTicketNumberTextBox
            // 
            this.SimpleTicketNumberTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SimpleTicketNumberTextBox.Location = new System.Drawing.Point(71, 49);
            this.SimpleTicketNumberTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SimpleTicketNumberTextBox.Name = "SimpleTicketNumberTextBox";
            this.SimpleTicketNumberTextBox.Size = new System.Drawing.Size(370, 50);
            this.SimpleTicketNumberTextBox.TabIndex = 0;
            this.SimpleTicketNumberTextBox.TextChanged += new System.EventHandler(this.SimpleTicketNumberTextBox_TextChanged);
            // 
            // DataSearchTab
            // 
            this.DataSearchTab.Controls.Add(this.ScannerTabPage);
            this.DataSearchTab.Controls.Add(this.AdavancedTabSearch);
            this.DataSearchTab.Location = new System.Drawing.Point(9, 10);
            this.DataSearchTab.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DataSearchTab.Name = "DataSearchTab";
            this.DataSearchTab.SelectedIndex = 0;
            this.DataSearchTab.Size = new System.Drawing.Size(547, 186);
            this.DataSearchTab.TabIndex = 0;
            // 
            // ScannerTimer
            // 
            this.ScannerTimer.Interval = 500;
            this.ScannerTimer.Tick += new System.EventHandler(this.ScannerTimer_Tick);
            // 
            // SearchTicketsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 206);
            this.Controls.Add(this.DataSearchTab);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "SearchTicketsForm";
            this.Text = "Search Tickets";
            this.ScannerTabPage.ResumeLayout(false);
            this.ScannerTabPage.PerformLayout();
            this.DataSearchTab.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage AdavancedTabSearch;
        private System.Windows.Forms.TabPage ScannerTabPage;
        private System.Windows.Forms.TextBox SimpleTicketNumberTextBox;
        private System.Windows.Forms.TabControl DataSearchTab;
        private System.Windows.Forms.Timer ScannerTimer;
    }
}