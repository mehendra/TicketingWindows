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
            this.label4 = new System.Windows.Forms.Label();
            this.CategoryCombo = new System.Windows.Forms.ComboBox();
            this.dropdownValusBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SearchButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TicketListGridView = new System.Windows.Forms.DataGridView();
            this.ticketIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ticketNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.searchCategoryDescriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soldToDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.arrivedAtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.agentNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.seachTicketsResultBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SoldByTextBox = new System.Windows.Forms.TextBox();
            this.SoldToTextBox = new System.Windows.Forms.TextBox();
            this.TicketNumberTextBox = new System.Windows.Forms.TextBox();
            this.ScannerTabPage = new System.Windows.Forms.TabPage();
            this.SimpleTicketNumberTextBox = new System.Windows.Forms.TextBox();
            this.DataSearchTab = new System.Windows.Forms.TabControl();
            this.ticketCategoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.AdavancedTabSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dropdownValusBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TicketListGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seachTicketsResultBindingSource)).BeginInit();
            this.ScannerTabPage.SuspendLayout();
            this.DataSearchTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ticketCategoryBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // AdavancedTabSearch
            // 
            this.AdavancedTabSearch.Controls.Add(this.label4);
            this.AdavancedTabSearch.Controls.Add(this.CategoryCombo);
            this.AdavancedTabSearch.Controls.Add(this.SearchButton);
            this.AdavancedTabSearch.Controls.Add(this.label3);
            this.AdavancedTabSearch.Controls.Add(this.label2);
            this.AdavancedTabSearch.Controls.Add(this.label1);
            this.AdavancedTabSearch.Controls.Add(this.TicketListGridView);
            this.AdavancedTabSearch.Controls.Add(this.SoldByTextBox);
            this.AdavancedTabSearch.Controls.Add(this.SoldToTextBox);
            this.AdavancedTabSearch.Controls.Add(this.TicketNumberTextBox);
            this.AdavancedTabSearch.Location = new System.Drawing.Point(4, 22);
            this.AdavancedTabSearch.Margin = new System.Windows.Forms.Padding(2);
            this.AdavancedTabSearch.Name = "AdavancedTabSearch";
            this.AdavancedTabSearch.Padding = new System.Windows.Forms.Padding(2);
            this.AdavancedTabSearch.Size = new System.Drawing.Size(820, 384);
            this.AdavancedTabSearch.TabIndex = 1;
            this.AdavancedTabSearch.Text = "Advanced";
            this.AdavancedTabSearch.UseVisualStyleBackColor = true;
            this.AdavancedTabSearch.Enter += new System.EventHandler(this.AdavancedTabSearch_Enter);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(334, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Category";
            // 
            // CategoryCombo
            // 
            this.CategoryCombo.DataSource = this.dropdownValusBindingSource;
            this.CategoryCombo.DisplayMember = "DropdownText";
            this.CategoryCombo.FormattingEnabled = true;
            this.CategoryCombo.Location = new System.Drawing.Point(389, 5);
            this.CategoryCombo.Name = "CategoryCombo";
            this.CategoryCombo.Size = new System.Drawing.Size(193, 21);
            this.CategoryCombo.TabIndex = 8;
            this.CategoryCombo.ValueMember = "DropdownValue";
            // 
            // dropdownValusBindingSource
            // 
            this.dropdownValusBindingSource.DataSource = typeof(TicketManager.DropdownValus);
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(657, 6);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(75, 98);
            this.SearchButton.TabIndex = 7;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Sold By:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Sold To:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ticket Number:";
            // 
            // TicketListGridView
            // 
            this.TicketListGridView.AutoGenerateColumns = false;
            this.TicketListGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TicketListGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ticketIdDataGridViewTextBoxColumn,
            this.ticketNumberDataGridViewTextBoxColumn,
            this.searchCategoryDescriptionDataGridViewTextBoxColumn,
            this.soldToDataGridViewTextBoxColumn,
            this.arrivedAtDataGridViewTextBoxColumn,
            this.agentNameDataGridViewTextBoxColumn,
            this.zoneDataGridViewTextBoxColumn});
            this.TicketListGridView.DataSource = this.seachTicketsResultBindingSource;
            this.TicketListGridView.Location = new System.Drawing.Point(5, 111);
            this.TicketListGridView.Name = "TicketListGridView";
            this.TicketListGridView.Size = new System.Drawing.Size(810, 268);
            this.TicketListGridView.TabIndex = 3;
            this.TicketListGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TicketListGridView_CellContentClick);
            // 
            // ticketIdDataGridViewTextBoxColumn
            // 
            this.ticketIdDataGridViewTextBoxColumn.DataPropertyName = "TicketId";
            this.ticketIdDataGridViewTextBoxColumn.HeaderText = "Id";
            this.ticketIdDataGridViewTextBoxColumn.Name = "ticketIdDataGridViewTextBoxColumn";
            this.ticketIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.ticketIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // ticketNumberDataGridViewTextBoxColumn
            // 
            this.ticketNumberDataGridViewTextBoxColumn.DataPropertyName = "TicketNumber";
            this.ticketNumberDataGridViewTextBoxColumn.HeaderText = "Ticket Number";
            this.ticketNumberDataGridViewTextBoxColumn.Name = "ticketNumberDataGridViewTextBoxColumn";
            this.ticketNumberDataGridViewTextBoxColumn.ReadOnly = true;
            this.ticketNumberDataGridViewTextBoxColumn.Width = 150;
            // 
            // searchCategoryDescriptionDataGridViewTextBoxColumn
            // 
            this.searchCategoryDescriptionDataGridViewTextBoxColumn.DataPropertyName = "Category";
            this.searchCategoryDescriptionDataGridViewTextBoxColumn.HeaderText = "Categoty";
            this.searchCategoryDescriptionDataGridViewTextBoxColumn.Name = "searchCategoryDescriptionDataGridViewTextBoxColumn";
            this.searchCategoryDescriptionDataGridViewTextBoxColumn.ReadOnly = true;
            this.searchCategoryDescriptionDataGridViewTextBoxColumn.Width = 150;
            // 
            // soldToDataGridViewTextBoxColumn
            // 
            this.soldToDataGridViewTextBoxColumn.DataPropertyName = "SoldTo";
            this.soldToDataGridViewTextBoxColumn.HeaderText = "SoldTo";
            this.soldToDataGridViewTextBoxColumn.Name = "soldToDataGridViewTextBoxColumn";
            this.soldToDataGridViewTextBoxColumn.ReadOnly = true;
            this.soldToDataGridViewTextBoxColumn.Width = 180;
            // 
            // arrivedAtDataGridViewTextBoxColumn
            // 
            this.arrivedAtDataGridViewTextBoxColumn.DataPropertyName = "ArrivedAt";
            this.arrivedAtDataGridViewTextBoxColumn.HeaderText = "ArrivedAt";
            this.arrivedAtDataGridViewTextBoxColumn.Name = "arrivedAtDataGridViewTextBoxColumn";
            this.arrivedAtDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // agentNameDataGridViewTextBoxColumn
            // 
            this.agentNameDataGridViewTextBoxColumn.DataPropertyName = "AgentName";
            this.agentNameDataGridViewTextBoxColumn.HeaderText = "Agent";
            this.agentNameDataGridViewTextBoxColumn.Name = "agentNameDataGridViewTextBoxColumn";
            this.agentNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.agentNameDataGridViewTextBoxColumn.Width = 70;
            // 
            // zoneDataGridViewTextBoxColumn
            // 
            this.zoneDataGridViewTextBoxColumn.DataPropertyName = "Zone";
            this.zoneDataGridViewTextBoxColumn.HeaderText = "Zone";
            this.zoneDataGridViewTextBoxColumn.Name = "zoneDataGridViewTextBoxColumn";
            this.zoneDataGridViewTextBoxColumn.ReadOnly = true;
            this.zoneDataGridViewTextBoxColumn.Width = 70;
            // 
            // seachTicketsResultBindingSource
            // 
            this.seachTicketsResultBindingSource.DataSource = typeof(Business.SeachTickets_Result);
            // 
            // SoldByTextBox
            // 
            this.SoldByTextBox.Location = new System.Drawing.Point(93, 85);
            this.SoldByTextBox.Name = "SoldByTextBox";
            this.SoldByTextBox.Size = new System.Drawing.Size(199, 20);
            this.SoldByTextBox.TabIndex = 2;
            // 
            // SoldToTextBox
            // 
            this.SoldToTextBox.Location = new System.Drawing.Point(93, 47);
            this.SoldToTextBox.Name = "SoldToTextBox";
            this.SoldToTextBox.Size = new System.Drawing.Size(199, 20);
            this.SoldToTextBox.TabIndex = 1;
            // 
            // TicketNumberTextBox
            // 
            this.TicketNumberTextBox.Location = new System.Drawing.Point(93, 6);
            this.TicketNumberTextBox.Name = "TicketNumberTextBox";
            this.TicketNumberTextBox.Size = new System.Drawing.Size(199, 20);
            this.TicketNumberTextBox.TabIndex = 0;
            // 
            // ScannerTabPage
            // 
            this.ScannerTabPage.Controls.Add(this.SimpleTicketNumberTextBox);
            this.ScannerTabPage.Location = new System.Drawing.Point(4, 22);
            this.ScannerTabPage.Margin = new System.Windows.Forms.Padding(2);
            this.ScannerTabPage.Name = "ScannerTabPage";
            this.ScannerTabPage.Padding = new System.Windows.Forms.Padding(2);
            this.ScannerTabPage.Size = new System.Drawing.Size(780, 384);
            this.ScannerTabPage.TabIndex = 0;
            this.ScannerTabPage.Text = "Simple";
            this.ScannerTabPage.UseVisualStyleBackColor = true;
            this.ScannerTabPage.Click += new System.EventHandler(this.ScannerTabPage_Click);
            // 
            // SimpleTicketNumberTextBox
            // 
            this.SimpleTicketNumberTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SimpleTicketNumberTextBox.Location = new System.Drawing.Point(193, 151);
            this.SimpleTicketNumberTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.SimpleTicketNumberTextBox.Name = "SimpleTicketNumberTextBox";
            this.SimpleTicketNumberTextBox.Size = new System.Drawing.Size(370, 50);
            this.SimpleTicketNumberTextBox.TabIndex = 0;
            // 
            // DataSearchTab
            // 
            this.DataSearchTab.Controls.Add(this.ScannerTabPage);
            this.DataSearchTab.Controls.Add(this.AdavancedTabSearch);
            this.DataSearchTab.Location = new System.Drawing.Point(9, 10);
            this.DataSearchTab.Margin = new System.Windows.Forms.Padding(2);
            this.DataSearchTab.Name = "DataSearchTab";
            this.DataSearchTab.SelectedIndex = 0;
            this.DataSearchTab.Size = new System.Drawing.Size(828, 410);
            this.DataSearchTab.TabIndex = 0;
            this.DataSearchTab.Selected += new System.Windows.Forms.TabControlEventHandler(this.DataSearchTab_Selected);
            // 
            // ticketCategoryBindingSource
            // 
            this.ticketCategoryBindingSource.DataSource = typeof(Business.TicketCategory);
            // 
            // SearchTicketsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 431);
            this.Controls.Add(this.DataSearchTab);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "SearchTicketsForm";
            this.Text = "Search Tickets";
            this.AdavancedTabSearch.ResumeLayout(false);
            this.AdavancedTabSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dropdownValusBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TicketListGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seachTicketsResultBindingSource)).EndInit();
            this.ScannerTabPage.ResumeLayout(false);
            this.ScannerTabPage.PerformLayout();
            this.DataSearchTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ticketCategoryBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage AdavancedTabSearch;
        private System.Windows.Forms.TabPage ScannerTabPage;
        private System.Windows.Forms.TextBox SimpleTicketNumberTextBox;
        private System.Windows.Forms.TabControl DataSearchTab;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView TicketListGridView;
        private System.Windows.Forms.TextBox SoldByTextBox;
        private System.Windows.Forms.TextBox SoldToTextBox;
        private System.Windows.Forms.TextBox TicketNumberTextBox;
        private System.Windows.Forms.BindingSource seachTicketsResultBindingSource;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox CategoryCombo;
        private System.Windows.Forms.BindingSource ticketCategoryBindingSource;
        private System.Windows.Forms.BindingSource dropdownValusBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn ticketIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ticketNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn searchCategoryDescriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soldToDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn arrivedAtDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn agentNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn zoneDataGridViewTextBoxColumn;
    }
}