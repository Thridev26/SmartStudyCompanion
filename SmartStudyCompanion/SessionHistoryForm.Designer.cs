
namespace SmartStudyCompanion.Forms
{
    partial class SessionHistoryForm
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
            this.SessionsGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.SessionsGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // SessionsGridView
            // 
            this.SessionsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SessionsGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SessionsGridView.Location = new System.Drawing.Point(0, 0);
            this.SessionsGridView.Name = "SessionsGridView";
            this.SessionsGridView.RowHeadersWidth = 62;
            this.SessionsGridView.RowTemplate.Height = 28;
            this.SessionsGridView.Size = new System.Drawing.Size(800, 450);
            this.SessionsGridView.TabIndex = 0;
            // 
            // SessionHistoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SessionsGridView);
            this.Name = "SessionHistoryForm";
            this.Text = "SessionHistoryForm";
            ((System.ComponentModel.ISupportInitialize)(this.SessionsGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView SessionsGridView;
    }
}