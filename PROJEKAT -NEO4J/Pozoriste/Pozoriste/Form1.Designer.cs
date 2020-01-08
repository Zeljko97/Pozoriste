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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnAdmin = new System.Windows.Forms.Button();
            this.btnBlagajnik = new System.Windows.Forms.Button();
            this.btnPredstave = new System.Windows.Forms.Button();
            this.listPredstave = new System.Windows.Forms.ListView();
            this.listGlumci = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnRepertoar = new System.Windows.Forms.Button();
            this.listRepertoar = new System.Windows.Forms.ListView();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAdmin
            // 
            this.btnAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdmin.Location = new System.Drawing.Point(12, 24);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(118, 39);
            this.btnAdmin.TabIndex = 1;
            this.btnAdmin.Text = "Administrator";
            this.btnAdmin.UseVisualStyleBackColor = true;
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
            // 
            // btnBlagajnik
            // 
            this.btnBlagajnik.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBlagajnik.Location = new System.Drawing.Point(12, 69);
            this.btnBlagajnik.Name = "btnBlagajnik";
            this.btnBlagajnik.Size = new System.Drawing.Size(118, 39);
            this.btnBlagajnik.TabIndex = 2;
            this.btnBlagajnik.Text = "Blagajnik";
            this.btnBlagajnik.UseVisualStyleBackColor = true;
            this.btnBlagajnik.Click += new System.EventHandler(this.btnBlagajnik_Click);
            // 
            // btnPredstave
            // 
            this.btnPredstave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPredstave.Location = new System.Drawing.Point(12, 195);
            this.btnPredstave.Name = "btnPredstave";
            this.btnPredstave.Size = new System.Drawing.Size(153, 47);
            this.btnPredstave.TabIndex = 3;
            this.btnPredstave.Text = "Pogledaj spisak predstava";
            this.btnPredstave.UseVisualStyleBackColor = true;
            this.btnPredstave.Click += new System.EventHandler(this.btnPredstave_Click);
            // 
            // listPredstave
            // 
            this.listPredstave.BackColor = System.Drawing.Color.RoyalBlue;
            this.listPredstave.HideSelection = false;
            this.listPredstave.Location = new System.Drawing.Point(12, 274);
            this.listPredstave.Name = "listPredstave";
            this.listPredstave.Size = new System.Drawing.Size(307, 194);
            this.listPredstave.TabIndex = 4;
            this.listPredstave.TileSize = new System.Drawing.Size(8, 8);
            this.listPredstave.UseCompatibleStateImageBehavior = false;
            this.listPredstave.View = System.Windows.Forms.View.List;
            this.listPredstave.Visible = false;
            this.listPredstave.ItemActivate += new System.EventHandler(this.listPredstave_ItemActivate);
            this.listPredstave.SelectedIndexChanged += new System.EventHandler(this.listPredstave_SelectedIndexChanged);
            this.listPredstave.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listPredstave_MouseDoubleClick);
            // 
            // listGlumci
            // 
            this.listGlumci.BackColor = System.Drawing.Color.RoyalBlue;
            this.listGlumci.HideSelection = false;
            this.listGlumci.Location = new System.Drawing.Point(388, 274);
            this.listGlumci.Name = "listGlumci";
            this.listGlumci.Size = new System.Drawing.Size(333, 194);
            this.listGlumci.TabIndex = 5;
            this.listGlumci.UseCompatibleStateImageBehavior = false;
            this.listGlumci.View = System.Windows.Forms.View.List;
            this.listGlumci.Visible = false;
            this.listGlumci.ItemActivate += new System.EventHandler(this.listGlumci_ItemActivate);
            this.listGlumci.SelectedIndexChanged += new System.EventHandler(this.listGlumci_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 245);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(264, 26);
            this.label1.TabIndex = 6;
            this.label1.Text = "Izaberi predstavu (klikom) ako zelite da vidite podatke o glumcima u predstavi.";
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(385, 226);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Glumci u predstavi:";
            this.label2.Visible = false;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "yyyy/MM/dd";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(399, 32);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(177, 20);
            this.dateTimePicker1.TabIndex = 8;
            // 
            // btnRepertoar
            // 
            this.btnRepertoar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnRepertoar.Location = new System.Drawing.Point(399, 69);
            this.btnRepertoar.Name = "btnRepertoar";
            this.btnRepertoar.Size = new System.Drawing.Size(177, 36);
            this.btnRepertoar.TabIndex = 9;
            this.btnRepertoar.Text = "Pogledaj repertoar";
            this.btnRepertoar.UseVisualStyleBackColor = true;
            this.btnRepertoar.Click += new System.EventHandler(this.btnRepertoar_Click);
            // 
            // listRepertoar
            // 
            this.listRepertoar.BackColor = System.Drawing.Color.CornflowerBlue;
            this.listRepertoar.Location = new System.Drawing.Point(399, 111);
            this.listRepertoar.Name = "listRepertoar";
            this.listRepertoar.Size = new System.Drawing.Size(177, 102);
            this.listRepertoar.TabIndex = 10;
            this.listRepertoar.UseCompatibleStateImageBehavior = false;
            this.listRepertoar.View = System.Windows.Forms.View.List;
            this.listRepertoar.Visible = false;
            this.listRepertoar.SelectedIndexChanged += new System.EventHandler(this.listRepertoar_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(385, 245);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(220, 26);
            this.label3.TabIndex = 11;
            this.label3.Text = "Klikom na ime glumca, mozete videti osnovne informacije o svakom glumcu.";
            this.label3.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImage = global::Pozoriste.Properties.Resources.Boulevard_2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(783, 543);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listRepertoar);
            this.Controls.Add(this.btnRepertoar);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listGlumci);
            this.Controls.Add(this.listPredstave);
            this.Controls.Add(this.btnPredstave);
            this.Controls.Add(this.btnBlagajnik);
            this.Controls.Add(this.btnAdmin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "     Theatre";
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
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnRepertoar;
        private System.Windows.Forms.ListView listRepertoar;
        private System.Windows.Forms.Label label3;
    }
}

