using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinForm;
using GESCOM.BLL;

using GESCOM.BO;

using GESCOM.DA;
using System.Configuration;

namespace WinForm
{
    public partial class Historique : Form
    {
        private VENTEBLO venteBLO;
        public Historique()
        {
            InitializeComponent();
            dataGridView1.AutoGenerateColumns = false;
            venteBLO = new VENTEBLO(ConfigurationManager.AppSettings["dbfolder"]);

        }



        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void loadata()
        {


            string value = textsearch.Text.ToLower();
            var comptoirs = venteBLO.getbys
            (
                x =>
                x.Code.ToLower().Contains(value) ||
                x.Designation.ToLower().Contains(value)
            ).OrderBy(x => x.Code).ToArray();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = comptoirs;
            count.Text = $"{dataGridView1.RowCount}rows";
            dataGridView1.ClearSelection();

        }

        private void butactu2_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(textsearch.Text))
                loadata();
            else
                textsearch.Clear();
        }

        private void textsearch_TextChanged(object sender, EventArgs e)
        {
            loadata();
        }

        private void Historique_Load(object sender, EventArgs e)
        {
            loadata();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            if (dataGridView1.SelectedRows.Count > 0)
            {
                if (
                    MessageBox.Show
                    (
                        "Do you really want to delete this product(s)?",
                        "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question
                    ) == DialogResult.Yes
                )
                {
                    for (int i = 0; i < dataGridView1.SelectedRows.Count; i++)
                    {
                        venteBLO.DeleteCommande(dataGridView1.SelectedRows[i].DataBoundItem as COMPTOIR);
                    }
                    loadata();
                }
            }
            }
    }
}
