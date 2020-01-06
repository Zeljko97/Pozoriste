namespace Pozoriste
{
    partial class FormDodavanjePredstave
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDodavanjePredstave));
            this.lblNAslov = new System.Windows.Forms.Label();
            this.lblZanr = new System.Windows.Forms.Label();
            this.lblKratakOpis = new System.Windows.Forms.Label();
            this.txtNaslov = new System.Windows.Forms.TextBox();
            this.txtKratakOpis = new System.Windows.Forms.TextBox();
            this.cbZanr = new System.Windows.Forms.ComboBox();
            this.btnDodajPredstavu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNAslov
            // 
            this.lblNAslov.AutoSize = true;
            this.lblNAslov.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNAslov.Location = new System.Drawing.Point(12, 26);
            this.lblNAslov.Name = "lblNAslov";
            this.lblNAslov.Size = new System.Drawing.Size(48, 16);
            this.lblNAslov.TabIndex = 0;
            this.lblNAslov.Text = "Naslov:";
            // 
            // lblZanr
            // 
            this.lblZanr.AutoSize = true;
            this.lblZanr.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblZanr.Location = new System.Drawing.Point(12, 61);
            this.lblZanr.Name = "lblZanr";
            this.lblZanr.Size = new System.Drawing.Size(36, 16);
            this.lblZanr.TabIndex = 1;
            this.lblZanr.Text = "Zanr:";
            // 
            // lblKratakOpis
            // 
            this.lblKratakOpis.AutoSize = true;
            this.lblKratakOpis.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKratakOpis.Location = new System.Drawing.Point(12, 102);
            this.lblKratakOpis.Name = "lblKratakOpis";
            this.lblKratakOpis.Size = new System.Drawing.Size(73, 16);
            this.lblKratakOpis.TabIndex = 2;
            this.lblKratakOpis.Text = "Kratak opis:";
            // 
            // txtNaslov
            // 
            this.txtNaslov.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNaslov.Location = new System.Drawing.Point(88, 23);
            this.txtNaslov.Name = "txtNaslov";
            this.txtNaslov.Size = new System.Drawing.Size(203, 23);
            this.txtNaslov.TabIndex = 3;
            this.txtNaslov.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNaslov_KeyPress);
            // 
            // txtKratakOpis
            // 
            this.txtKratakOpis.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKratakOpis.Location = new System.Drawing.Point(88, 99);
            this.txtKratakOpis.Multiline = true;
            this.txtKratakOpis.Name = "txtKratakOpis";
            this.txtKratakOpis.Size = new System.Drawing.Size(203, 110);
            this.txtKratakOpis.TabIndex = 4;
            // 
            // cbZanr
            // 
            this.cbZanr.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbZanr.FormattingEnabled = true;
            this.cbZanr.Items.AddRange(new object[] {
            "komedija",
            "drama",
            "triler",
            "akcija",
            "naturalisticka drama",
            "numera"});
            this.cbZanr.Location = new System.Drawing.Point(88, 58);
            this.cbZanr.Name = "cbZanr";
            this.cbZanr.Size = new System.Drawing.Size(203, 24);
            this.cbZanr.TabIndex = 5;
            // 
            // btnDodajPredstavu
            // 
            this.btnDodajPredstavu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDodajPredstavu.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodajPredstavu.Location = new System.Drawing.Point(88, 230);
            this.btnDodajPredstavu.Name = "btnDodajPredstavu";
            this.btnDodajPredstavu.Size = new System.Drawing.Size(145, 30);
            this.btnDodajPredstavu.TabIndex = 6;
            this.btnDodajPredstavu.Text = "Dodaj Predstavu";
            this.btnDodajPredstavu.UseVisualStyleBackColor = true;
            this.btnDodajPredstavu.Click += new System.EventHandler(this.btnDodajPredstavu_Click);
            // 
            // FormDodavanjePredstave
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(316, 272);
            this.Controls.Add(this.btnDodajPredstavu);
            this.Controls.Add(this.cbZanr);
            this.Controls.Add(this.txtKratakOpis);
            this.Controls.Add(this.txtNaslov);
            this.Controls.Add(this.lblKratakOpis);
            this.Controls.Add(this.lblZanr);
            this.Controls.Add(this.lblNAslov);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormDodavanjePredstave";
            this.Text = "Dodavanje nove predstave";
            this.Load += new System.EventHandler(this.FormDodavanjePredstave_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNAslov;
        private System.Windows.Forms.Label lblZanr;
        private System.Windows.Forms.Label lblKratakOpis;
        private System.Windows.Forms.TextBox txtNaslov;
        private System.Windows.Forms.TextBox txtKratakOpis;
        private System.Windows.Forms.ComboBox cbZanr;
        private System.Windows.Forms.Button btnDodajPredstavu;
    }
}