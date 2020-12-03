
namespace WinForm
{
    partial class Achat
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
            this.lblCode = new System.Windows.Forms.Label();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.txtNfacture = new System.Windows.Forms.TextBox();
            this.lblNfacture = new System.Windows.Forms.Label();
            this.txtQuantite = new System.Windows.Forms.TextBox();
            this.lblQuantite = new System.Windows.Forms.Label();
            this.txtFournisseur = new System.Windows.Forms.TextBox();
            this.lblFournisseur = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lblDate = new System.Windows.Forms.Label();
            this.txtDesignation = new System.Windows.Forms.TextBox();
            this.lblDesignateur = new System.Windows.Forms.Label();
            this.btnEnregistrer = new System.Windows.Forms.Button();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCode
            // 
            this.lblCode.AutoSize = true;
            this.lblCode.Location = new System.Drawing.Point(14, 94);
            this.lblCode.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(82, 29);
            this.lblCode.TabIndex = 0;
            this.lblCode.Text = "CODE";
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(19, 128);
            this.txtCode.Margin = new System.Windows.Forms.Padding(5);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(547, 34);
            this.txtCode.TabIndex = 1;
            // 
            // txtNfacture
            // 
            this.txtNfacture.Location = new System.Drawing.Point(19, 228);
            this.txtNfacture.Margin = new System.Windows.Forms.Padding(5);
            this.txtNfacture.Name = "txtNfacture";
            this.txtNfacture.Size = new System.Drawing.Size(238, 34);
            this.txtNfacture.TabIndex = 3;
            // 
            // lblNfacture
            // 
            this.lblNfacture.AutoSize = true;
            this.lblNfacture.Location = new System.Drawing.Point(14, 194);
            this.lblNfacture.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblNfacture.Name = "lblNfacture";
            this.lblNfacture.Size = new System.Drawing.Size(150, 29);
            this.lblNfacture.TabIndex = 2;
            this.lblNfacture.Text = "N FACTURE";
            // 
            // txtQuantite
            // 
            this.txtQuantite.Location = new System.Drawing.Point(329, 228);
            this.txtQuantite.Margin = new System.Windows.Forms.Padding(5);
            this.txtQuantite.Name = "txtQuantite";
            this.txtQuantite.Size = new System.Drawing.Size(237, 34);
            this.txtQuantite.TabIndex = 5;
            // 
            // lblQuantite
            // 
            this.lblQuantite.AutoSize = true;
            this.lblQuantite.Location = new System.Drawing.Point(324, 194);
            this.lblQuantite.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblQuantite.Name = "lblQuantite";
            this.lblQuantite.Size = new System.Drawing.Size(136, 29);
            this.lblQuantite.TabIndex = 4;
            this.lblQuantite.Text = "QUANTITE";
            // 
            // txtFournisseur
            // 
            this.txtFournisseur.Location = new System.Drawing.Point(14, 424);
            this.txtFournisseur.Margin = new System.Windows.Forms.Padding(5);
            this.txtFournisseur.Name = "txtFournisseur";
            this.txtFournisseur.Size = new System.Drawing.Size(547, 34);
            this.txtFournisseur.TabIndex = 7;
            // 
            // lblFournisseur
            // 
            this.lblFournisseur.AutoSize = true;
            this.lblFournisseur.Location = new System.Drawing.Point(9, 390);
            this.lblFournisseur.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblFournisseur.Name = "lblFournisseur";
            this.lblFournisseur.Size = new System.Drawing.Size(187, 29);
            this.lblFournisseur.TabIndex = 6;
            this.lblFournisseur.Text = "FOURNISSEUR";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(14, 517);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(367, 34);
            this.dateTimePicker1.TabIndex = 8;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(19, 485);
            this.lblDate.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(77, 29);
            this.lblDate.TabIndex = 9;
            this.lblDate.Text = "DATE";
            // 
            // txtDesignation
            // 
            this.txtDesignation.Location = new System.Drawing.Point(19, 333);
            this.txtDesignation.Margin = new System.Windows.Forms.Padding(5);
            this.txtDesignation.Name = "txtDesignation";
            this.txtDesignation.Size = new System.Drawing.Size(547, 34);
            this.txtDesignation.TabIndex = 11;
            // 
            // lblDesignateur
            // 
            this.lblDesignateur.AutoSize = true;
            this.lblDesignateur.Location = new System.Drawing.Point(14, 299);
            this.lblDesignateur.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblDesignateur.Name = "lblDesignateur";
            this.lblDesignateur.Size = new System.Drawing.Size(185, 29);
            this.lblDesignateur.TabIndex = 10;
            this.lblDesignateur.Text = "DESIGNATEUR";
            // 
            // btnEnregistrer
            // 
            this.btnEnregistrer.Location = new System.Drawing.Point(19, 604);
            this.btnEnregistrer.Name = "btnEnregistrer";
            this.btnEnregistrer.Size = new System.Drawing.Size(223, 66);
            this.btnEnregistrer.TabIndex = 12;
            this.btnEnregistrer.Text = "ENREGISTRER";
            this.btnEnregistrer.UseVisualStyleBackColor = true;
            this.btnEnregistrer.Click += new System.EventHandler(this.btnEnregistrer_Click);
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAnnuler.Location = new System.Drawing.Point(338, 604);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(223, 66);
            this.btnAnnuler.TabIndex = 13;
            this.btnAnnuler.Text = "ANNULER";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(47, 44);
            this.button1.TabIndex = 14;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Achat
            // 
            this.AcceptButton = this.btnEnregistrer;
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnAnnuler;
            this.ClientSize = new System.Drawing.Size(639, 741);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.btnEnregistrer);
            this.Controls.Add(this.txtDesignation);
            this.Controls.Add(this.lblDesignateur);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.txtFournisseur);
            this.Controls.Add(this.lblFournisseur);
            this.Controls.Add(this.txtQuantite);
            this.Controls.Add(this.lblQuantite);
            this.Controls.Add(this.txtNfacture);
            this.Controls.Add(this.lblNfacture);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.lblCode);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Achat";
            this.Text = "Achat";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.TextBox txtNfacture;
        private System.Windows.Forms.Label lblNfacture;
        private System.Windows.Forms.TextBox txtQuantite;
        private System.Windows.Forms.Label lblQuantite;
        private System.Windows.Forms.TextBox txtFournisseur;
        private System.Windows.Forms.Label lblFournisseur;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.TextBox txtDesignation;
        private System.Windows.Forms.Label lblDesignateur;
        private System.Windows.Forms.Button btnEnregistrer;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Button button1;
    }
}