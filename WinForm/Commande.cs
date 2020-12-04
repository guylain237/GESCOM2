using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WinForm
{
    public partial class Commande : Form
    { private Object items { get; set; }
        private Object reportpath { get; set; }
        public Commande()
        {
            InitializeComponent();
        }

        public Commande(string reportpath,object items):this()
        {
            this.reportpath = reportpath;
            this.items = items;

        }

        private void Commande_Load(object sender, EventArgs e) 
        {
            this.reportViewerVente.LocalReport.ReportPath = "Impression.rdlc";
            this.reportViewerVente.LocalReport.DataSources.Add(
                new Microsoft.Reporting.WinForms.ReportDataSource(
              "DataSet1",
              items


                    )
                );
            this.reportViewerVente.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
            this.reportViewerVente.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.Percent;
            this.reportViewerVente.ZoomPercent = 70;


            this.reportViewerVente.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
