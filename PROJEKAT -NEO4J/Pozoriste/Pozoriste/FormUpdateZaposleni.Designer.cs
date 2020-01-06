namespace Pozoriste
{
    partial class FormUpdateZaposleni
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
            this.btnDodaj = new System.Windows.Forms.Button();
            this.cbRadnoMesto = new System.Windows.Forms.ComboBox();
            this.cbRadniStaz = new System.Windows.Forms.ComboBox();
            this.txtMesto = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblDatumRodjenja = new System.Windows.Forms.Label();
            this.lblJMBG = new System.Windows.Forms.Label();
            this.lblIme = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDodaj
            // 
            this.btnDodaj.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodaj.Location = new System.Drawing.Point(87, 252);
            this.btnDodaj.Margin = new System.Windows.Forms.Padding(4);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(163, 51);
            this.btnDodaj.TabIndex = 25;
            this.btnDodaj.Text = "Update";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // cbRadnoMesto
            // 
            this.cbRadnoMesto.FormattingEnabled = true;
            this.cbRadnoMesto.Items.AddRange(new object[] {
            "Direktor",
            "Blagajnik",
            "Racunovodja",
            "Cistacica",
            ""});
            this.cbRadnoMesto.Location = new System.Drawing.Point(123, 85);
            this.cbRadnoMesto.Margin = new System.Windows.Forms.Padding(4);
            this.cbRadnoMesto.Name = "cbRadnoMesto";
            this.cbRadnoMesto.Size = new System.Drawing.Size(159, 21);
            this.cbRadnoMesto.TabIndex = 24;
            // 
            // cbRadniStaz
            // 
            this.cbRadniStaz.FormattingEnabled = true;
            this.cbRadniStaz.Location = new System.Drawing.Point(123, 53);
            this.cbRadniStaz.Margin = new System.Windows.Forms.Padding(4);
            this.cbRadniStaz.Name = "cbRadniStaz";
            this.cbRadniStaz.Size = new System.Drawing.Size(159, 21);
            this.cbRadniStaz.TabIndex = 23;
            // 
            // txtMesto
            // 
            this.txtMesto.Location = new System.Drawing.Point(123, 17);
            this.txtMesto.Margin = new System.Windows.Forms.Padding(4);
            this.txtMesto.Name = "txtMesto";
            this.txtMesto.Size = new System.Drawing.Size(159, 20);
            this.txtMesto.TabIndex = 22;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(9, 87);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 19);
            this.label6.TabIndex = 20;
            this.label6.Text = "Radno mesto:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(9, 55);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 19);
            this.label5.TabIndex = 17;
            this.label5.Text = "Radni staz:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(4, 17);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 19);
            this.label4.TabIndex = 16;
            this.label4.Text = "Mesto rodjenja:";
            // 
            // lblDatumRodjenja
            // 
            this.lblDatumRodjenja.AutoSize = true;
            this.lblDatumRodjenja.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatumRodjenja.Location = new System.Drawing.Point(82, 69);
            this.lblDatumRodjenja.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDatumRodjenja.Name = "lblDatumRodjenja";
            this.lblDatumRodjenja.Size = new System.Drawing.Size(160, 25);
            this.lblDatumRodjenja.TabIndex = 15;
            this.lblDatumRodjenja.Text = "Datum rodjenja:";
            // 
            // lblJMBG
            // 
            this.lblJMBG.AutoSize = true;
            this.lblJMBG.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJMBG.Location = new System.Drawing.Point(82, 44);
            this.lblJMBG.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblJMBG.Name = "lblJMBG";
            this.lblJMBG.Size = new System.Drawing.Size(70, 25);
            this.lblJMBG.TabIndex = 14;
            this.lblJMBG.Text = "JMBG:";
            // 
            // lblIme
            // 
            this.lblIme.AutoSize = true;
            this.lblIme.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIme.Location = new System.Drawing.Point(82, 19);
            this.lblIme.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIme.Name = "lblIme";
            this.lblIme.Size = new System.Drawing.Size(142, 25);
            this.lblIme.TabIndex = 13;
            this.lblIme.Text = "Ime i prezime:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.NavajoWhite;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtMesto);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.cbRadnoMesto);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.cbRadniStaz);
            this.panel1.Location = new System.Drawing.Point(12, 117);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(318, 128);
            this.panel1.TabIndex = 26;
            // 
            // FormUpdateZaposleni
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 314);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.lblDatumRodjenja);
            this.Controls.Add(this.lblJMBG);
            this.Controls.Add(this.lblIme);
            this.Name = "FormUpdateZaposleni";
            this.Text = "FormUpdateZaposleni";
            this.Load += new System.EventHandler(this.FormUpdateZaposleni_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.ComboBox cbRadnoMesto;
        private System.Windows.Forms.ComboBox cbRadniStaz;
        private System.Windows.Forms.TextBox txtMesto;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblDatumRodjenja;
        private System.Windows.Forms.Label lblJMBG;
        private System.Windows.Forms.Label lblIme;
        private System.Windows.Forms.Panel panel1;
    }
}