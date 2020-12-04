
namespace WinForm
{
    partial class Commande
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
            this.COMPTOIRBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewerVente = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.COMPTOIRBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // COMPTOIRBindingSource
            // 
            this.COMPTOIRBindingSource.DataSource = typeof(GESCOM.BO.COMPTOIR);
            // 
            // reportViewerVente
            // 
            this.reportViewerVente.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.COMPTOIRBindingSource;
            this.reportViewerVente.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewerVente.LocalReport.ReportEmbeddedResource = "WinForm.Impression.rdlc";
            this.reportViewerVente.Location = new System.Drawing.Point(0, 0);
            this.reportViewerVente.Name = "reportViewerVente";
            this.reportViewerVente.ServerReport.BearerToken = null;
            this.reportViewerVente.Size = new System.Drawing.Size(956, 554);
            this.reportViewerVente.TabIndex = 0;
            this.reportViewerVente.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // Commande
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(956, 554);
            this.Controls.Add(this.reportViewerVente);
            this.Name = "Commande";
            this.Text = "Commande";
            this.Load += new System.EventHandler(this.Commande_Load);
            ((System.ComponentModel.ISupportInitialize)(this.COMPTOIRBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewerVente;
        private System.Windows.Forms.BindingSource COMPTOIRBindingSource;
    }
}