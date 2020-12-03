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
            this.reportViewer1.LocalReport.ReportPath = "Impression.rdlc";
            this.reportViewer1.LocalReport.DataSources.Add(
                new Microsoft.Reporting.WinForms.ReportDataSource(
              "DataSet1",
              items


                    )
                );
            this.reportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
            this.reportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.Percent;
            this.reportViewer1.ZoomPercent = 100;


            this.reportViewer1.RefreshReport();
        }
    }
}
