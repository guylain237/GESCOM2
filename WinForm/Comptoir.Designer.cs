
namespace WinForm
{
    partial class Comptoir
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.count = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.buttactu = new System.Windows.Forms.Button();
            this.buttimp = new System.Windows.Forms.Button();
            this.buttsup = new System.Windows.Forms.Button();
            this.buttmodif = new System.Windows.Forms.Button();
            this.textTOTAL = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textTVA = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textCODE = new System.Windows.Forms.TextBox();
            this.labcode = new System.Windows.Forms.Label();
            this.textPRIX = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textQUANTITE = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textsearch = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textDESIGNATION = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttajout = new System.Windows.Forms.Button();
            this.CODE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::WinForm.Properties.Resources.images;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.count);
            this.panel1.Controls.Add(this.dateTimePicker2);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.buttactu);
            this.panel1.Controls.Add(this.buttimp);
            this.panel1.Controls.Add(this.buttsup);
            this.panel1.Controls.Add(this.buttmodif);
            this.panel1.Controls.Add(this.textTOTAL);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.textTVA);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.textCODE);
            this.panel1.Controls.Add(this.labcode);
            this.panel1.Controls.Add(this.textPRIX);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.textQUANTITE);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.textsearch);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.textDESIGNATION);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.buttajout);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1527, 729);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // count
            // 
            this.count.AutoSize = true;
            this.count.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.count.Location = new System.Drawing.Point(800, 698);
            this.count.Name = "count";
            this.count.Size = new System.Drawing.Size(84, 25);
            this.count.TabIndex = 45;
            this.count.Text = "COUNT";
            this.count.Visible = false;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Checked = false;
            this.dateTimePicker2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(389, 94);
            this.dateTimePicker2.Margin = new System.Windows.Forms.Padding(5);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.ShowCheckBox = true;
            this.dateTimePicker2.Size = new System.Drawing.Size(356, 30);
            this.dateTimePicker2.TabIndex = 44;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(387, 69);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 25);
            this.label8.TabIndex = 42;
            this.label8.Text = "DATE";
            // 
            // buttactu
            // 
            this.buttactu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttactu.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttactu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttactu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttactu.ForeColor = System.Drawing.Color.Yellow;
            this.buttactu.Image = global::WinForm.Properties.Resources.actu;
            this.buttactu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttactu.Location = new System.Drawing.Point(611, 682);
            this.buttactu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttactu.Name = "buttactu";
            this.buttactu.Size = new System.Drawing.Size(156, 36);
            this.buttactu.TabIndex = 41;
            this.buttactu.Text = " Actualiser";
            this.buttactu.UseVisualStyleBackColor = true;
            // 
            // buttimp
            // 
            this.buttimp.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.buttimp.BackgroundImage = global::WinForm.Properties.Resources.print1;
            this.buttimp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttimp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttimp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttimp.Location = new System.Drawing.Point(483, 431);
            this.buttimp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttimp.Name = "buttimp";
            this.buttimp.Size = new System.Drawing.Size(239, 194);
            this.buttimp.TabIndex = 40;
            this.buttimp.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.buttimp.UseVisualStyleBackColor = true;
            // 
            // buttsup
            // 
            this.buttsup.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttsup.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.buttsup.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.buttsup.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttsup.ForeColor = System.Drawing.Color.Red;
            this.buttsup.Image = global::WinForm.Properties.Resources.s;
            this.buttsup.Location = new System.Drawing.Point(399, 681);
            this.buttsup.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttsup.Name = "buttsup";
            this.buttsup.Size = new System.Drawing.Size(164, 36);
            this.buttsup.TabIndex = 39;
            this.buttsup.Text = "Supprimer";
            this.buttsup.UseVisualStyleBackColor = true;
            // 
            // buttmodif
            // 
            this.buttmodif.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttmodif.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.buttmodif.FlatAppearance.BorderSize = 0;
            this.buttmodif.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.buttmodif.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttmodif.ForeColor = System.Drawing.Color.Magenta;
            this.buttmodif.Image = global::WinForm.Properties.Resources.m;
            this.buttmodif.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttmodif.Location = new System.Drawing.Point(212, 681);
            this.buttmodif.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttmodif.Name = "buttmodif";
            this.buttmodif.Size = new System.Drawing.Size(149, 36);
            this.buttmodif.TabIndex = 38;
            this.buttmodif.Text = "Modifier";
            this.buttmodif.UseVisualStyleBackColor = true;
            // 
            // textTOTAL
            // 
            this.textTOTAL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textTOTAL.Location = new System.Drawing.Point(12, 431);
            this.textTOTAL.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textTOTAL.Name = "textTOTAL";
            this.textTOTAL.Size = new System.Drawing.Size(279, 30);
            this.textTOTAL.TabIndex = 6;
            this.textTOTAL.Text = "en fcfa";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(7, 393);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(169, 25);
            this.label7.TabIndex = 36;
            this.label7.Text = "TOTAL A PAYER";
            // 
            // textTVA
            // 
            this.textTVA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textTVA.Location = new System.Drawing.Point(389, 313);
            this.textTVA.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textTVA.Name = "textTVA";
            this.textTVA.Size = new System.Drawing.Size(356, 30);
            this.textTVA.TabIndex = 5;
            this.textTVA.Text = "00,0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(387, 284);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 25);
            this.label6.TabIndex = 34;
            this.label6.Text = "TVA";
            // 
            // textCODE
            // 
            this.textCODE.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textCODE.Location = new System.Drawing.Point(20, 94);
            this.textCODE.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textCODE.Name = "textCODE";
            this.textCODE.Size = new System.Drawing.Size(103, 30);
            this.textCODE.TabIndex = 1;
            // 
            // labcode
            // 
            this.labcode.AutoSize = true;
            this.labcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labcode.Location = new System.Drawing.Point(19, 65);
            this.labcode.Name = "labcode";
            this.labcode.Size = new System.Drawing.Size(70, 25);
            this.labcode.TabIndex = 32;
            this.labcode.Text = "CODE";
            // 
            // textPRIX
            // 
            this.textPRIX.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textPRIX.Location = new System.Drawing.Point(20, 313);
            this.textPRIX.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textPRIX.Name = "textPRIX";
            this.textPRIX.Size = new System.Drawing.Size(271, 30);
            this.textPRIX.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(21, 284);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 25);
            this.label4.TabIndex = 30;
            this.label4.Text = "PRIX";
            // 
            // textQUANTITE
            // 
            this.textQUANTITE.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textQUANTITE.Location = new System.Drawing.Point(389, 185);
            this.textQUANTITE.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textQUANTITE.Name = "textQUANTITE";
            this.textQUANTITE.Size = new System.Drawing.Size(356, 30);
            this.textQUANTITE.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(387, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 25);
            this.label3.TabIndex = 28;
            this.label3.Text = "QUANTITE";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // textsearch
            // 
            this.textsearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textsearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textsearch.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.textsearch.Location = new System.Drawing.Point(796, 38);
            this.textsearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textsearch.Name = "textsearch";
            this.textsearch.Size = new System.Drawing.Size(705, 30);
            this.textsearch.TabIndex = 27;
            this.textsearch.Text = "RECHERCHE";
            this.textsearch.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.NullValue = null;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Lime;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CODE,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dataGridView1.Location = new System.Drawing.Point(796, 72);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(716, 624);
            this.dataGridView1.TabIndex = 8;
            // 
            // textDESIGNATION
            // 
            this.textDESIGNATION.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textDESIGNATION.Location = new System.Drawing.Point(20, 185);
            this.textDESIGNATION.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textDESIGNATION.Name = "textDESIGNATION";
            this.textDESIGNATION.Size = new System.Drawing.Size(271, 30);
            this.textDESIGNATION.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 156);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 25);
            this.label1.TabIndex = 23;
            this.label1.Text = "DESIGNATION";
            // 
            // buttajout
            // 
            this.buttajout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttajout.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.buttajout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.buttajout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttajout.ForeColor = System.Drawing.Color.Lime;
            this.buttajout.Image = global::WinForm.Properties.Resources.n;
            this.buttajout.Location = new System.Drawing.Point(20, 682);
            this.buttajout.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttajout.Name = "buttajout";
            this.buttajout.Size = new System.Drawing.Size(144, 36);
            this.buttajout.TabIndex = 7;
            this.buttajout.Text = "Ajouter";
            this.buttajout.UseVisualStyleBackColor = true;
            this.buttajout.Click += new System.EventHandler(this.buttajout_Click);
            // 
            // CODE
            // 
            this.CODE.DataPropertyName = "Code";
            this.CODE.HeaderText = "CODE";
            this.CODE.MinimumWidth = 6;
            this.CODE.Name = "CODE";
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Designation";
            this.Column1.HeaderText = "DESIGNATION";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Quantite";
            this.Column2.HeaderText = "QUANTITE";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Prix";
            this.Column3.HeaderText = "PRIX";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "TVA";
            this.Column4.HeaderText = "TVA";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "TOTAL";
            this.Column5.HeaderText = "TOTAL A PAYER";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "Date";
            this.Column6.HeaderText = "DATE";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            // 
            // Comptoir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WinForm.Properties.Resources.aaaaa;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1527, 729);
            this.Controls.Add(this.panel1);
            this.ImeMode = System.Windows.Forms.ImeMode.On;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Comptoir";
            this.Text = "Comptoir";
            this.Load += new System.EventHandler(this.Comptoir_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button buttactu;
        private System.Windows.Forms.Button buttimp;
        private System.Windows.Forms.Button buttsup;
        private System.Windows.Forms.Button buttmodif;
        private System.Windows.Forms.TextBox textTOTAL;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textTVA;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textCODE;
        private System.Windows.Forms.Label labcode;
        private System.Windows.Forms.TextBox textPRIX;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textQUANTITE;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textsearch;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textDESIGNATION;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttajout;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label count;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODE;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
    }
}