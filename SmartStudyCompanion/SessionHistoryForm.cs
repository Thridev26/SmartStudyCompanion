using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace SmartStudyCompanion.Forms
{
    public partial class SessionHistoryForm : Form
    {
        private readonly string filePath = "sessions.json";
        private List<StudySession> sessions;

        public SessionHistoryForm()
        {
            InitializeComponent();
            Load += SessionHistoryForm_Load;
        }

        private void SessionHistoryForm_Load(object sender, EventArgs e)
        {
            LoadSessions();
            BindSessionsToGrid();
        }

        private void LoadSessions()
        {
            if (File.Exists(filePath))
            {
                string json = File.ReadAllText(filePath);
                sessions = JsonConvert.DeserializeObject<List<StudySession>>(json) ?? new List<StudySession>();
            }
            else
            {
                sessions = new List<StudySession>();
            }
        }

        private void BindSessionsToGrid()
        {
            SessionsGridView.DataSource = null;
            SessionsGridView.AutoGenerateColumns = false;
            SessionsGridView.Columns.Clear();

            SessionsGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Start Time",
                DataPropertyName = "StartTime",
                Width = 150,
                DefaultCellStyle = { Format = "g" } // General date/time
            });

            SessionsGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "End Time",
                DataPropertyName = "EndTime",
                Width = 150,
                DefaultCellStyle = { Format = "g" }
            });

            SessionsGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Duration",
                DataPropertyName = "Duration",
                Width = 100,
                DefaultCellStyle = { Format = @"hh\:mm\:ss" } // e.g. 01:15:00
            });

            SessionsGridView.DataSource = sessions;
        }
    }
}

