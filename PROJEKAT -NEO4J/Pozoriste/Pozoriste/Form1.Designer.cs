namespace Pozoriste
{
    partial class Form1
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
            this.btnAdmin = new System.Windows.Forms.Button();
            this.btnBlagajnik = new System.Windows.Forms.Button();
            this.btnPredstave = new System.Windows.Forms.Button();
            this.listPredstave = new System.Windows.Forms.ListView();
            this.listGlumci = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAdmin
            // 
            this.btnAdmin.Location = new System.Drawing.Point(12, 24);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(75, 23);
            this.btnAdmin.TabIndex = 1;
            this.btnAdmin.Text = "Administrator";
            this.btnAdmin.UseVisualStyleBackColor = true;
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
            // 
            // btnBlagajnik
            // 
            this.btnBlagajnik.Location = new System.Drawing.Point(12, 69);
            this.btnBlagajnik.Name = "btnBlagajnik";
            this.btnBlagajnik.Size = new System.Drawing.Size(75, 23);
            this.btnBlagajnik.TabIndex = 2;
            this.btnBlagajnik.Text = "Blagajnik";
            this.btnBlagajnik.UseVisualStyleBackColor = true;
            this.btnBlagajnik.Click += new System.EventHandler(this.btnBlagajnik_Click);
            // 
            // btnPredstave
            // 
            this.btnPredstave.Location = new System.Drawing.Point(333, 24);
            this.btnPredstave.Name = "btnPredstave";
            this.btnPredstave.Size = new System.Drawing.Size(289, 23);
            this.btnPredstave.TabIndex = 3;
            this.btnPredstave.Text = "Pogledaj spisak predstava";
            this.btnPredstave.UseVisualStyleBackColor = true;
            this.btnPredstave.Click += new System.EventHandler(this.btnPredstave_Click);
            // 
            // listPredstave
            // 
            this.listPredstave.Location = new System.Drawing.Point(333, 69);
            this.listPredstave.Name = "listPredstave";
            this.listPredstave.Size = new System.Drawing.Size(307, 194);
            this.listPredstave.TabIndex = 4;
            this.listPredstave.TileSize = new System.Drawing.Size(8, 8);
            this.listPredstave.UseCompatibleStateImageBehavior = false;
            this.listPredstave.View = System.Windows.Forms.View.List;
            this.listPredstave.ItemActivate += new System.EventHandler(this.listPredstave_ItemActivate);
            this.listPredstave.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.listPredstave_ItemChecked);
            this.listPredstave.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listPredstave_MouseDoubleClick);
            // 
            // listGlumci
            // 
            this.listGlumci.Location = new System.Drawing.Point(724, 69);
            this.listGlumci.Name = "listGlumci";
            this.listGlumci.Size = new System.Drawing.Size(241, 194);
            this.listGlumci.TabIndex = 5;
            this.listGlumci.UseCompatibleStateImageBehavior = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(330, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Izaberi predstavu (klikom)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(721, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Glumci u predstavi:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 342);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listGlumci);
            this.Controls.Add(this.listPredstave);
            this.Controls.Add(this.btnPredstave);
            this.Controls.Add(this.btnBlagajnik);
            this.Controls.Add(this.btnAdmin);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdmin;
        private System.Windows.Forms.Button btnBlagajnik;
        private System.Windows.Forms.Button btnPredstave;
        private System.Windows.Forms.ListView listPredstave;
        private System.Windows.Forms.ListView listGlumci;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

