﻿using GESCOM.BLL;
using GESCOM.BO;
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



namespace WinForm
{
    public partial class Comptoir : Form
    {
        private VENTEBLO venteBLO;
        private Action callback;
        private VENTEBLO oldcommande;
        public Comptoir()
        {
            InitializeComponent();
            dataGridView1.AutoGenerateColumns = false;
            oldcommande = new VENTEBLO(ConfigurationManager.AppSettings["DbFolder"]);


        }
        public Comptoir(Action callback) : this()
        {
            this.callback = callback;

        }
        public Comptoir(COMPTOIR comptoir, Action callback) : this(callback)
        {
            this.oldcommande = comptoir;
            textCODE.Text = comptoir.Code;
            textDESIGNATION.Text = comptoir.Designation;
            textQUANTITE.Text = comptoir.Quantite.ToString();
            textPRIX.Text = comptoir.Prix.ToString();
            textTVA.Text = comptoir.TVA.ToString();
            textTOTAL.Text = comptoir.TOTAL.ToString();
        }

        private void Comptoir_Load(object sender, EventArgs e)
        {

            loadata();

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
        private void loadata()
        {
            

            string value = textsearch.Text.ToLower();
            var comptoirs = venteBLO.getby
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

        private void buttajout_Click(object sender, EventArgs e)
        {
            try
            {
                checkForm();
                COMPTOIR newcommande = new COMPTOIR
                   (

                    textCODE.Text,
                    textDESIGNATION.Text,
                    int.Parse(textQUANTITE.Text),
                     float.Parse(textTVA.Text),
                    double.Parse(textPRIX.Text),

                   double.Parse(textTOTAL.Text)
                           //DateTime.Now.ToString(dateTimePicker2.Text)




                           );




                VENTEBLO comptoirBLO = new VENTEBLO(ConfigurationManager.AppSettings["dbfolder"]);

                if (this.oldcommande == null)
                    comptoirBLO.Commande(newcommande);
                else
                    comptoirBLO.Editcommande(oldcommande, newcommande);

                MessageBox.Show
                (
                    "Save done !",
                    "Confirmation",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
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
            if (callback != null)
                callback();
            textCODE.Clear();
            textDESIGNATION.Clear();
            textQUANTITE.Clear();
            textPRIX.Clear();
            textTOTAL.Clear();
            textTVA.Clear();
            //dateTimePicker2.Contain;
            textCODE.Focus();


        }
        private void checkForm()
        {
            string text = string.Empty;
            textCODE.BackColor = Color.White;
            textDESIGNATION.BackColor = Color.White;
            if (string.IsNullOrWhiteSpace(textCODE.Text))
            {
                text += "- Please enter the reference ! \n";
                textCODE.BackColor = Color.Pink;
            }
            if (string.IsNullOrWhiteSpace(textDESIGNATION.Text))
            {
                text += "- Please enter the name ! \n";
                textDESIGNATION.BackColor = Color.Pink;
            }

            if (!string.IsNullOrEmpty(text))
                throw new TypingException(text);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            //string value = textsearch.Text.ToLower();
            //var comptoirs = oldcommande.getby(
               //   x =>
                //  x.Code
                       //      .Contains(value) //||
                                              // x..Contains(value)


               //   );
            loadata();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            // loadata(VENTEBLO.getallcomptoir());
        }

        private void buttmodif_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                for (int i = 0; i < dataGridView1.SelectedRows.Count; i++)
                {


                    //  dataGridView1.SelectedRows[i].DataBoundItem as Comptoir,
                    // loadata(comptoirs);
                }
            }
        }
    }
}
