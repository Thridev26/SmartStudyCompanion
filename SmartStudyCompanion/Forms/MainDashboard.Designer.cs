
namespace SmartStudyCompanion
{
    partial class MainDashboard
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
            this.TopPanel = new System.Windows.Forms.Panel();
            this.TopLabel = new System.Windows.Forms.Label();
            this.SidePanel = new System.Windows.Forms.Panel();
            this.Settings = new System.Windows.Forms.Button();
            this.Reports = new System.Windows.Forms.Button();
            this.Tasks = new System.Windows.Forms.Button();
            this.StartTimer = new System.Windows.Forms.Button();
            this.Dashboard = new System.Windows.Forms.Button();
            this.MainContentPanel = new System.Windows.Forms.Panel();
            this.WelcomeLabel = new System.Windows.Forms.Label();
            this.SessionHistory = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.TopPanel.SuspendLayout();
            this.SidePanel.SuspendLayout();
            this.MainContentPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // TopPanel
            // 
            this.TopPanel.BackColor = System.Drawing.Color.SteelBlue;
            this.TopPanel.Controls.Add(this.TopLabel);
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(1000, 80);
            this.TopPanel.TabIndex = 0;
            // 
            // TopLabel
            // 
            this.TopLabel.AutoSize = true;
            this.TopLabel.BackColor = System.Drawing.Color.Transparent;
            this.TopLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TopLabel.Location = new System.Drawing.Point(312, 9);
            this.TopLabel.Name = "TopLabel";
            this.TopLabel.Size = new System.Drawing.Size(431, 48);
            this.TopLabel.TabIndex = 0;
            this.TopLabel.Text = "Smart Study Companion";
            this.TopLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SidePanel
            // 
            this.SidePanel.BackColor = System.Drawing.Color.LightGray;
            this.SidePanel.Controls.Add(this.button1);
            this.SidePanel.Controls.Add(this.SessionHistory);
            this.SidePanel.Controls.Add(this.Settings);
            this.SidePanel.Controls.Add(this.Reports);
            this.SidePanel.Controls.Add(this.Tasks);
            this.SidePanel.Controls.Add(this.StartTimer);
            this.SidePanel.Controls.Add(this.Dashboard);
            this.SidePanel.Location = new System.Drawing.Point(0, 86);
            this.SidePanel.Name = "SidePanel";
            this.SidePanel.Size = new System.Drawing.Size(200, 616);
            this.SidePanel.TabIndex = 1;
            // 
            // Settings
            // 
            this.Settings.BackColor = System.Drawing.Color.Gainsboro;
            this.Settings.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Settings.Location = new System.Drawing.Point(12, 339);
            this.Settings.Name = "Settings";
            this.Settings.Size = new System.Drawing.Size(180, 45);
            this.Settings.TabIndex = 4;
            this.Settings.Text = "Settings";
            this.Settings.UseVisualStyleBackColor = false;
            this.Settings.Click += new System.EventHandler(this.Settings_Click);
            // 
            // Reports
            // 
            this.Reports.BackColor = System.Drawing.Color.Gainsboro;
            this.Reports.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Reports.Location = new System.Drawing.Point(12, 211);
            this.Reports.Name = "Reports";
            this.Reports.Size = new System.Drawing.Size(180, 45);
            this.Reports.TabIndex = 3;
            this.Reports.Text = "Reports";
            this.Reports.UseVisualStyleBackColor = false;
            this.Reports.Click += new System.EventHandler(this.Reports_Click);
            // 
            // Tasks
            // 
            this.Tasks.BackColor = System.Drawing.Color.Gainsboro;
            this.Tasks.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tasks.Location = new System.Drawing.Point(12, 150);
            this.Tasks.Name = "Tasks";
            this.Tasks.Size = new System.Drawing.Size(180, 45);
            this.Tasks.TabIndex = 2;
            this.Tasks.Text = "Tasks";
            this.Tasks.UseVisualStyleBackColor = false;
            this.Tasks.Click += new System.EventHandler(this.Tasks_Click);
            // 
            // StartTimer
            // 
            this.StartTimer.BackColor = System.Drawing.Color.Gainsboro;
            this.StartTimer.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartTimer.Location = new System.Drawing.Point(12, 82);
            this.StartTimer.Name = "StartTimer";
            this.StartTimer.Size = new System.Drawing.Size(180, 45);
            this.StartTimer.TabIndex = 1;
            this.StartTimer.Text = "Start Timer";
            this.StartTimer.UseVisualStyleBackColor = false;
            this.StartTimer.Click += new System.EventHandler(this.StartTimer_Click);
            // 
            // Dashboard
            // 
            this.Dashboard.BackColor = System.Drawing.Color.Gainsboro;
            this.Dashboard.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dashboard.Location = new System.Drawing.Point(12, 17);
            this.Dashboard.Name = "Dashboard";
            this.Dashboard.Size = new System.Drawing.Size(180, 45);
            this.Dashboard.TabIndex = 0;
            this.Dashboard.Text = "Dashboard";
            this.Dashboard.UseVisualStyleBackColor = false;
            this.Dashboard.Click += new System.EventHandler(this.Dashboard_Click);
            // 
            // MainContentPanel
            // 
            this.MainContentPanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.MainContentPanel.Controls.Add(this.WelcomeLabel);
            this.MainContentPanel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainContentPanel.ForeColor = System.Drawing.Color.DimGray;
            this.MainContentPanel.Location = new System.Drawing.Point(206, 86);
            this.MainContentPanel.Name = "MainContentPanel";
            this.MainContentPanel.Size = new System.Drawing.Size(794, 613);
            this.MainContentPanel.TabIndex = 2;
            // 
            // WelcomeLabel
            // 
            this.WelcomeLabel.AutoSize = true;
            this.WelcomeLabel.Location = new System.Drawing.Point(20, 20);
            this.WelcomeLabel.Name = "WelcomeLabel";
            this.WelcomeLabel.Size = new System.Drawing.Size(138, 38);
            this.WelcomeLabel.TabIndex = 0;
            this.WelcomeLabel.Text = "Welcome,";
            // 
            // SessionHistory
            // 
            this.SessionHistory.BackColor = System.Drawing.Color.Gainsboro;
            this.SessionHistory.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SessionHistory.Location = new System.Drawing.Point(12, 275);
            this.SessionHistory.Name = "SessionHistory";
            this.SessionHistory.Size = new System.Drawing.Size(180, 45);
            this.SessionHistory.TabIndex = 5;
            this.SessionHistory.Text = "Session History";
            this.SessionHistory.UseVisualStyleBackColor = false;
            this.SessionHistory.Click += new System.EventHandler(this.SessionHistory_Click_1);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Gainsboro;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(12, 403);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(180, 45);
            this.button1.TabIndex = 6;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // MainDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 712);
            this.Controls.Add(this.MainContentPanel);
            this.Controls.Add(this.SidePanel);
            this.Controls.Add(this.TopPanel);
            this.Name = "MainDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.TopPanel.ResumeLayout(false);
            this.TopPanel.PerformLayout();
            this.SidePanel.ResumeLayout(false);
            this.MainContentPanel.ResumeLayout(false);
            this.MainContentPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.Panel SidePanel;
        private System.Windows.Forms.Panel MainContentPanel;
        private System.Windows.Forms.Label TopLabel;
        private System.Windows.Forms.Button Settings;
        private System.Windows.Forms.Button Reports;
        private System.Windows.Forms.Button Tasks;
        private System.Windows.Forms.Button StartTimer;
        private System.Windows.Forms.Button Dashboard;
        private System.Windows.Forms.Label WelcomeLabel;
        private System.Windows.Forms.Button SessionHistory;
        private System.Windows.Forms.Button button1;
    }
}

