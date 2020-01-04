namespace Pozoriste
{
    partial class FormAdmin
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
            this.btnZaposleni = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnGlumci = new System.Windows.Forms.Button();
            this.btnReziseri = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnRepertoar = new System.Windows.Forms.Button();
            this.btnDodajGlumca = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtIme = new System.Windows.Forms.TextBox();
            this.txtZaposlen = new System.Windows.Forms.TextBox();
            this.cbPredstave = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnDodajG = new System.Windows.Forms.Button();
            this.btnObrisiGlumca = new System.Windows.Forms.Button();
            this.btnObrisiZaposlenog = new System.Windows.Forms.Button();
            this.btnDodajRezisera = new System.Windows.Forms.Button();
            this.btnObrisiRezisera = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnZaposleni
            // 
            this.btnZaposleni.Location = new System.Drawing.Point(3, 12);
            this.btnZaposleni.Name = "btnZaposleni";
            this.btnZaposleni.Size = new System.Drawing.Size(75, 23);
            this.btnZaposleni.TabIndex = 0;
            this.btnZaposleni.Text = "Zaposleni";
            this.btnZaposleni.UseVisualStyleBackColor = true;
            this.btnZaposleni.Click += new System.EventHandler(this.btnZaposleni_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(176, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(539, 260);
            this.dataGridView1.TabIndex = 1;
            // 
            // btnGlumci
            // 
            this.btnGlumci.Location = new System.Drawing.Point(735, 12);
            this.btnGlumci.Name = "btnGlumci";
            this.btnGlumci.Size = new System.Drawing.Size(75, 23);
            this.btnGlumci.TabIndex = 2;
            this.btnGlumci.Text = "Glumci";
            this.btnGlumci.UseVisualStyleBackColor = true;
            this.btnGlumci.Click += new System.EventHandler(this.btnGlumci_Click);
            // 
            // btnReziseri
            // 
            this.btnReziseri.Location = new System.Drawing.Point(3, 141);
            this.btnReziseri.Name = "btnReziseri";
            this.btnReziseri.Size = new System.Drawing.Size(75, 23);
            this.btnReziseri.TabIndex = 3;
            this.btnReziseri.Text = "Reziseri";
            this.btnReziseri.UseVisualStyleBackColor = true;
            this.btnReziseri.Click += new System.EventHandler(this.btnReziseri_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 41);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Dodaj zaposlenog";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnRepertoar
            // 
            this.btnRepertoar.Location = new System.Drawing.Point(3, 266);
            this.btnRepertoar.Name = "btnRepertoar";
            this.btnRepertoar.Size = new System.Drawing.Size(107, 23);
            this.btnRepertoar.TabIndex = 5;
            this.btnRepertoar.Text = "Kreiraj repertoar";
            this.btnRepertoar.UseVisualStyleBackColor = true;
            this.btnRepertoar.Click += new System.EventHandler(this.btnRepertoar_Click);
            // 
            // btnDodajGlumca
            // 
            this.btnDodajGlumca.Location = new System.Drawing.Point(735, 41);
            this.btnDodajGlumca.Name = "btnDodajGlumca";
            this.btnDodajGlumca.Size = new System.Drawing.Size(97, 23);
            this.btnDodajGlumca.TabIndex = 6;
            this.btnDodajGlumca.Text = "Dodaj glumca";
            this.btnDodajGlumca.UseVisualStyleBackColor = true;
            this.btnDodajGlumca.Click += new System.EventHandler(this.btnDodajGlumca_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(739, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Ime i prezime:";
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(740, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Datum rodjenja:";
            this.label2.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(740, 209);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Zaposlen (godina):";
            this.label3.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(740, 252);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Broj odigranih predstava:";
            this.label4.Visible = false;
            // 
            // txtIme
            // 
            this.txtIme.Location = new System.Drawing.Point(742, 141);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(100, 20);
            this.txtIme.TabIndex = 11;
            this.txtIme.Visible = false;
            // 
            // txtZaposlen
            // 
            this.txtZaposlen.Location = new System.Drawing.Point(743, 226);
            this.txtZaposlen.Name = "txtZaposlen";
            this.txtZaposlen.Size = new System.Drawing.Size(100, 20);
            this.txtZaposlen.TabIndex = 12;
            this.txtZaposlen.Visible = false;
            // 
            // cbPredstave
            // 
            this.cbPredstave.FormattingEnabled = true;
            this.cbPredstave.Location = new System.Drawing.Point(743, 268);
            this.cbPredstave.Name = "cbPredstave";
            this.cbPredstave.Size = new System.Drawing.Size(47, 21);
            this.cbPredstave.TabIndex = 13;
            this.cbPredstave.Visible = false;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "yyyy/MM/dd";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(742, 180);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 14;
            this.dateTimePicker1.Visible = false;
            // 
            // btnDodajG
            // 
            this.btnDodajG.Location = new System.Drawing.Point(743, 295);
            this.btnDodajG.Name = "btnDodajG";
            this.btnDodajG.Size = new System.Drawing.Size(75, 23);
            this.btnDodajG.TabIndex = 15;
            this.btnDodajG.Text = "DODAJ";
            this.btnDodajG.UseVisualStyleBackColor = true;
            this.btnDodajG.Visible = false;
            this.btnDodajG.Click += new System.EventHandler(this.btnDodajG_Click);
            // 
            // btnObrisiGlumca
            // 
            this.btnObrisiGlumca.Location = new System.Drawing.Point(735, 70);
            this.btnObrisiGlumca.Name = "btnObrisiGlumca";
            this.btnObrisiGlumca.Size = new System.Drawing.Size(75, 23);
            this.btnObrisiGlumca.TabIndex = 16;
            this.btnObrisiGlumca.Text = "Obrisi glumca";
            this.btnObrisiGlumca.UseVisualStyleBackColor = true;
            this.btnObrisiGlumca.Click += new System.EventHandler(this.btnObrisiGlumca_Click);
            // 
            // btnObrisiZaposlenog
            // 
            this.btnObrisiZaposlenog.Location = new System.Drawing.Point(3, 70);
            this.btnObrisiZaposlenog.Name = "btnObrisiZaposlenog";
            this.btnObrisiZaposlenog.Size = new System.Drawing.Size(107, 23);
            this.btnObrisiZaposlenog.TabIndex = 17;
            this.btnObrisiZaposlenog.Text = "Obrisi zaposlenog";
            this.btnObrisiZaposlenog.UseVisualStyleBackColor = true;
            this.btnObrisiZaposlenog.Click += new System.EventHandler(this.btnObrisiZaposlenog_Click);
            // 
            // btnDodajRezisera
            // 
            this.btnDodajRezisera.Location = new System.Drawing.Point(3, 170);
            this.btnDodajRezisera.Name = "btnDodajRezisera";
            this.btnDodajRezisera.Size = new System.Drawing.Size(97, 23);
            this.btnDodajRezisera.TabIndex = 18;
            this.btnDodajRezisera.Text = "Dodaj rezisera";
            this.btnDodajRezisera.UseVisualStyleBackColor = true;
            this.btnDodajRezisera.Click += new System.EventHandler(this.btnDodajRezisera_Click);
            // 
            // btnObrisiRezisera
            // 
            this.btnObrisiRezisera.Location = new System.Drawing.Point(3, 199);
            this.btnObrisiRezisera.Name = "btnObrisiRezisera";
            this.btnObrisiRezisera.Size = new System.Drawing.Size(97, 23);
            this.btnObrisiRezisera.TabIndex = 19;
            this.btnObrisiRezisera.Text = "Obrisi rezisera";
            this.btnObrisiRezisera.UseVisualStyleBackColor = true;
            this.btnObrisiRezisera.Click += new System.EventHandler(this.btnObrisiRezisera_Click);
            // 
            // FormAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 341);
            this.Controls.Add(this.btnObrisiRezisera);
            this.Controls.Add(this.btnDodajRezisera);
            this.Controls.Add(this.btnObrisiZaposlenog);
            this.Controls.Add(this.btnObrisiGlumca);
            this.Controls.Add(this.btnDodajG);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.cbPredstave);
            this.Controls.Add(this.txtZaposlen);
            this.Controls.Add(this.txtIme);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDodajGlumca);
            this.Controls.Add(this.btnRepertoar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnReziseri);
            this.Controls.Add(this.btnGlumci);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnZaposleni);
            this.Name = "FormAdmin";
            this.Text = "FormAdmin";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnZaposleni;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnGlumci;
        private System.Windows.Forms.Button btnReziseri;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnRepertoar;
        private System.Windows.Forms.Button btnDodajGlumca;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.TextBox txtZaposlen;
        private System.Windows.Forms.ComboBox cbPredstave;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnDodajG;
        private System.Windows.Forms.Button btnObrisiGlumca;
        private System.Windows.Forms.Button btnObrisiZaposlenog;
        private System.Windows.Forms.Button btnDodajRezisera;
        private System.Windows.Forms.Button btnObrisiRezisera;
    }
}