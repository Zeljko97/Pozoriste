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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnZaposleni
            // 
            this.btnZaposleni.Location = new System.Drawing.Point(3, 38);
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
            this.dataGridView1.Location = new System.Drawing.Point(233, 38);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(539, 260);
            this.dataGridView1.TabIndex = 1;
            // 
            // btnGlumci
            // 
            this.btnGlumci.Location = new System.Drawing.Point(3, 78);
            this.btnGlumci.Name = "btnGlumci";
            this.btnGlumci.Size = new System.Drawing.Size(75, 23);
            this.btnGlumci.TabIndex = 2;
            this.btnGlumci.Text = "Glumci";
            this.btnGlumci.UseVisualStyleBackColor = true;
            this.btnGlumci.Click += new System.EventHandler(this.btnGlumci_Click);
            // 
            // btnReziseri
            // 
            this.btnReziseri.Location = new System.Drawing.Point(3, 121);
            this.btnReziseri.Name = "btnReziseri";
            this.btnReziseri.Size = new System.Drawing.Size(75, 23);
            this.btnReziseri.TabIndex = 3;
            this.btnReziseri.Text = "Reziseri";
            this.btnReziseri.UseVisualStyleBackColor = true;
            this.btnReziseri.Click += new System.EventHandler(this.btnReziseri_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(99, 38);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Dodaj zaposlenog";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 341);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnReziseri);
            this.Controls.Add(this.btnGlumci);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnZaposleni);
            this.Name = "FormAdmin";
            this.Text = "FormAdmin";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnZaposleni;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnGlumci;
        private System.Windows.Forms.Button btnReziseri;
        private System.Windows.Forms.Button button1;
    }
}