namespace TakeCareOfPlants.Forms
{
    partial class PageReport_GUI
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
            if (disposing && (components != null)) {
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
            this.Custom_ReportViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // Custom_ReportViewer
            // 
            this.Custom_ReportViewer.AutoSize = true;
            this.Custom_ReportViewer.BackColor = System.Drawing.Color.DarkGray;
            this.Custom_ReportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Custom_ReportViewer.Location = new System.Drawing.Point(0, 0);
            this.Custom_ReportViewer.Name = "ReportViewer";
            this.Custom_ReportViewer.ServerReport.BearerToken = null;
            this.Custom_ReportViewer.Size = new System.Drawing.Size(800, 450);
            this.Custom_ReportViewer.TabIndex = 0;
            // 
            // PageReport_GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Custom_ReportViewer);
            this.Name = "PageReport_GUI";
            this.Text = "Report";
            this.Load += new System.EventHandler(this.PageReport_GUI_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer Custom_ReportViewer;
    }
}