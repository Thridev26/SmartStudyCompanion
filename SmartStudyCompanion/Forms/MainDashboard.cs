using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SmartStudyCompanion.Forms;

namespace SmartStudyCompanion
{
    public partial class MainDashboard : Form
    {
        public MainDashboard()
        {
            InitializeComponent();
        }

        private void Dashboard_Click(object sender, EventArgs e)
        {
            Dashboard.FlatStyle = FlatStyle.Flat;
            Dashboard.FlatAppearance.BorderSize = 0;
            Dashboard.FlatAppearance.MouseOverBackColor = Color.LightSteelBlue;            
        }

        private void StartTimer_Click(object sender, EventArgs e)
        {
            StartTimer.FlatStyle = FlatStyle.Flat;
            StartTimer.FlatAppearance.BorderSize = 0;
            StartTimer.FlatAppearance.MouseOverBackColor = Color.LightSteelBlue;

            MainContentPanel.Controls.Clear(); // Clear previous content

            TimerScreen timerScreen = new TimerScreen();
            timerScreen.Dock = DockStyle.Fill;

            MainContentPanel.Controls.Add(timerScreen);
        }

        private void Tasks_Click(object sender, EventArgs e)
        {
            Tasks.FlatStyle = FlatStyle.Flat;
            Tasks.FlatAppearance.BorderSize = 0;
            Tasks.FlatAppearance.MouseOverBackColor = Color.LightSteelBlue;
        }

        private void Reports_Click(object sender, EventArgs e)
        {
            Reports.FlatStyle = FlatStyle.Flat;
            Reports.FlatAppearance.BorderSize = 0;
            Reports.FlatAppearance.MouseOverBackColor = Color.LightSteelBlue;
        }

        private void Settings_Click(object sender, EventArgs e)
        {
            Settings.FlatStyle = FlatStyle.Flat;
            Settings.FlatAppearance.BorderSize = 0;
            Settings.FlatAppearance.MouseOverBackColor = Color.LightSteelBlue;
        }

        private void SessionHistory_Click(object sender, EventArgs e)
        {
            var historyForm = new SessionHistoryForm();
            historyForm.ShowDialog(); // Opens as modal
        }

        private void SessionHistory_Click_1(object sender, EventArgs e)
        {
            // Hide the dashboard while session history is open
            this.Hide();

            // Pass the current dashboard instance (this) into SessionHistoryForm constructor
            var sessionHistory = new SessionHistoryForm(this);
            sessionHistory.ShowDialog();

            // After session history closes, show the dashboard again
            this.Show();
        }
    }
}
