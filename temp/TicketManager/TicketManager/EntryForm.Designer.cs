namespace TicketManager
{
    partial class TickerManagerForm
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
            this.AdministratorModeButton = new System.Windows.Forms.Button();
            this.ScanningModeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AdministratorModeButton
            // 
            this.AdministratorModeButton.Location = new System.Drawing.Point(9, 10);
            this.AdministratorModeButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.AdministratorModeButton.Name = "AdministratorModeButton";
            this.AdministratorModeButton.Size = new System.Drawing.Size(140, 71);
            this.AdministratorModeButton.TabIndex = 0;
            this.AdministratorModeButton.Text = "Admin Mode";
            this.AdministratorModeButton.UseVisualStyleBackColor = true;
            this.AdministratorModeButton.Click += new System.EventHandler(this.AdministratorModeButton_Click);
            // 
            // ScanningModeButton
            // 
            this.ScanningModeButton.Location = new System.Drawing.Point(9, 85);
            this.ScanningModeButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ScanningModeButton.Name = "ScanningModeButton";
            this.ScanningModeButton.Size = new System.Drawing.Size(140, 75);
            this.ScanningModeButton.TabIndex = 1;
            this.ScanningModeButton.Text = "Scanning Mode";
            this.ScanningModeButton.UseVisualStyleBackColor = true;
            this.ScanningModeButton.Click += new System.EventHandler(this.ScanningModeButton_Click);
            // 
            // TickerManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(158, 174);
            this.Controls.Add(this.ScanningModeButton);
            this.Controls.Add(this.AdministratorModeButton);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "TickerManagerForm";
            this.Text = "Ticket Manager";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AdministratorModeButton;
        private System.Windows.Forms.Button ScanningModeButton;
    }
}

