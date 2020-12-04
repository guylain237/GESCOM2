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
    public partial class FrmPrint : Form
    {
        private Object item { get; set; }
        private Object reportpaths { get; set; }
        public FrmPrint()
        {
            InitializeComponent();
        }
        public FrmPrint(string reportpaths, object item) : this()
        {
            this.reportpaths = reportpaths;
          
            this.item = item;

        }

        private void FrmPrint_Load(object sender, EventArgs e)
        {
            this.reportViewerAchat.LocalReport.ReportPath = "FrmPrint.rdlc";
            this.reportViewerAchat.LocalReport.DataSources.Add(
                new Microsoft.Reporting.WinForms.ReportDataSource(
              "DataSet1",
              item


                    )
                );
            this.reportViewerAchat.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
            this.reportViewerAchat.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.Percent;
            this.reportViewerAchat.ZoomPercent = 70;

            this.reportViewerAchat.RefreshReport();
        }
    }
}
