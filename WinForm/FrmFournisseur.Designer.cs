
namespace WinForm
{
    partial class FrmFournisseur
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblCodeFour = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lblNomFour = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.lblAdrFour = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.lblTel = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.lblEmailFour = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCodeFour
            // 
            this.lblCodeFour.AutoSize = true;
            this.lblCodeFour.Location = new System.Drawing.Point(23, 107);
            this.lblCodeFour.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCodeFour.Name = "lblCodeFour";
            this.lblCodeFour.Size = new System.Drawing.Size(217, 25);
            this.lblCodeFour.TabIndex = 0;
            this.lblCodeFour.Text = "CODE FOURNISSEUR";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(23, 137);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(427, 30);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(23, 220);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(427, 30);
            this.textBox2.TabIndex = 3;
            // 
            // lblNomFour
            // 
            this.lblNomFour.AutoSize = true;
            this.lblNomFour.Location = new System.Drawing.Point(23, 190);
            this.lblNomFour.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNomFour.Name = "lblNomFour";
            this.lblNomFour.Size = new System.Drawing.Size(59, 25);
            this.lblNomFour.TabIndex = 2;
            this.lblNomFour.Text = "NOM";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(23, 313);
            this.textBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(427, 30);
            this.textBox3.TabIndex = 5;
            // 
            // lblAdrFour
            // 
            this.lblAdrFour.AutoSize = true;
            this.lblAdrFour.Location = new System.Drawing.Point(23, 283);
            this.lblAdrFour.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAdrFour.Name = "lblAdrFour";
            this.lblAdrFour.Size = new System.Drawing.Size(107, 25);
            this.lblAdrFour.TabIndex = 4;
            this.lblAdrFour.Text = "ADRESSE";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(23, 398);
            this.textBox4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(427, 30);
            this.textBox4.TabIndex = 7;
            // 
            // lblTel
            // 
            this.lblTel.AutoSize = true;
            this.lblTel.Location = new System.Drawing.Point(23, 368);
            this.lblTel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTel.Name = "lblTel";
            this.lblTel.Size = new System.Drawing.Size(132, 25);
            this.lblTel.TabIndex = 6;
            this.lblTel.Text = "TELEPHONE";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(23, 487);
            this.textBox5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(427, 30);
            this.textBox5.TabIndex = 9;
            // 
            // lblEmailFour
            // 
            this.lblEmailFour.AutoSize = true;
            this.lblEmailFour.Location = new System.Drawing.Point(23, 457);
            this.lblEmailFour.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmailFour.Name = "lblEmailFour";
            this.lblEmailFour.Size = new System.Drawing.Size(60, 25);
            this.lblEmailFour.TabIndex = 8;
            this.lblEmailFour.Text = "Email";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(100, 554);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(262, 57);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "SAVE";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.button1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(28, 24);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(39, 30);
            this.button1.TabIndex = 11;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // FrmFournisseur
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 655);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.lblEmailFour);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.lblTel);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.lblAdrFour);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.lblNomFour);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblCodeFour);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmFournisseur";
            this.Text = "FrmClient";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCodeFour;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lblNomFour;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label lblAdrFour;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label lblTel;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label lblEmailFour;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button button1;
    }
}