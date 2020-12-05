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
    public partial class Connexion : Form
    {
        private bool closed = true;
        public Connexion()
        {
            InitializeComponent();
            checkBox1.Checked = false;
        }

        private void butok_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == "admin")
            {
                if (textBox2.Text == "root")
                {
                    Parent conn = new Parent();
                    conn.Show();
                    this.Hide();
                }
                else label5.Visible = true;





            }
            else label4.Visible = true;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

            if (checkBox1.Checked)
                textBox2.UseSystemPasswordChar = false;
            else
                textBox2.UseSystemPasswordChar = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Connexion_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
