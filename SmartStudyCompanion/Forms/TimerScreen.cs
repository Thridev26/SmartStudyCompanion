﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;

namespace SmartStudyCompanion.Forms
{
    public partial class TimerScreen : UserControl
    {
        private Timer countdownTimer;
        private TimeSpan remainingTime;

        private TimeSpan defaultTime = TimeSpan.FromMinutes(25);
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
                System.Media.SystemSounds.Exclamation.Play();

                LogSession();

                MessageBox.Show("Time's up!", "Session Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);

                remainingTime = defaultTime;
                UpdateTimerLabel();
                TimeSelector.Enabled = true;
            }
        }

        private void UpdateTimerLabel()
        {
            TimerLabel.Text = remainingTime.ToString(@"hh\:mm\:ss");
        }

        private void Start_Click(object sender, EventArgs e)
        {
            TimeSelector.Enabled = false;
            if (!countdownTimer.Enabled)
            {
                // If the timer is reset or just starting, use selected time
                if (remainingTime == TimeSpan.Zero || remainingTime == defaultTime)
                {
                    int selectedMinutes = (int)TimeSelector.Value;
                    remainingTime = TimeSpan.FromMinutes(selectedMinutes);
                    defaultTime = remainingTime; // So Reset uses latest selection
                }

                countdownTimer.Start();
            }
        }

        private void Pause_Click(object sender, EventArgs e)
        {
            TimeSelector.Enabled = true;
            if (countdownTimer.Enabled)
            {
                countdownTimer.Stop();
            }
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            TimeSelector.Enabled = true;
            countdownTimer.Stop();
            remainingTime = defaultTime;
            UpdateTimerLabel();
        }

        private void LogSession()
        {
            string filePath = "sessions.json";
            List<StudySession> sessions;

            // Load existing sessions if the file exists
            if (File.Exists(filePath))
            {
                string json = File.ReadAllText(filePath);
                sessions = JsonConvert.DeserializeObject<List<StudySession>>(json) ?? new List<StudySession>();
            }
            else
            {
                sessions = new List<StudySession>();
            }

            // Create a new session record for the just-finished timer
            var newSession = new StudySession
            {
                StartTime = DateTime.Now - defaultTime,  // Assume defaultTime holds the session length
                EndTime = DateTime.Now
            };

            sessions.Add(newSession);

            // Serialize and save the updated sessions list
            string updatedJson = JsonConvert.SerializeObject(sessions, Formatting.Indented);
            File.WriteAllText(filePath, updatedJson);
        }
    }
}
