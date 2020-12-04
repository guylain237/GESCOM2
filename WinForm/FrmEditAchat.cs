using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GESCOM.BLL;
using GESCOM.BO;
using System.Runtime.Remoting.Metadata.W3cXsd2001;

namespace WinForm
{
    public partial class FrmEditAchat : Form
    {
        private AchatBLO achatBLO;
        public FrmEditAchat()
        {
            InitializeComponent();
            dataGridViewa.AutoGenerateColumns = false;
            achatBLO = new AchatBLO(ConfigurationManager.AppSettings["dbfolder"]);


        } 
       

       

        private void button5_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void loadData()
        {
            string value = txtsearch.Text.ToLower();
            var achats = achatBLO.Getby
            (
                x =>
                x.Code.ToLower().Contains(value) ||
                x.Designation.ToLower().Contains(value)
            ).OrderBy(x => x.Code).ToArray();
            dataGridViewa.DataSource = null;
            dataGridViewa.DataSource = achats;
            //lblRowCount.Text = $"{dataGridViewa.RowCount} rows";
            dataGridViewa.ClearSelection();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            if (dataGridViewa.SelectedRows.Count > 0)
            {
                for (int i = 0; i < dataGridViewa.SelectedRows.Count; i++)
                {
                    Form f = new FrmAchat
                    (
                        dataGridViewa.SelectedRows[i].DataBoundItem as Achat,
                        loadData
                    );
                    f.ShowDialog();
                }
            }
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {

            if (dataGridViewa.SelectedRows.Count > 0)
            {
                if (
                    MessageBox.Show
                    (
                        "Do you really want to delete this achat(s)?",
                        "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question
                    ) == DialogResult.Yes
                )
                {
                    for (int i = 0; i < dataGridViewa.SelectedRows.Count; i++)
                    {
                        achatBLO.SupprimerAchat(dataGridViewa.SelectedRows[i].DataBoundItem as Achat);
                    }
                    loadData();
                }
            }
        }

        private void btnActualiser_Click(object sender, EventArgs e)
        {


            if (string.IsNullOrEmpty(txtsearch.Text))
                loadData();
            else
                txtsearch.Clear();
        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            loadData();
        }

        private void butnouveau_Click(object sender, EventArgs e)
        {
            FrmAchat n = new FrmAchat();
            n.Show();
        }

        private void btnImprimer_Click(object sender, EventArgs e)
        {
            List<ImpAchat> items = new List<ImpAchat>();
            for (int i = 0; i < dataGridViewa.Rows.Count; i++)
            {
                Achat A = dataGridViewa.Rows[i].DataBoundItem as Achat;
                items.Add
                    (
                    new ImpAchat
                    (
                    A.Code,
                    A.Designation,
                    A.Quantite,
                  
                    A.Fournisseur,

                    A.Nfacture
                    )



                    );



            }
            Form f = new FrmPrint("PRINT.rdlc", items);
            f.Show();
        }
    }
}
