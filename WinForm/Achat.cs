using GESCOM.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GESCOM.BO;
using GESCOM.DA;

namespace WinForm
{
    public partial class Achat : Form
    {
        public Achat(string text)
        {
            InitializeComponent();
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            txtCode.Clear();
            txtDesignation.Clear();
            txtFournisseur.Clear();
            txtNfacture.Clear();
            txtQuantite.Clear();
            txtCode.Focus();
        }

        private void btnEnregistrer_Click(object sender, EventArgs e)
        {

           /*  Achat achat = new Achat
                (
                    txtCode.Text,
                    txtDesignation.Text,
                    txtFournisseur.Text,
                    txtNfacture.Text,
                    txtQuantite.Text
                );
            AchatBLO achatBLO = new AchatBLO();
            achatBLO.AjouterAchat(achat);

            MessageBox.Show
                (
                    "Enregistrement Reussi",
                    "Confirmation",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );


            Form1 f = new Form1();
            f.Show(); */
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
