namespace GE_Service
{
    partial class Print
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Print));
            this.T_NotifyBindSour = new System.Windows.Forms.BindingSource(this.components);
            this.GEdataSet = new GE_Service.GEdataSet();
            this.GEReport = new Microsoft.Reporting.WinForms.ReportViewer();
            this.T_NotifyTabAd = new GE_Service.GEdataSetTableAdapters.T_NotificationTableAdapter();
            this.GeneralReport = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.T_NotifyBindSour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GEdataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // T_NotifyBindSour
            // 
            this.T_NotifyBindSour.DataMember = "T_Notification";
            this.T_NotifyBindSour.DataSource = this.GEdataSet;
            // 
            // GEdataSet
            // 
            this.GEdataSet.DataSetName = "GEdataSet";
            this.GEdataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // GEReport
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.T_NotifyBindSour;
            this.GEReport.LocalReport.DataSources.Add(reportDataSource1);
            this.GEReport.LocalReport.ReportEmbeddedResource = "GE_Service.Report2.rdlc";
            this.GEReport.Location = new System.Drawing.Point(12, 12);
            this.GEReport.Name = "GEReport";
            this.GEReport.ServerReport.BearerToken = null;
            this.GEReport.Size = new System.Drawing.Size(279, 275);
            this.GEReport.TabIndex = 0;
            // 
            // T_NotifyTabAd
            // 
            this.T_NotifyTabAd.ClearBeforeFill = true;
            // 
            // GeneralReport
            // 
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.T_NotifyBindSour;
            this.GeneralReport.LocalReport.DataSources.Add(reportDataSource2);
            this.GeneralReport.LocalReport.ReportEmbeddedResource = "GE_Service.GeneralReport.rdlc";
            this.GeneralReport.Location = new System.Drawing.Point(322, 12);
            this.GeneralReport.Name = "GeneralReport";
            this.GeneralReport.ServerReport.BearerToken = null;
            this.GeneralReport.Size = new System.Drawing.Size(279, 275);
            this.GeneralReport.TabIndex = 0;
            // 
            // Print
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.GeneralReport);
            this.Controls.Add(this.GEReport);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Print";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Print";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Print_Load);
            ((System.ComponentModel.ISupportInitialize)(this.T_NotifyBindSour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GEdataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private GEdataSet GEdataSet;
        private Microsoft.Reporting.WinForms.ReportViewer GEReport;
        private System.Windows.Forms.BindingSource T_NotifyBindSour;
        private GEdataSetTableAdapters.T_NotificationTableAdapter T_NotifyTabAd;
        private Microsoft.Reporting.WinForms.ReportViewer GeneralReport;
    }
}