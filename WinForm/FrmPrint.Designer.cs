
namespace WinForm
{
    partial class FrmPrint
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
            this.reportViewerAchat = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ImpAchatBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ImpAchatBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewerAchat
            // 
            this.reportViewerAchat.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.ImpAchatBindingSource;
            this.reportViewerAchat.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewerAchat.LocalReport.ReportEmbeddedResource = "WinForm.PRINT.rdlc";
            this.reportViewerAchat.Location = new System.Drawing.Point(0, 0);
            this.reportViewerAchat.Name = "reportViewerAchat";
            this.reportViewerAchat.ServerReport.BearerToken = null;
            this.reportViewerAchat.Size = new System.Drawing.Size(874, 485);
            this.reportViewerAchat.TabIndex = 0;
            this.reportViewerAchat.Load += new System.EventHandler(this.reportViewerAchat_Load);
            // 
            // ImpAchatBindingSource
            // 
            this.ImpAchatBindingSource.DataSource = typeof(WinForm.ImpAchat);
            // 
            // FrmPrint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 485);
            this.Controls.Add(this.reportViewerAchat);
            this.Name = "FrmPrint";
            this.Text = "FrmPrint";
            this.Load += new System.EventHandler(this.FrmPrint_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ImpAchatBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewerAchat;
        private System.Windows.Forms.BindingSource ImpAchatBindingSource;
    }
}