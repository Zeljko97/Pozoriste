namespace Pozoriste
{
    partial class FormBlagajnik
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.cbPredstave = new System.Windows.Forms.ComboBox();
            this.cbSala = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbDatum = new System.Windows.Forms.ComboBox();
            this.cbVreme = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbCena = new System.Windows.Forms.Label();
            this.btnRezervacija = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(418, 53);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.flowLayoutPanel1.MinimumSize = new System.Drawing.Size(38, 41);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(38, 41);
            this.flowLayoutPanel1.TabIndex = 36;
            // 
            // cbPredstave
            // 
            this.cbPredstave.FormattingEnabled = true;
            this.cbPredstave.Location = new System.Drawing.Point(73, 31);
            this.cbPredstave.Name = "cbPredstave";
            this.cbPredstave.Size = new System.Drawing.Size(121, 21);
            this.cbPredstave.TabIndex = 1;
            this.cbPredstave.SelectedIndexChanged += new System.EventHandler(this.cbPredstave_SelectedIndexChanged);
            // 
            // cbSala
            // 
            this.cbSala.FormattingEnabled = true;
            this.cbSala.Location = new System.Drawing.Point(73, 174);
            this.cbSala.Name = "cbSala";
            this.cbSala.Size = new System.Drawing.Size(121, 21);
            this.cbSala.TabIndex = 2;
            this.cbSala.SelectedIndexChanged += new System.EventHandler(this.cbSala_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 174);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 37;
            this.label1.Text = "Sala:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 38;
            this.label2.Text = "Predstava:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 39;
            this.label3.Text = "Datum;";
            // 
            // cbDatum
            // 
            this.cbDatum.FormattingEnabled = true;
            this.cbDatum.Location = new System.Drawing.Point(73, 73);
            this.cbDatum.Name = "cbDatum";
            this.cbDatum.Size = new System.Drawing.Size(121, 21);
            this.cbDatum.TabIndex = 40;
            this.cbDatum.SelectedIndexChanged += new System.EventHandler(this.cbDatum_SelectedIndexChanged);
            // 
            // cbVreme
            // 
            this.cbVreme.FormattingEnabled = true;
            this.cbVreme.Location = new System.Drawing.Point(73, 116);
            this.cbVreme.Name = "cbVreme";
            this.cbVreme.Size = new System.Drawing.Size(121, 21);
            this.cbVreme.TabIndex = 41;
            this.cbVreme.SelectedIndexChanged += new System.EventHandler(this.cbVreme_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 42;
            this.label4.Text = "Vreme:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 227);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 43;
            this.label5.Text = "Cena";
            // 
            // lbCena
            // 
            this.lbCena.AutoSize = true;
            this.lbCena.Location = new System.Drawing.Point(83, 227);
            this.lbCena.Name = "lbCena";
            this.lbCena.Size = new System.Drawing.Size(35, 13);
            this.lbCena.TabIndex = 44;
            this.lbCena.Text = "label6";
            // 
            // btnRezervacija
            // 
            this.btnRezervacija.Location = new System.Drawing.Point(73, 275);
            this.btnRezervacija.Name = "btnRezervacija";
            this.btnRezervacija.Size = new System.Drawing.Size(75, 23);
            this.btnRezervacija.TabIndex = 45;
            this.btnRezervacija.Text = "Rezervacija";
            this.btnRezervacija.UseVisualStyleBackColor = true;
            this.btnRezervacija.Click += new System.EventHandler(this.btnRezervacija_Click);
            // 
            // FormBlagajnik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 456);
            this.Controls.Add(this.btnRezervacija);
            this.Controls.Add(this.lbCena);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbVreme);
            this.Controls.Add(this.cbDatum);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbSala);
            this.Controls.Add(this.cbPredstave);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "FormBlagajnik";
            this.Text = "FormBlagajnik";
            this.Load += new System.EventHandler(this.FormBlagajnik_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.ComboBox cbPredstave;
        private System.Windows.Forms.ComboBox cbSala;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbDatum;
        private System.Windows.Forms.ComboBox cbVreme;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbCena;
        private System.Windows.Forms.Button btnRezervacija;
    }
}