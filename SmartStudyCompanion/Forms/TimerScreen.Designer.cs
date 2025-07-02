
namespace SmartStudyCompanion.Forms
{
    partial class TimerScreen
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TimerLabel = new System.Windows.Forms.Label();
            this.Start = new System.Windows.Forms.Button();
            this.Pause = new System.Windows.Forms.Button();
            this.Reset = new System.Windows.Forms.Button();
            this.TimeSelector = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.TimeSelector)).BeginInit();
            this.SuspendLayout();
            // 
            // TimerLabel
            // 
            this.TimerLabel.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimerLabel.Location = new System.Drawing.Point(153, 39);
            this.TimerLabel.Name = "TimerLabel";
            this.TimerLabel.Size = new System.Drawing.Size(184, 55);
            this.TimerLabel.TabIndex = 0;
            this.TimerLabel.Text = "00:25:00";
            // 
            // Start
            // 
            this.Start.FlatAppearance.BorderSize = 0;
            this.Start.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSteelBlue;
            this.Start.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Start.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Start.Location = new System.Drawing.Point(45, 114);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(87, 37);
            this.Start.TabIndex = 1;
            this.Start.Text = "Start";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // Pause
            // 
            this.Pause.FlatAppearance.BorderSize = 0;
            this.Pause.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSteelBlue;
            this.Pause.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Pause.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pause.Location = new System.Drawing.Point(174, 114);
            this.Pause.Name = "Pause";
            this.Pause.Size = new System.Drawing.Size(87, 37);
            this.Pause.TabIndex = 2;
            this.Pause.Text = "Pause";
            this.Pause.UseVisualStyleBackColor = true;
            this.Pause.Click += new System.EventHandler(this.Pause_Click);
            // 
            // Reset
            // 
            this.Reset.FlatAppearance.BorderSize = 0;
            this.Reset.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSteelBlue;
            this.Reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Reset.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Reset.Location = new System.Drawing.Point(288, 114);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(87, 37);
            this.Reset.TabIndex = 3;
            this.Reset.Text = "Reset";
            this.Reset.UseVisualStyleBackColor = true;
            this.Reset.Click += new System.EventHandler(this.Reset_Click);
            // 
            // TimeSelector
            // 
            this.TimeSelector.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeSelector.Location = new System.Drawing.Point(255, 173);
            this.TimeSelector.Maximum = new decimal(new int[] {
            120,
            0,
            0,
            0});
            this.TimeSelector.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.TimeSelector.Name = "TimeSelector";
            this.TimeSelector.Size = new System.Drawing.Size(120, 34);
            this.TimeSelector.TabIndex = 4;
            this.TimeSelector.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TimeSelector.Value = new decimal(new int[] {
            25,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(45, 173);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 28);
            this.label1.TabIndex = 5;
            this.label1.Text = "Customise Time:";
            // 
            // TimerScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TimeSelector);
            this.Controls.Add(this.Reset);
            this.Controls.Add(this.Pause);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.TimerLabel);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "TimerScreen";
            this.Size = new System.Drawing.Size(400, 250);
            ((System.ComponentModel.ISupportInitialize)(this.TimeSelector)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TimerLabel;
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.Button Pause;
        private System.Windows.Forms.Button Reset;
        private System.Windows.Forms.NumericUpDown TimeSelector;
        private System.Windows.Forms.Label label1;
    }
}
