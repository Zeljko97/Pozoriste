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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAdmin));
            this.btnZaposleni = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnGlumci = new System.Windows.Forms.Button();
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
            this.Rezirao = new System.Windows.Forms.ToolTip(this.components);
            this.btnReziraj = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnUpdateZaposleni = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnDodeliUlogu = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.listPredstave = new System.Windows.Forms.ListBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.btnReziseri = new System.Windows.Forms.Button();
            this.btnPredstave = new System.Windows.Forms.Button();
            this.btnDodajRezisera = new System.Windows.Forms.Button();
            this.btnObrisiRezisera = new System.Windows.Forms.Button();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnObrisiSalu = new System.Windows.Forms.Button();
            this.btnDodajSalu = new System.Windows.Forms.Button();
            this.btnPrikaziSale = new System.Windows.Forms.Button();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.dataGridView5 = new System.Windows.Forms.DataGridView();
            this.btnDodajPisca = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDodajPredstavu = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnPrikaziPredstave = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.ttDodelaUloge = new System.Windows.Forms.ToolTip(this.components);
            this.ttRepertoar = new System.Windows.Forms.ToolTip(this.components);
            this.ttPisac = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).BeginInit();
            this.SuspendLayout();
            // 
            // btnZaposleni
            // 
            this.btnZaposleni.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnZaposleni.Location = new System.Drawing.Point(10, 27);
            this.btnZaposleni.Name = "btnZaposleni";
            this.btnZaposleni.Size = new System.Drawing.Size(125, 27);
            this.btnZaposleni.TabIndex = 0;
            this.btnZaposleni.Text = "Prikazi Zaposlene";
            this.btnZaposleni.UseVisualStyleBackColor = true;
            this.btnZaposleni.Click += new System.EventHandler(this.btnZaposleni_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.MenuBar;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(153, 9);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dataGridView1.Size = new System.Drawing.Size(592, 144);
            this.dataGridView1.TabIndex = 1;
            // 
            // btnGlumci
            // 
            this.btnGlumci.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGlumci.Location = new System.Drawing.Point(13, 23);
            this.btnGlumci.Name = "btnGlumci";
            this.btnGlumci.Size = new System.Drawing.Size(124, 27);
            this.btnGlumci.TabIndex = 2;
            this.btnGlumci.Text = "Prikazi Glumce";
            this.btnGlumci.UseVisualStyleBackColor = true;
            this.btnGlumci.Click += new System.EventHandler(this.btnGlumci_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(10, 60);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 27);
            this.button1.TabIndex = 4;
            this.button1.Text = "Dodaj zaposlenog";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnRepertoar
            // 
            this.btnRepertoar.BackColor = System.Drawing.Color.Bisque;
            this.btnRepertoar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRepertoar.Location = new System.Drawing.Point(256, 36);
            this.btnRepertoar.Name = "btnRepertoar";
            this.btnRepertoar.Size = new System.Drawing.Size(112, 40);
            this.btnRepertoar.TabIndex = 5;
            this.btnRepertoar.Text = "Kreiraj repertoar";
            this.ttRepertoar.SetToolTip(this.btnRepertoar, "Omoguceno je kreiranje repertoara prikaza predstava za selektovani datum");
            this.btnRepertoar.UseVisualStyleBackColor = false;
            this.btnRepertoar.Click += new System.EventHandler(this.btnRepertoar_Click);
            // 
            // btnDodajGlumca
            // 
            this.btnDodajGlumca.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodajGlumca.Location = new System.Drawing.Point(13, 56);
            this.btnDodajGlumca.Name = "btnDodajGlumca";
            this.btnDodajGlumca.Size = new System.Drawing.Size(124, 27);
            this.btnDodajGlumca.TabIndex = 6;
            this.btnDodajGlumca.Text = "Dodaj glumca";
            this.btnDodajGlumca.UseVisualStyleBackColor = true;
            this.btnDodajGlumca.Click += new System.EventHandler(this.btnDodajGlumca_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 151);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Ime i prezime:";
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Datum rodjenja:";
            this.label2.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 235);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "Zaposlen (godina):";
            this.label3.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(7, 279);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "Broj odigranih predstava:";
            this.label4.Visible = false;
            // 
            // txtIme
            // 
            this.txtIme.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIme.Location = new System.Drawing.Point(13, 169);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(116, 21);
            this.txtIme.TabIndex = 11;
            this.txtIme.Visible = false;
            // 
            // txtZaposlen
            // 
            this.txtZaposlen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtZaposlen.Location = new System.Drawing.Point(13, 255);
            this.txtZaposlen.Name = "txtZaposlen";
            this.txtZaposlen.Size = new System.Drawing.Size(116, 21);
            this.txtZaposlen.TabIndex = 12;
            this.txtZaposlen.Visible = false;
            this.txtZaposlen.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtZaposlen_KeyPress);
            // 
            // cbPredstave
            // 
            this.cbPredstave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPredstave.FormattingEnabled = true;
            this.cbPredstave.Location = new System.Drawing.Point(48, 297);
            this.cbPredstave.Name = "cbPredstave";
            this.cbPredstave.Size = new System.Drawing.Size(54, 23);
            this.cbPredstave.TabIndex = 13;
            this.cbPredstave.Visible = false;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "yyyy/MM/dd";
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(9, 211);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(120, 21);
            this.dateTimePicker1.TabIndex = 14;
            this.dateTimePicker1.Visible = false;
            // 
            // btnDodajG
            // 
            this.btnDodajG.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodajG.Location = new System.Drawing.Point(33, 330);
            this.btnDodajG.Name = "btnDodajG";
            this.btnDodajG.Size = new System.Drawing.Size(87, 27);
            this.btnDodajG.TabIndex = 15;
            this.btnDodajG.Text = "Dodaj";
            this.btnDodajG.UseVisualStyleBackColor = true;
            this.btnDodajG.Visible = false;
            this.btnDodajG.Click += new System.EventHandler(this.btnDodajG_Click);
            // 
            // btnObrisiGlumca
            // 
            this.btnObrisiGlumca.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnObrisiGlumca.Location = new System.Drawing.Point(12, 89);
            this.btnObrisiGlumca.Name = "btnObrisiGlumca";
            this.btnObrisiGlumca.Size = new System.Drawing.Size(124, 27);
            this.btnObrisiGlumca.TabIndex = 16;
            this.btnObrisiGlumca.Text = "Obrisi glumca";
            this.btnObrisiGlumca.UseVisualStyleBackColor = true;
            this.btnObrisiGlumca.Click += new System.EventHandler(this.btnObrisiGlumca_Click);
            // 
            // btnObrisiZaposlenog
            // 
            this.btnObrisiZaposlenog.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnObrisiZaposlenog.Location = new System.Drawing.Point(10, 93);
            this.btnObrisiZaposlenog.Name = "btnObrisiZaposlenog";
            this.btnObrisiZaposlenog.Size = new System.Drawing.Size(125, 27);
            this.btnObrisiZaposlenog.TabIndex = 17;
            this.btnObrisiZaposlenog.Text = "Obrisi zaposlenog";
            this.btnObrisiZaposlenog.UseVisualStyleBackColor = true;
            this.btnObrisiZaposlenog.Click += new System.EventHandler(this.btnObrisiZaposlenog_Click);
            // 
            // btnReziraj
            // 
            this.btnReziraj.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnReziraj.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReziraj.Location = new System.Drawing.Point(208, 123);
            this.btnReziraj.Name = "btnReziraj";
            this.btnReziraj.Size = new System.Drawing.Size(117, 28);
            this.btnReziraj.TabIndex = 23;
            this.btnReziraj.Text = "Rezirao";
            this.Rezirao.SetToolTip(this.btnReziraj, "Neophodno je selektovati rezisera i predstavu koju je rezirao.");
            this.btnReziraj.UseVisualStyleBackColor = false;
            this.btnReziraj.Click += new System.EventHandler(this.btnReziraj_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Silver;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.btnUpdateZaposleni);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.btnZaposleni);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Controls.Add(this.btnObrisiZaposlenog);
            this.panel2.Location = new System.Drawing.Point(12, 14);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(752, 166);
            this.panel2.TabIndex = 22;
            // 
            // btnUpdateZaposleni
            // 
            this.btnUpdateZaposleni.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateZaposleni.Location = new System.Drawing.Point(12, 126);
            this.btnUpdateZaposleni.Name = "btnUpdateZaposleni";
            this.btnUpdateZaposleni.Size = new System.Drawing.Size(125, 27);
            this.btnUpdateZaposleni.TabIndex = 19;
            this.btnUpdateZaposleni.Text = "Update zaposlenog";
            this.btnUpdateZaposleni.UseVisualStyleBackColor = true;
            this.btnUpdateZaposleni.Click += new System.EventHandler(this.btnUpdateZaposleni_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(8, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 16);
            this.label5.TabIndex = 18;
            this.label5.Text = "Zaposleni:";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Silver;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.btnDodeliUlogu);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.btnGlumci);
            this.panel3.Controls.Add(this.btnDodajGlumca);
            this.panel3.Controls.Add(this.btnDodajG);
            this.panel3.Controls.Add(this.btnObrisiGlumca);
            this.panel3.Controls.Add(this.cbPredstave);
            this.panel3.Controls.Add(this.dateTimePicker1);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.txtZaposlen);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.txtIme);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(12, 182);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(153, 364);
            this.panel3.TabIndex = 23;
            // 
            // btnDodeliUlogu
            // 
            this.btnDodeliUlogu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodeliUlogu.Location = new System.Drawing.Point(12, 121);
            this.btnDodeliUlogu.Name = "btnDodeliUlogu";
            this.btnDodeliUlogu.Size = new System.Drawing.Size(124, 27);
            this.btnDodeliUlogu.TabIndex = 20;
            this.btnDodeliUlogu.Text = "Dodeli ulogu";
            this.ttDodelaUloge.SetToolTip(this.btnDodeliUlogu, "Za selektovanog glumca vrsimo dodelu uloge u izbranoj predstavi");
            this.btnDodeliUlogu.UseVisualStyleBackColor = true;
            this.btnDodeliUlogu.Click += new System.EventHandler(this.btnDodeliUlogu_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(10, 4);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 16);
            this.label6.TabIndex = 19;
            this.label6.Text = "Glumci";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.listPredstave);
            this.panel1.Controls.Add(this.dataGridView2);
            this.panel1.Controls.Add(this.btnReziraj);
            this.panel1.Controls.Add(this.btnReziseri);
            this.panel1.Controls.Add(this.btnPredstave);
            this.panel1.Controls.Add(this.btnDodajRezisera);
            this.panel1.Controls.Add(this.btnObrisiRezisera);
            this.panel1.Location = new System.Drawing.Point(171, 377);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(593, 169);
            this.panel1.TabIndex = 25;
            // 
            // listPredstave
            // 
            this.listPredstave.FormattingEnabled = true;
            this.listPredstave.ItemHeight = 15;
            this.listPredstave.Location = new System.Drawing.Point(414, 13);
            this.listPredstave.Name = "listPredstave";
            this.listPredstave.Size = new System.Drawing.Size(162, 94);
            this.listPredstave.TabIndex = 25;
            // 
            // dataGridView2
            // 
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.Info;
            this.dataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(129, 14);
            this.dataGridView2.MultiSelect = false;
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(275, 103);
            this.dataGridView2.TabIndex = 24;
            // 
            // btnReziseri
            // 
            this.btnReziseri.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnReziseri.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReziseri.Location = new System.Drawing.Point(10, 14);
            this.btnReziseri.Name = "btnReziseri";
            this.btnReziseri.Size = new System.Drawing.Size(87, 27);
            this.btnReziseri.TabIndex = 3;
            this.btnReziseri.Text = "Reziseri";
            this.btnReziseri.UseVisualStyleBackColor = false;
            this.btnReziseri.Click += new System.EventHandler(this.btnReziseri_Click_1);
            // 
            // btnPredstave
            // 
            this.btnPredstave.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnPredstave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPredstave.Location = new System.Drawing.Point(429, 123);
            this.btnPredstave.Name = "btnPredstave";
            this.btnPredstave.Size = new System.Drawing.Size(129, 28);
            this.btnPredstave.TabIndex = 20;
            this.btnPredstave.Text = "Predstave";
            this.btnPredstave.UseVisualStyleBackColor = false;
            this.btnPredstave.Click += new System.EventHandler(this.btnPredstave_Click_1);
            // 
            // btnDodajRezisera
            // 
            this.btnDodajRezisera.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnDodajRezisera.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodajRezisera.Location = new System.Drawing.Point(9, 47);
            this.btnDodajRezisera.Name = "btnDodajRezisera";
            this.btnDodajRezisera.Size = new System.Drawing.Size(113, 27);
            this.btnDodajRezisera.TabIndex = 18;
            this.btnDodajRezisera.Text = "Dodaj rezisera";
            this.btnDodajRezisera.UseVisualStyleBackColor = false;
            this.btnDodajRezisera.Click += new System.EventHandler(this.btnDodajRezisera_Click_1);
            // 
            // btnObrisiRezisera
            // 
            this.btnObrisiRezisera.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnObrisiRezisera.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnObrisiRezisera.Location = new System.Drawing.Point(10, 80);
            this.btnObrisiRezisera.Name = "btnObrisiRezisera";
            this.btnObrisiRezisera.Size = new System.Drawing.Size(113, 27);
            this.btnObrisiRezisera.TabIndex = 19;
            this.btnObrisiRezisera.Text = "Obrisi rezisera";
            this.btnObrisiRezisera.UseVisualStyleBackColor = false;
            this.btnObrisiRezisera.Click += new System.EventHandler(this.btnObrisiRezisera_Click_1);
            // 
            // dataGridView3
            // 
            this.dataGridView3.BackgroundColor = System.Drawing.SystemColors.MenuBar;
            this.dataGridView3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView3.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView3.GridColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dataGridView3.Location = new System.Drawing.Point(171, 188);
            this.dataGridView3.MultiSelect = false;
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.ReadOnly = true;
            this.dataGridView3.RowHeadersWidth = 42;
            this.dataGridView3.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView3.Size = new System.Drawing.Size(593, 183);
            this.dataGridView3.TabIndex = 26;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.AntiqueWhite;
            this.panel4.Controls.Add(this.btnObrisiSalu);
            this.panel4.Controls.Add(this.btnDodajSalu);
            this.panel4.Controls.Add(this.btnPrikaziSale);
            this.panel4.Controls.Add(this.dataGridView4);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel4.Location = new System.Drawing.Point(770, 14);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(412, 236);
            this.panel4.TabIndex = 27;
            // 
            // btnObrisiSalu
            // 
            this.btnObrisiSalu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnObrisiSalu.Location = new System.Drawing.Point(138, 28);
            this.btnObrisiSalu.Name = "btnObrisiSalu";
            this.btnObrisiSalu.Size = new System.Drawing.Size(124, 27);
            this.btnObrisiSalu.TabIndex = 24;
            this.btnObrisiSalu.Text = "Obrisi Salu";
            this.btnObrisiSalu.UseVisualStyleBackColor = true;
            this.btnObrisiSalu.Click += new System.EventHandler(this.btnObrisiSalu_Click);
            // 
            // btnDodajSalu
            // 
            this.btnDodajSalu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodajSalu.Location = new System.Drawing.Point(8, 61);
            this.btnDodajSalu.Name = "btnDodajSalu";
            this.btnDodajSalu.Size = new System.Drawing.Size(124, 27);
            this.btnDodajSalu.TabIndex = 23;
            this.btnDodajSalu.Text = "Dodaj salu";
            this.btnDodajSalu.UseVisualStyleBackColor = true;
            this.btnDodajSalu.Click += new System.EventHandler(this.btnDodajSalu_Click);
            // 
            // btnPrikaziSale
            // 
            this.btnPrikaziSale.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrikaziSale.Location = new System.Drawing.Point(8, 28);
            this.btnPrikaziSale.Name = "btnPrikaziSale";
            this.btnPrikaziSale.Size = new System.Drawing.Size(124, 27);
            this.btnPrikaziSale.TabIndex = 22;
            this.btnPrikaziSale.Text = "Prikazi Sale";
            this.btnPrikaziSale.UseVisualStyleBackColor = true;
            this.btnPrikaziSale.Click += new System.EventHandler(this.btnPrikaziSale_Click);
            // 
            // dataGridView4
            // 
            this.dataGridView4.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView4.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dataGridView4.GridColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridView4.Location = new System.Drawing.Point(3, 94);
            this.dataGridView4.MultiSelect = false;
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.ReadOnly = true;
            this.dataGridView4.RowHeadersWidth = 40;
            this.dataGridView4.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView4.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView4.Size = new System.Drawing.Size(406, 135);
            this.dataGridView4.TabIndex = 21;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(13, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 16);
            this.label7.TabIndex = 20;
            this.label7.Text = "Sale";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Ivory;
            this.panel5.Controls.Add(this.dataGridView5);
            this.panel5.Controls.Add(this.btnDodajPisca);
            this.panel5.Controls.Add(this.btnUpdate);
            this.panel5.Controls.Add(this.btnDodajPredstavu);
            this.panel5.Controls.Add(this.button3);
            this.panel5.Controls.Add(this.btnPrikaziPredstave);
            this.panel5.Controls.Add(this.label8);
            this.panel5.Controls.Add(this.btnRepertoar);
            this.panel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel5.Location = new System.Drawing.Point(770, 256);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(412, 290);
            this.panel5.TabIndex = 28;
            // 
            // dataGridView5
            // 
            this.dataGridView5.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView5.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView5.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView5.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView5.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView5.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView5.GridColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dataGridView5.Location = new System.Drawing.Point(126, 82);
            this.dataGridView5.MultiSelect = false;
            this.dataGridView5.Name = "dataGridView5";
            this.dataGridView5.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView5.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView5.RowHeadersWidth = 42;
            this.dataGridView5.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView5.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView5.Size = new System.Drawing.Size(272, 203);
            this.dataGridView5.TabIndex = 28;
            this.dataGridView5.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView5_CellMouseDoubleClick);
            // 
            // btnDodajPisca
            // 
            this.btnDodajPisca.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodajPisca.Location = new System.Drawing.Point(126, 36);
            this.btnDodajPisca.Name = "btnDodajPisca";
            this.btnDodajPisca.Size = new System.Drawing.Size(124, 40);
            this.btnDodajPisca.TabIndex = 27;
            this.btnDodajPisca.Text = "Dodaj pisca predstave";
            this.ttPisac.SetToolTip(this.btnDodajPisca, "Otvara novu formu koja za odredjenu predstavu odredimo ko je napisao.");
            this.btnDodajPisca.UseVisualStyleBackColor = true;
            this.btnDodajPisca.Click += new System.EventHandler(this.btnDodajPisca_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(3, 82);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(112, 27);
            this.btnUpdate.TabIndex = 26;
            this.btnUpdate.Text = "Update predstavu";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDodajPredstavu
            // 
            this.btnDodajPredstavu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodajPredstavu.Location = new System.Drawing.Point(3, 147);
            this.btnDodajPredstavu.Name = "btnDodajPredstavu";
            this.btnDodajPredstavu.Size = new System.Drawing.Size(113, 27);
            this.btnDodajPredstavu.TabIndex = 25;
            this.btnDodajPredstavu.Text = "Dodaj Predstavu";
            this.btnDodajPredstavu.UseVisualStyleBackColor = true;
            this.btnDodajPredstavu.Click += new System.EventHandler(this.btnDodajPredstavu_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(3, 115);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(112, 27);
            this.button3.TabIndex = 24;
            this.button3.Text = "Obrisi Predstavu";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnPrikaziPredstave
            // 
            this.btnPrikaziPredstave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrikaziPredstave.Location = new System.Drawing.Point(3, 38);
            this.btnPrikaziPredstave.Name = "btnPrikaziPredstave";
            this.btnPrikaziPredstave.Size = new System.Drawing.Size(112, 38);
            this.btnPrikaziPredstave.TabIndex = 23;
            this.btnPrikaziPredstave.Text = "Prikazi Predstave";
            this.btnPrikaziPredstave.UseVisualStyleBackColor = true;
            this.btnPrikaziPredstave.Click += new System.EventHandler(this.btnPrikaziPredstave_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(5, 17);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 16);
            this.label8.TabIndex = 20;
            this.label8.Text = "Predstave:";
            // 
            // FormAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(1194, 558);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormAdmin";
            this.Text = "Administratorski rezim rada";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnZaposleni;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnGlumci;
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
        private System.Windows.Forms.ToolTip Rezirao;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnUpdateZaposleni;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox listPredstave;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button btnReziraj;
        private System.Windows.Forms.Button btnReziseri;
        private System.Windows.Forms.Button btnPredstave;
        private System.Windows.Forms.Button btnDodajRezisera;
        private System.Windows.Forms.Button btnObrisiRezisera;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnPrikaziSale;
        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnObrisiSalu;
        private System.Windows.Forms.Button btnDodajSalu;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDodajPredstavu;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnPrikaziPredstave;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dataGridView5;
        private System.Windows.Forms.Button btnDodajPisca;
        private System.Windows.Forms.Button btnDodeliUlogu;
        private System.Windows.Forms.ToolTip ttRepertoar;
        private System.Windows.Forms.ToolTip ttDodelaUloge;
        private System.Windows.Forms.ToolTip ttPisac;
    }
}