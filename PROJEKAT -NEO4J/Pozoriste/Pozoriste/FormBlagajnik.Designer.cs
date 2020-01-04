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
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(304, 22);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(395, 332);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // cbPredstave
            // 
            this.cbPredstave.FormattingEnabled = true;
            this.cbPredstave.Location = new System.Drawing.Point(54, 93);
            this.cbPredstave.Name = "cbPredstave";
            this.cbPredstave.Size = new System.Drawing.Size(121, 21);
            this.cbPredstave.TabIndex = 1;
            // 
            // cbSala
            // 
            this.cbSala.FormattingEnabled = true;
            this.cbSala.Location = new System.Drawing.Point(54, 53);
            this.cbSala.Name = "cbSala";
            this.cbSala.Size = new System.Drawing.Size(121, 21);
            this.cbSala.TabIndex = 2;
            this.cbSala.SelectedIndexChanged += new System.EventHandler(this.cbSala_SelectedIndexChanged);
            // 
            // FormBlagajnik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 456);
            this.Controls.Add(this.cbSala);
            this.Controls.Add(this.cbPredstave);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "FormBlagajnik";
            this.Text = "FormBlagajnik";
            this.Load += new System.EventHandler(this.FormBlagajnik_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.ComboBox cbPredstave;
        private System.Windows.Forms.ComboBox cbSala;
    }
}