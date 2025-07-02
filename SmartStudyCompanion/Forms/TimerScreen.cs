using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartStudyCompanion.Forms
{
    public partial class TimerScreen : UserControl
    {
        private Timer countdownTimer;
        private TimeSpan remainingTime;
        private readonly TimeSpan defaultTime = TimeSpan.FromMinutes(25);
        private bool isPaused = false;
        public TimerScreen()
        {
            InitializeComponent();
            remainingTime = defaultTime;

            countdownTimer = new Timer();
            countdownTimer.Interval = 1000; // 1 second
            countdownTimer.Tick += CountdownTimer_Tick;

            UpdateTimerLabel();
        }

        private void CountdownTimer_Tick(object sender, EventArgs e)
        {
            if (remainingTime.TotalSeconds > 0)
            {
                remainingTime = remainingTime.Subtract(TimeSpan.FromSeconds(1));
                UpdateTimerLabel();
            }
            else
            {
                countdownTimer.Stop();
                MessageBox.Show("Time's up!", "Session Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                remainingTime = defaultTime;
                UpdateTimerLabel();
            }
        }

        private void UpdateTimerLabel()
        {
            TimerLabel.Text = remainingTime.ToString(@"hh\:mm\:ss");
        }

        private void Start_Click(object sender, EventArgs e)
        {
            if (!countdownTimer.Enabled)
            {
                countdownTimer.Start();
                isPaused = false;
            }
        }

        private void Pause_Click(object sender, EventArgs e)
        {
            if (countdownTimer.Enabled)
            { 
                countdownTimer.Stop();
                isPaused = true;
            }
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            countdownTimer.Stop();
            remainingTime = defaultTime;
            UpdateTimerLabel();
            isPaused = false;
        }
    }
}
