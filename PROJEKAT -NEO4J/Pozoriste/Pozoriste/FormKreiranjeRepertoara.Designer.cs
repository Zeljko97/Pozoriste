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
            this.btnPredstave = new System.Windows.Forms.Button();
            this.listPredstave = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listRepertoar = new System.Windows.Forms.ListBox();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.btnVrati = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPredstave
            // 
            this.btnPredstave.Location = new System.Drawing.Point(12, 30);
            this.btnPredstave.Name = "btnPredstave";
            this.btnPredstave.Size = new System.Drawing.Size(101, 23);
            this.btnPredstave.TabIndex = 0;
            this.btnPredstave.Text = "Ucitaj predstave";
            this.btnPredstave.UseVisualStyleBackColor = true;
            this.btnPredstave.Click += new System.EventHandler(this.btnPredstave_Click);
            // 
            // listPredstave
            // 
            this.listPredstave.FormattingEnabled = true;
            this.listPredstave.Location = new System.Drawing.Point(15, 139);
            this.listPredstave.Name = "listPredstave";
            this.listPredstave.Size = new System.Drawing.Size(120, 95);
            this.listPredstave.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Predstave:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(241, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Repertoar:";
            // 
            // listRepertoar
            // 
            this.listRepertoar.FormattingEnabled = true;
            this.listRepertoar.Location = new System.Drawing.Point(244, 139);
            this.listRepertoar.Name = "listRepertoar";
            this.listRepertoar.Size = new System.Drawing.Size(120, 95);
            this.listRepertoar.TabIndex = 4;
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(166, 153);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(42, 23);
            this.btnDodaj.TabIndex = 5;
            this.btnDodaj.Text = ">";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // btnVrati
            // 
            this.btnVrati.Location = new System.Drawing.Point(166, 191);
            this.btnVrati.Name = "btnVrati";
            this.btnVrati.Size = new System.Drawing.Size(42, 23);
            this.btnVrati.TabIndex = 6;
            this.btnVrati.Text = "<";
            this.btnVrati.UseVisualStyleBackColor = true;
            // 
            // FormKreiranjeRepertoara
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 310);
            this.Controls.Add(this.btnVrati);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.listRepertoar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listPredstave);
            this.Controls.Add(this.btnPredstave);
            this.Name = "FormKreiranjeRepertoara";
            this.Text = "FormKreiranjeRepertoara";
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
    }
}