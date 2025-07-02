
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
            this.SuspendLayout();
            // 
            // TimerLabel
            // 
            this.TimerLabel.AutoSize = true;
            this.TimerLabel.Location = new System.Drawing.Point(170, 54);
            this.TimerLabel.Name = "TimerLabel";
            this.TimerLabel.Size = new System.Drawing.Size(71, 20);
            this.TimerLabel.TabIndex = 0;
            this.TimerLabel.Text = "00:25:00";
            // 
            // Start
            // 
            this.Start.FlatAppearance.BorderSize = 0;
            this.Start.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSteelBlue;
            this.Start.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Start.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Start.Location = new System.Drawing.Point(34, 101);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(87, 37);
            this.Start.TabIndex = 1;
            this.Start.Text = "Start";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.button1_Click);
            // 
            // Pause
            // 
            this.Pause.FlatAppearance.BorderSize = 0;
            this.Pause.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSteelBlue;
            this.Pause.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Pause.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pause.Location = new System.Drawing.Point(163, 101);
            this.Pause.Name = "Pause";
            this.Pause.Size = new System.Drawing.Size(87, 37);
            this.Pause.TabIndex = 2;
            this.Pause.Text = "Pause";
            this.Pause.UseVisualStyleBackColor = true;
            this.Pause.Click += new System.EventHandler(this.button2_Click);
            // 
            // Reset
            // 
            this.Reset.FlatAppearance.BorderSize = 0;
            this.Reset.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSteelBlue;
            this.Reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Reset.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Reset.Location = new System.Drawing.Point(277, 101);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(87, 37);
            this.Reset.TabIndex = 3;
            this.Reset.Text = "Reset";
            this.Reset.UseVisualStyleBackColor = true;
            this.Reset.Click += new System.EventHandler(this.button3_Click);
            // 
            // TimerScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Reset);
            this.Controls.Add(this.Pause);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.TimerLabel);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "TimerScreen";
            this.Size = new System.Drawing.Size(400, 250);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TimerLabel;
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.Button Pause;
        private System.Windows.Forms.Button Reset;
    }
}
