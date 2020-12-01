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
using GESCOM.BLL;
using System.Configuration;



namespace WinForm
{
    public partial class Comptoir : Form
    {
        private Action callback;
        private VENTEBLO comptoirBLO;
        public Comptoir()
        {
            InitializeComponent();
            dataGridView1.AutoGenerateColumns = false;
            comptoirBLO = new VENTEBLO(ConfigurationManager.AppSettings["DbFolder"]);
            

    }
        public Comptoir(Action callback) : this()
        {
            this.callback = callback;
             
    }


    private void Comptoir_Load(object sender, EventArgs e)
        {
            //jèarrive pour te coder
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
                   
        }
        private void loadata(IEnumerable<COMPTOIR> comptoirs)
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = comptoirs;
            count.Text = $"{dataGridView1.RowCount}rows";
            dataGridView1.ClearSelection();



        }

        private void buttajout_Click(object sender, EventArgs e)
        {
            COMPTOIR comptoir = new COMPTOIR
               (

                textCODE.Text,
                textDESIGNATION.Text,
                int.Parse(textQUANTITE.Text),
                 float.Parse(textTVA.Text),
                double.Parse(textPRIX.Text),
                
               double.Parse(textTOTAL.Text)
                //DateTime.Now.ToString(dateTimePicker2.Text)




                       ) ;
            VENTEBLO comptoirBLO = new VENTEBLO(ConfigurationManager.AppSettings["Dbfolder"]);
            comptoirBLO.Commande(comptoir);

            MessageBox.Show(
                "save done",
                "confirmation",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information

                );
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

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            string value = textsearch.Text.ToLower();
            var comptoirs = comptoirBLO.getby(
                  x =>
                  x.Code
                             .Contains(value) //||
                 // x..Contains(value)


                  );
            loadata(comptoirs);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
