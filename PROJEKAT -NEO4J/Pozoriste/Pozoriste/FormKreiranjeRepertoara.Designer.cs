namespace Pozoriste
{
    partial class FormKreiranjeRepertoara
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormKreiranjeRepertoara));
            this.btnPredstave = new System.Windows.Forms.Button();
            this.listPredstave = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listRepertoar = new System.Windows.Forms.ListBox();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.btnVrati = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lblDatum = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnUcitajRepertoare = new System.Windows.Forms.Button();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.btnKreirajPrikaz = new System.Windows.Forms.Button();
            this.cbSala = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCena = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPredstave
            // 
            this.btnPredstave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPredstave.Location = new System.Drawing.Point(23, 12);
            this.btnPredstave.Name = "btnPredstave";
            this.btnPredstave.Size = new System.Drawing.Size(141, 35);
            this.btnPredstave.TabIndex = 0;
            this.btnPredstave.Text = "Ucitaj predstave";
            this.btnPredstave.UseVisualStyleBackColor = true;
            this.btnPredstave.Click += new System.EventHandler(this.btnPredstave_Click);
            // 
            // listPredstave
            // 
            this.listPredstave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listPredstave.FormattingEnabled = true;
            this.listPredstave.ItemHeight = 16;
            this.listPredstave.Location = new System.Drawing.Point(23, 83);
            this.listPredstave.Name = "listPredstave";
            this.listPredstave.Size = new System.Drawing.Size(141, 116);
            this.listPredstave.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Predstave:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(230, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Repertoar:";
            // 
            // listRepertoar
            // 
            this.listRepertoar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listRepertoar.FormattingEnabled = true;
            this.listRepertoar.ItemHeight = 16;
            this.listRepertoar.Location = new System.Drawing.Point(233, 83);
            this.listRepertoar.Name = "listRepertoar";
            this.listRepertoar.Size = new System.Drawing.Size(141, 116);
            this.listRepertoar.TabIndex = 4;
            // 
            // btnDodaj
            // 
            this.btnDodaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodaj.Location = new System.Drawing.Point(170, 83);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(57, 40);
            this.btnDodaj.TabIndex = 5;
            this.btnDodaj.Text = ">";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // btnVrati
            // 
            this.btnVrati.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVrati.Location = new System.Drawing.Point(170, 129);
            this.btnVrati.Name = "btnVrati";
            this.btnVrati.Size = new System.Drawing.Size(57, 43);
            this.btnVrati.TabIndex = 6;
            this.btnVrati.Text = "<";
            this.btnVrati.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(23, 260);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 44);
            this.button1.TabIndex = 7;
            this.button1.Text = "Kreiraj Repertoar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "yyyy/MM/dd";
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(23, 230);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(168, 24);
            this.dateTimePicker1.TabIndex = 15;
            // 
            // lblDatum
            // 
            this.lblDatum.AutoSize = true;
            this.lblDatum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatum.Location = new System.Drawing.Point(20, 212);
            this.lblDatum.Name = "lblDatum";
            this.lblDatum.Size = new System.Drawing.Size(171, 15);
            this.lblDatum.TabIndex = 16;
            this.lblDatum.Text = "Datum prikaza repertoara";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Linen;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.btnUcitajRepertoare);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(394, 65);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(293, 231);
            this.panel1.TabIndex = 17;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.MenuBar;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 52);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 50;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(283, 172);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // btnUcitajRepertoare
            // 
            this.btnUcitajRepertoare.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUcitajRepertoare.Location = new System.Drawing.Point(67, 19);
            this.btnUcitajRepertoare.Name = "btnUcitajRepertoare";
            this.btnUcitajRepertoare.Size = new System.Drawing.Size(159, 27);
            this.btnUcitajRepertoare.TabIndex = 1;
            this.btnUcitajRepertoare.Text = "Ucitaj Sve repertoare";
            this.btnUcitajRepertoare.UseVisualStyleBackColor = true;
            this.btnUcitajRepertoare.Click += new System.EventHandler(this.btnUcitajRepertoare_Click);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CustomFormat = "HH:mm";
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(11, 184);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(120, 20);
            this.dateTimePicker2.TabIndex = 18;
            this.dateTimePicker2.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // btnKreirajPrikaz
            // 
            this.btnKreirajPrikaz.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnKreirajPrikaz.Location = new System.Drawing.Point(11, 249);
            this.btnKreirajPrikaz.Name = "btnKreirajPrikaz";
            this.btnKreirajPrikaz.Size = new System.Drawing.Size(92, 44);
            this.btnKreirajPrikaz.TabIndex = 19;
            this.btnKreirajPrikaz.Text = "Kreiraj prikaz";
            this.btnKreirajPrikaz.UseVisualStyleBackColor = true;
            this.btnKreirajPrikaz.Click += new System.EventHandler(this.btnKreirajPrikaz_Click);
            // 
            // cbSala
            // 
            this.cbSala.FormattingEnabled = true;
            this.cbSala.Location = new System.Drawing.Point(11, 89);
            this.cbSala.Name = "cbSala";
            this.cbSala.Size = new System.Drawing.Size(121, 21);
            this.cbSala.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Sala";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Cena karte:";
            // 
            // txtCena
            // 
            this.txtCena.Location = new System.Drawing.Point(12, 223);
            this.txtCena.Name = "txtCena";
            this.txtCena.Size = new System.Drawing.Size(100, 20);
            this.txtCena.TabIndex = 23;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.dateTimePicker3);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnKreirajPrikaz);
            this.groupBox1.Controls.Add(this.txtCena);
            this.groupBox1.Controls.Add(this.cbSala);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.dateTimePicker2);
            this.groupBox1.Location = new System.Drawing.Point(217, 205);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(157, 299);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(9, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 47);
            this.label5.TabIndex = 24;
            this.label5.Text = "Za kreiranje prikaza izaberite predstavu iz liste predstava.";
            // 
            // dateTimePicker3
            // 
            this.dateTimePicker3.CustomFormat = "yyyy/MM/dd";
            this.dateTimePicker3.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker3.Location = new System.Drawing.Point(12, 135);
            this.dateTimePicker3.Name = "dateTimePicker3";
            this.dateTimePicker3.Size = new System.Drawing.Size(119, 20);
            this.dateTimePicker3.TabIndex = 25;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 119);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 26;
            this.label6.Text = "Datum:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 168);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 27;
            this.label7.Text = "Vreme:";
            // 
            // FormKreiranjeRepertoara
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 509);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblDatum);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnVrati);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.listRepertoar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listPredstave);
            this.Controls.Add(this.btnPredstave);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormKreiranjeRepertoara";
            this.Text = "Kreiranje Repertoara";
            this.Load += new System.EventHandler(this.FormKreiranjeRepertoara_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPredstave;
        private System.Windows.Forms.ListBox listPredstave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listRepertoar;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Button btnVrati;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lblDatum;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnUcitajRepertoare;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Button btnKreirajPrikaz;
        private System.Windows.Forms.ComboBox cbSala;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCena;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateTimePicker3;
    }
}