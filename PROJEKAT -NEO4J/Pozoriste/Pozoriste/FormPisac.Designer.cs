namespace Pozoriste
{
    partial class FormPisac
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPisac));
            this.btnUcitajPisce = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblUputsvo = new System.Windows.Forms.Label();
            this.btnDodajPisca = new System.Windows.Forms.Button();
            this.btnNovPisac = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtBrojDela = new System.Windows.Forms.TextBox();
            this.txtIme = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnObrisiPisca = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnUcitajPisce
            // 
            this.btnUcitajPisce.BackColor = System.Drawing.Color.Ivory;
            this.btnUcitajPisce.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUcitajPisce.Location = new System.Drawing.Point(12, 12);
            this.btnUcitajPisce.Name = "btnUcitajPisce";
            this.btnUcitajPisce.Size = new System.Drawing.Size(118, 25);
            this.btnUcitajPisce.TabIndex = 0;
            this.btnUcitajPisce.Text = "Ucitaj pisce";
            this.btnUcitajPisce.UseVisualStyleBackColor = false;
            this.btnUcitajPisce.Click += new System.EventHandler(this.btnUcitajPisce_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.Location = new System.Drawing.Point(20, 69);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dataGridView1.RowHeadersWidth = 45;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(198, 161);
            this.dataGridView1.TabIndex = 1;
            // 
            // lblUputsvo
            // 
            this.lblUputsvo.AutoSize = true;
            this.lblUputsvo.Location = new System.Drawing.Point(12, 50);
            this.lblUputsvo.Name = "lblUputsvo";
            this.lblUputsvo.Size = new System.Drawing.Size(20, 16);
            this.lblUputsvo.TabIndex = 2;
            this.lblUputsvo.Text = "aa";
            // 
            // btnDodajPisca
            // 
            this.btnDodajPisca.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDodajPisca.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDodajPisca.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodajPisca.ForeColor = System.Drawing.Color.Yellow;
            this.btnDodajPisca.Location = new System.Drawing.Point(34, 236);
            this.btnDodajPisca.Name = "btnDodajPisca";
            this.btnDodajPisca.Size = new System.Drawing.Size(156, 29);
            this.btnDodajPisca.TabIndex = 3;
            this.btnDodajPisca.Text = "Dodaj pisca dela";
            this.btnDodajPisca.UseVisualStyleBackColor = false;
            this.btnDodajPisca.Click += new System.EventHandler(this.btnDodajPisca_Click);
            // 
            // btnNovPisac
            // 
            this.btnNovPisac.BackColor = System.Drawing.Color.Ivory;
            this.btnNovPisac.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovPisac.Location = new System.Drawing.Point(41, 95);
            this.btnNovPisac.Name = "btnNovPisac";
            this.btnNovPisac.Size = new System.Drawing.Size(151, 26);
            this.btnNovPisac.TabIndex = 4;
            this.btnNovPisac.Text = "Dodaj novog pisca";
            this.btnNovPisac.UseVisualStyleBackColor = false;
            this.btnNovPisac.Click += new System.EventHandler(this.btnNovPisac_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.txtBrojDela);
            this.panel1.Controls.Add(this.txtIme);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnNovPisac);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(241, 88);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(234, 142);
            this.panel1.TabIndex = 5;
            // 
            // txtBrojDela
            // 
            this.txtBrojDela.Location = new System.Drawing.Point(102, 48);
            this.txtBrojDela.Name = "txtBrojDela";
            this.txtBrojDela.Size = new System.Drawing.Size(125, 23);
            this.txtBrojDela.TabIndex = 6;
            this.txtBrojDela.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBrojDela_KeyPress);
            // 
            // txtIme
            // 
            this.txtIme.Location = new System.Drawing.Point(102, 16);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(125, 23);
            this.txtIme.TabIndex = 5;
            this.txtIme.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIme_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Broj dela:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ime i Prezime:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(238, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(182, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Ovde mozete dodati novog pisca";
            // 
            // btnObrisiPisca
            // 
            this.btnObrisiPisca.BackColor = System.Drawing.Color.Ivory;
            this.btnObrisiPisca.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnObrisiPisca.Location = new System.Drawing.Point(136, 12);
            this.btnObrisiPisca.Name = "btnObrisiPisca";
            this.btnObrisiPisca.Size = new System.Drawing.Size(118, 25);
            this.btnObrisiPisca.TabIndex = 7;
            this.btnObrisiPisca.Text = "Obrisi pisca";
            this.btnObrisiPisca.UseVisualStyleBackColor = false;
            this.btnObrisiPisca.Click += new System.EventHandler(this.btnObrisiPisca_Click);
            // 
            // FormPisac
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.ClientSize = new System.Drawing.Size(487, 277);
            this.Controls.Add(this.btnObrisiPisca);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnDodajPisca);
            this.Controls.Add(this.lblUputsvo);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnUcitajPisce);
            this.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "FormPisac";
            this.Text = "Pisci predstava";
            this.Load += new System.EventHandler(this.FormPisac_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUcitajPisce;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblUputsvo;
        private System.Windows.Forms.Button btnDodajPisca;
        private System.Windows.Forms.Button btnNovPisac;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtBrojDela;
        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnObrisiPisca;
    }
}