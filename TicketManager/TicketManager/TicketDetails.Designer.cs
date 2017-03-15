namespace TicketManager
{
    partial class TicketDetails
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.TicketNumberTextBox = new System.Windows.Forms.TextBox();
            this.AgentTextBox = new System.Windows.Forms.TextBox();
            this.TicketCategoryTextBox = new System.Windows.Forms.TextBox();
            this.TicketStatusTextBox = new System.Windows.Forms.TextBox();
            this.ZoneTextBox = new System.Windows.Forms.TextBox();
            this.SoldToTextBox = new System.Windows.Forms.TextBox();
            this.NotesTextBox = new System.Windows.Forms.TextBox();
            this.MarkedPaidButton = new System.Windows.Forms.Button();
            this.IncompletePaymentButton = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.ScannedTextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.ScannedByTextBox = new System.Windows.Forms.TextBox();
            this.MarkAsArrivedButton = new System.Windows.Forms.Button();
            this.MessageLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ticket Number";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Agent";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ticket Category";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ticket Status";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 174);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Zone";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 198);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Sold To";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 238);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Notes";
            // 
            // TicketNumberTextBox
            // 
            this.TicketNumberTextBox.Location = new System.Drawing.Point(97, 58);
            this.TicketNumberTextBox.Name = "TicketNumberTextBox";
            this.TicketNumberTextBox.ReadOnly = true;
            this.TicketNumberTextBox.Size = new System.Drawing.Size(171, 20);
            this.TicketNumberTextBox.TabIndex = 7;
            // 
            // AgentTextBox
            // 
            this.AgentTextBox.Location = new System.Drawing.Point(97, 84);
            this.AgentTextBox.Name = "AgentTextBox";
            this.AgentTextBox.ReadOnly = true;
            this.AgentTextBox.Size = new System.Drawing.Size(254, 20);
            this.AgentTextBox.TabIndex = 8;
            // 
            // TicketCategoryTextBox
            // 
            this.TicketCategoryTextBox.Location = new System.Drawing.Point(97, 110);
            this.TicketCategoryTextBox.Name = "TicketCategoryTextBox";
            this.TicketCategoryTextBox.ReadOnly = true;
            this.TicketCategoryTextBox.Size = new System.Drawing.Size(254, 20);
            this.TicketCategoryTextBox.TabIndex = 9;
            // 
            // TicketStatusTextBox
            // 
            this.TicketStatusTextBox.Location = new System.Drawing.Point(97, 144);
            this.TicketStatusTextBox.Name = "TicketStatusTextBox";
            this.TicketStatusTextBox.ReadOnly = true;
            this.TicketStatusTextBox.Size = new System.Drawing.Size(254, 20);
            this.TicketStatusTextBox.TabIndex = 10;
            // 
            // ZoneTextBox
            // 
            this.ZoneTextBox.Location = new System.Drawing.Point(97, 174);
            this.ZoneTextBox.Name = "ZoneTextBox";
            this.ZoneTextBox.ReadOnly = true;
            this.ZoneTextBox.Size = new System.Drawing.Size(254, 20);
            this.ZoneTextBox.TabIndex = 11;
            // 
            // SoldToTextBox
            // 
            this.SoldToTextBox.Location = new System.Drawing.Point(97, 200);
            this.SoldToTextBox.Name = "SoldToTextBox";
            this.SoldToTextBox.ReadOnly = true;
            this.SoldToTextBox.Size = new System.Drawing.Size(254, 20);
            this.SoldToTextBox.TabIndex = 12;
            // 
            // NotesTextBox
            // 
            this.NotesTextBox.Location = new System.Drawing.Point(97, 231);
            this.NotesTextBox.Multiline = true;
            this.NotesTextBox.Name = "NotesTextBox";
            this.NotesTextBox.Size = new System.Drawing.Size(254, 91);
            this.NotesTextBox.TabIndex = 13;
            // 
            // MarkedPaidButton
            // 
            this.MarkedPaidButton.Location = new System.Drawing.Point(357, 54);
            this.MarkedPaidButton.Name = "MarkedPaidButton";
            this.MarkedPaidButton.Size = new System.Drawing.Size(130, 41);
            this.MarkedPaidButton.TabIndex = 14;
            this.MarkedPaidButton.Text = "Marked As Paid";
            this.MarkedPaidButton.UseVisualStyleBackColor = true;
            this.MarkedPaidButton.Click += new System.EventHandler(this.MarkedPaidButton_Click);
            // 
            // IncompletePaymentButton
            // 
            this.IncompletePaymentButton.Location = new System.Drawing.Point(357, 101);
            this.IncompletePaymentButton.Name = "IncompletePaymentButton";
            this.IncompletePaymentButton.Size = new System.Drawing.Size(130, 41);
            this.IncompletePaymentButton.TabIndex = 15;
            this.IncompletePaymentButton.Text = "Incomplete Payment";
            this.IncompletePaymentButton.UseVisualStyleBackColor = true;
            this.IncompletePaymentButton.Click += new System.EventHandler(this.IncompletePaymentButton_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(354, 196);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Scanned At";
            // 
            // ScannedTextBox
            // 
            this.ScannedTextBox.Location = new System.Drawing.Point(357, 212);
            this.ScannedTextBox.Name = "ScannedTextBox";
            this.ScannedTextBox.ReadOnly = true;
            this.ScannedTextBox.Size = new System.Drawing.Size(216, 20);
            this.ScannedTextBox.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(357, 251);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Scanned By";
            // 
            // ScannedByTextBox
            // 
            this.ScannedByTextBox.Location = new System.Drawing.Point(360, 268);
            this.ScannedByTextBox.Name = "ScannedByTextBox";
            this.ScannedByTextBox.ReadOnly = true;
            this.ScannedByTextBox.Size = new System.Drawing.Size(213, 20);
            this.ScannedByTextBox.TabIndex = 19;
            // 
            // MarkAsArrivedButton
            // 
            this.MarkAsArrivedButton.Location = new System.Drawing.Point(357, 149);
            this.MarkAsArrivedButton.Name = "MarkAsArrivedButton";
            this.MarkAsArrivedButton.Size = new System.Drawing.Size(130, 38);
            this.MarkAsArrivedButton.TabIndex = 20;
            this.MarkAsArrivedButton.Text = "Arrived";
            this.MarkAsArrivedButton.UseVisualStyleBackColor = true;
            this.MarkAsArrivedButton.Click += new System.EventHandler(this.MarkAsArrivedButton_Click);
            // 
            // MessageLabel
            // 
            this.MessageLabel.AutoSize = true;
            this.MessageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MessageLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.MessageLabel.Location = new System.Drawing.Point(13, 13);
            this.MessageLabel.Name = "MessageLabel";
            this.MessageLabel.Size = new System.Drawing.Size(0, 13);
            this.MessageLabel.TabIndex = 21;
            // 
            // TicketDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 333);
            this.Controls.Add(this.MessageLabel);
            this.Controls.Add(this.MarkAsArrivedButton);
            this.Controls.Add(this.ScannedByTextBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.ScannedTextBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.IncompletePaymentButton);
            this.Controls.Add(this.MarkedPaidButton);
            this.Controls.Add(this.NotesTextBox);
            this.Controls.Add(this.SoldToTextBox);
            this.Controls.Add(this.ZoneTextBox);
            this.Controls.Add(this.TicketStatusTextBox);
            this.Controls.Add(this.TicketCategoryTextBox);
            this.Controls.Add(this.AgentTextBox);
            this.Controls.Add(this.TicketNumberTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "TicketDetails";
            this.Text = "BNS2016KID17005";
            this.Deactivate += new System.EventHandler(this.TicketDetails_Deactivate);
            this.Load += new System.EventHandler(this.TicketDetails_Load);
            this.Leave += new System.EventHandler(this.TicketDetails_Leave);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TicketNumberTextBox;
        private System.Windows.Forms.TextBox AgentTextBox;
        private System.Windows.Forms.TextBox TicketCategoryTextBox;
        private System.Windows.Forms.TextBox TicketStatusTextBox;
        private System.Windows.Forms.TextBox ZoneTextBox;
        private System.Windows.Forms.TextBox SoldToTextBox;
        private System.Windows.Forms.TextBox NotesTextBox;
        private System.Windows.Forms.Button MarkedPaidButton;
        private System.Windows.Forms.Button IncompletePaymentButton;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox ScannedTextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox ScannedByTextBox;
        private System.Windows.Forms.Button MarkAsArrivedButton;
        private System.Windows.Forms.Label MessageLabel;
    }
}