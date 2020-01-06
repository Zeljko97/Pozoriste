namespace Pozoriste
{
    partial class FormUpdatePredstava
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
            this.btnUpdatePredstava = new System.Windows.Forms.Button();
            this.cbZanr = new System.Windows.Forms.ComboBox();
            this.txtKratakOpis = new System.Windows.Forms.TextBox();
            this.lblKratakOpis = new System.Windows.Forms.Label();
            this.lblZanr = new System.Windows.Forms.Label();
            this.lblNaslov = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnUpdatePredstava
            // 
            this.btnUpdatePredstava.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdatePredstava.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdatePredstava.Location = new System.Drawing.Point(92, 217);
            this.btnUpdatePredstava.Name = "btnUpdatePredstava";
            this.btnUpdatePredstava.Size = new System.Drawing.Size(145, 32);
            this.btnUpdatePredstava.TabIndex = 13;
            this.btnUpdatePredstava.Text = "Azuriraj\r\n";
            this.btnUpdatePredstava.UseVisualStyleBackColor = true;
            this.btnUpdatePredstava.Click += new System.EventHandler(this.btnUpdatePredstava_Click);
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
            this.cbZanr.Location = new System.Drawing.Point(92, 47);
            this.cbZanr.Name = "cbZanr";
            this.cbZanr.Size = new System.Drawing.Size(203, 24);
            this.cbZanr.TabIndex = 12;
            // 
            // txtKratakOpis
            // 
            this.txtKratakOpis.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKratakOpis.Location = new System.Drawing.Point(92, 88);
            this.txtKratakOpis.Multiline = true;
            this.txtKratakOpis.Name = "txtKratakOpis";
            this.txtKratakOpis.Size = new System.Drawing.Size(203, 110);
            this.txtKratakOpis.TabIndex = 11;
            // 
            // lblKratakOpis
            // 
            this.lblKratakOpis.AutoSize = true;
            this.lblKratakOpis.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKratakOpis.Location = new System.Drawing.Point(16, 91);
            this.lblKratakOpis.Name = "lblKratakOpis";
            this.lblKratakOpis.Size = new System.Drawing.Size(73, 16);
            this.lblKratakOpis.TabIndex = 9;
            this.lblKratakOpis.Text = "Kratak opis:";
            // 
            // lblZanr
            // 
            this.lblZanr.AutoSize = true;
            this.lblZanr.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblZanr.Location = new System.Drawing.Point(16, 50);
            this.lblZanr.Name = "lblZanr";
            this.lblZanr.Size = new System.Drawing.Size(36, 16);
            this.lblZanr.TabIndex = 8;
            this.lblZanr.Text = "Zanr:";
            // 
            // lblNaslov
            // 
            this.lblNaslov.AutoSize = true;
            this.lblNaslov.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNaslov.Location = new System.Drawing.Point(87, 9);
            this.lblNaslov.Name = "lblNaslov";
            this.lblNaslov.Size = new System.Drawing.Size(82, 26);
            this.lblNaslov.TabIndex = 7;
            this.lblNaslov.Text = "Naslov:";
            // 
            // FormUpdatePredstava
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(319, 268);
            this.Controls.Add(this.btnUpdatePredstava);
            this.Controls.Add(this.cbZanr);
            this.Controls.Add(this.txtKratakOpis);
            this.Controls.Add(this.lblKratakOpis);
            this.Controls.Add(this.lblZanr);
            this.Controls.Add(this.lblNaslov);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormUpdatePredstava";
            this.ShowIcon = false;
            this.Text = "Azuriranje predstave";
            this.Load += new System.EventHandler(this.FormUpdatePredstava_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUpdatePredstava;
        private System.Windows.Forms.ComboBox cbZanr;
        private System.Windows.Forms.TextBox txtKratakOpis;
        private System.Windows.Forms.Label lblKratakOpis;
        private System.Windows.Forms.Label lblZanr;
        private System.Windows.Forms.Label lblNaslov;
    }
}