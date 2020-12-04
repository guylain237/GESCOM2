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
using System.Configuration;

namespace WinForm
{
    public partial class FrmAchat : Form
    {
        private AchatBLO achatBLO;

        private Achat oldachat;

        private Action callback;
        public FrmAchat()
        {
            InitializeComponent();
            achatBLO = new AchatBLO(ConfigurationManager.AppSettings["dbfolder"]);

        }
        public FrmAchat(Action callback) : this()
        {
            this.callback = callback;
        }

        public FrmAchat(Achat achat, Action callback) : this(callback)
        {
            this.oldachat = achat;
            txtCode.Text = achat.Code;
            txtDesignation.Text = achat.Designation;
            txtFournisseur.Text = achat.Designation;
            txtQuantite.Text = achat.Quantite.ToString();


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

            try
            {
                checkForm();



                Achat newachat = new Achat
                (
                    txtCode.Text.ToUpper(),
                    txtFournisseur.Text,
                    txtDesignation.Text,
                     (txtNfacture.Text),
                    (txtQuantite.Text)


                  );
                AchatBLO achatBLO = new AchatBLO(ConfigurationManager.AppSettings["dbfolder"]);

                if (this.oldachat == null)
                    achatBLO.Command(newachat);
                else
                    achatBLO.AJOUTAchat(oldachat, newachat);

                MessageBox.Show
                (
                    "Save done !",
                    "Confirmation",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                if (callback != null)
                    callback();

                if (oldachat != null)
                    Close();


                txtCode.Clear();
                txtDesignation.Clear();
                txtFournisseur.Clear();
                txtNfacture.Clear();
                txtQuantite.Clear();
                txtCode.Focus();

            }
            catch (TypingException ex)
            {
                MessageBox.Show
               (
                   ex.Message,
                   "Typing error",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Warning
               );
            }
            catch (DuplicateNameException ex)
            {
                MessageBox.Show
               (
                   ex.Message,
                   "Duplicate error",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Warning
               );
            }
            catch (KeyNotFoundException ex)
            {
                MessageBox.Show
               (
                   ex.Message,
                   "Not found error",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Warning
               );
            }
            catch (Exception ex)
            {
                ex.WriteToFile();
                MessageBox.Show
               (
                   "An error occurred! Please try again later.",
                   "Erreur",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Error
               );
            }
        }
        private void checkForm()
        {
            string text = string.Empty;
            txtCode.BackColor = Color.White;
            txtDesignation.BackColor = Color.White;
            if (string.IsNullOrWhiteSpace(txtCode.Text))
            {
                text += "- Please enter the reference ! \n";
                txtCode.BackColor = Color.Pink;
            }
            if (string.IsNullOrWhiteSpace(txtDesignation.Text))
            {
                text += "- Please enter the name ! \n";
                txtDesignation.BackColor = Color.Pink;
            }

            if (!string.IsNullOrEmpty(text))
                throw new TypingException(text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Achat_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmEditAchat p = new FrmEditAchat();
            p.Show();
        }
    }
}
