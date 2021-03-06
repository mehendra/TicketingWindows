﻿namespace TicketManager
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
            this.label5 = new System.Windows.Forms.Label();
            this.TableNoTextbox = new System.Windows.Forms.TextBox();
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
            this.TableNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.seachTicketsResultBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SoldByTextBox = new System.Windows.Forms.TextBox();
            this.SoldToTextBox = new System.Windows.Forms.TextBox();
            this.TicketNumberTextBox = new System.Windows.Forms.TextBox();
            this.ScannerTabPage = new System.Windows.Forms.TabPage();
            this.labelLastScannedTable = new System.Windows.Forms.Label();
            this.LabelLastScanned = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ticketCategoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberArrivedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberToArriveDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalNumberOfTicketsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DoorSummaryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SimpleTicketNumberTextBox = new System.Windows.Forms.TextBox();
            this.DataSearchTab = new System.Windows.Forms.TabControl();
            this.ticketCategoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.UIUpdateTimer = new System.Windows.Forms.Timer(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.AdavancedTabSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dropdownValusBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TicketListGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seachTicketsResultBindingSource)).BeginInit();
            this.ScannerTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DoorSummaryBindingSource)).BeginInit();
            this.DataSearchTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ticketCategoryBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // AdavancedTabSearch
            // 
            this.AdavancedTabSearch.Controls.Add(this.label5);
            this.AdavancedTabSearch.Controls.Add(this.TableNoTextbox);
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
            this.AdavancedTabSearch.Click += new System.EventHandler(this.AdavancedTabSearch_Click);
            this.AdavancedTabSearch.Enter += new System.EventHandler(this.AdavancedTabSearch_Enter);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(337, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Table";
            // 
            // TableNoTextbox
            // 
            this.TableNoTextbox.Location = new System.Drawing.Point(389, 50);
            this.TableNoTextbox.Name = "TableNoTextbox";
            this.TableNoTextbox.Size = new System.Drawing.Size(193, 20);
            this.TableNoTextbox.TabIndex = 10;
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
            this.TableNumber});
            this.TicketListGridView.DataSource = this.seachTicketsResultBindingSource;
            this.TicketListGridView.Location = new System.Drawing.Point(5, 111);
            this.TicketListGridView.MultiSelect = false;
            this.TicketListGridView.Name = "TicketListGridView";
            this.TicketListGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
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
            // TableNumber
            // 
            this.TableNumber.DataPropertyName = "TableNumber";
            this.TableNumber.HeaderText = "TableNumber";
            this.TableNumber.Name = "TableNumber";
            // 
            // seachTicketsResultBindingSource
            // 
            this.seachTicketsResultBindingSource.DataSource = typeof(Business.SeachTickets_Result);
            this.seachTicketsResultBindingSource.CurrentChanged += new System.EventHandler(this.seachTicketsResultBindingSource_CurrentChanged);
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
            this.ScannerTabPage.Controls.Add(this.label7);
            this.ScannerTabPage.Controls.Add(this.label6);
            this.ScannerTabPage.Controls.Add(this.labelLastScannedTable);
            this.ScannerTabPage.Controls.Add(this.LabelLastScanned);
            this.ScannerTabPage.Controls.Add(this.dataGridView1);
            this.ScannerTabPage.Controls.Add(this.SimpleTicketNumberTextBox);
            this.ScannerTabPage.Location = new System.Drawing.Point(4, 22);
            this.ScannerTabPage.Margin = new System.Windows.Forms.Padding(2);
            this.ScannerTabPage.Name = "ScannerTabPage";
            this.ScannerTabPage.Padding = new System.Windows.Forms.Padding(2);
            this.ScannerTabPage.Size = new System.Drawing.Size(820, 384);
            this.ScannerTabPage.TabIndex = 0;
            this.ScannerTabPage.Text = "Simple";
            this.ScannerTabPage.UseVisualStyleBackColor = true;
            this.ScannerTabPage.Click += new System.EventHandler(this.ScannerTabPage_Click);
            // 
            // labelLastScannedTable
            // 
            this.labelLastScannedTable.AutoSize = true;
            this.labelLastScannedTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLastScannedTable.Location = new System.Drawing.Point(685, 55);
            this.labelLastScannedTable.Name = "labelLastScannedTable";
            this.labelLastScannedTable.Size = new System.Drawing.Size(15, 20);
            this.labelLastScannedTable.TabIndex = 3;
            this.labelLastScannedTable.Text = "-";
            // 
            // LabelLastScanned
            // 
            this.LabelLastScanned.AutoSize = true;
            this.LabelLastScanned.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.LabelLastScanned.Location = new System.Drawing.Point(685, 25);
            this.LabelLastScanned.Name = "LabelLastScanned";
            this.LabelLastScanned.Size = new System.Drawing.Size(15, 20);
            this.LabelLastScanned.TabIndex = 2;
            this.LabelLastScanned.Text = "-";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ticketCategoryDataGridViewTextBoxColumn,
            this.numberArrivedDataGridViewTextBoxColumn,
            this.numberToArriveDataGridViewTextBoxColumn,
            this.totalNumberOfTicketsDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.DoorSummaryBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(5, 96);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(810, 283);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ticketCategoryDataGridViewTextBoxColumn
            // 
            this.ticketCategoryDataGridViewTextBoxColumn.DataPropertyName = "TicketCategory";
            this.ticketCategoryDataGridViewTextBoxColumn.HeaderText = "TicketCategory";
            this.ticketCategoryDataGridViewTextBoxColumn.Name = "ticketCategoryDataGridViewTextBoxColumn";
            this.ticketCategoryDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // numberArrivedDataGridViewTextBoxColumn
            // 
            this.numberArrivedDataGridViewTextBoxColumn.DataPropertyName = "NumberArrived";
            this.numberArrivedDataGridViewTextBoxColumn.HeaderText = "NumberArrived";
            this.numberArrivedDataGridViewTextBoxColumn.Name = "numberArrivedDataGridViewTextBoxColumn";
            this.numberArrivedDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // numberToArriveDataGridViewTextBoxColumn
            // 
            this.numberToArriveDataGridViewTextBoxColumn.DataPropertyName = "NumberToArrive";
            this.numberToArriveDataGridViewTextBoxColumn.HeaderText = "NumberToArrive";
            this.numberToArriveDataGridViewTextBoxColumn.Name = "numberToArriveDataGridViewTextBoxColumn";
            this.numberToArriveDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // totalNumberOfTicketsDataGridViewTextBoxColumn
            // 
            this.totalNumberOfTicketsDataGridViewTextBoxColumn.DataPropertyName = "TotalNumberOfTickets";
            this.totalNumberOfTicketsDataGridViewTextBoxColumn.HeaderText = "TotalNumberOfTickets";
            this.totalNumberOfTicketsDataGridViewTextBoxColumn.Name = "totalNumberOfTicketsDataGridViewTextBoxColumn";
            this.totalNumberOfTicketsDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // DoorSummaryBindingSource
            // 
            this.DoorSummaryBindingSource.DataSource = typeof(Business.GetAtTheDoorSummary_Result);
            // 
            // SimpleTicketNumberTextBox
            // 
            this.SimpleTicketNumberTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SimpleTicketNumberTextBox.Location = new System.Drawing.Point(219, 25);
            this.SimpleTicketNumberTextBox.Margin = new System.Windows.Forms.Padding(2);
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
            // UIUpdateTimer
            // 
            this.UIUpdateTimer.Interval = 10000;
            this.UIUpdateTimer.Tick += new System.EventHandler(this.UIUpdateTimer_Tick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(594, 55);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 20);
            this.label6.TabIndex = 4;
            this.label6.Text = "Table No.";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(594, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 20);
            this.label7.TabIndex = 5;
            this.label7.Text = "Ticket No.";
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DoorSummaryBindingSource)).EndInit();
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
        private System.Windows.Forms.Timer UIUpdateTimer;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TableNoTextbox;
        private System.Windows.Forms.DataGridViewTextBoxColumn ticketIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ticketNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn searchCategoryDescriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soldToDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn arrivedAtDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn agentNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TableNumber;
        private System.Windows.Forms.BindingSource DoorSummaryBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn ticketCategoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberArrivedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberToArriveDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalNumberOfTicketsDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label LabelLastScanned;
        private System.Windows.Forms.Label labelLastScannedTable;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
    }
}