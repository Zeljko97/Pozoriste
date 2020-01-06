namespace Pozoriste
{
    partial class FormDodavanjeSale
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
            this.btnDodajSalu = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBrojSale = new System.Windows.Forms.TextBox();
            this.txtBrojRedova = new System.Windows.Forms.TextBox();
            this.txtSedistePoRedu = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnDodajSalu
            // 
            this.btnDodajSalu.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodajSalu.Location = new System.Drawing.Point(69, 113);
            this.btnDodajSalu.Name = "btnDodajSalu";
            this.btnDodajSalu.Size = new System.Drawing.Size(114, 30);
            this.btnDodajSalu.TabIndex = 0;
            this.btnDodajSalu.Text = "Dodaj Salu";
            this.btnDodajSalu.UseVisualStyleBackColor = true;
            this.btnDodajSalu.Click += new System.EventHandler(this.btnDodajSalu_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Broj sale:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(4, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "Sedista po redu:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 19);
            this.label4.TabIndex = 4;
            this.label4.Text = "Broj redova:";
            // 
            // txtBrojSale
            // 
            this.txtBrojSale.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBrojSale.Location = new System.Drawing.Point(118, 18);
            this.txtBrojSale.Name = "txtBrojSale";
            this.txtBrojSale.Size = new System.Drawing.Size(122, 25);
            this.txtBrojSale.TabIndex = 5;
            // 
            // txtBrojRedova
            // 
            this.txtBrojRedova.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBrojRedova.Location = new System.Drawing.Point(118, 51);
            this.txtBrojRedova.Name = "txtBrojRedova";
            this.txtBrojRedova.Size = new System.Drawing.Size(122, 25);
            this.txtBrojRedova.TabIndex = 6;
            // 
            // txtSedistePoRedu
            // 
            this.txtSedistePoRedu.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSedistePoRedu.Location = new System.Drawing.Point(118, 82);
            this.txtSedistePoRedu.Name = "txtSedistePoRedu";
            this.txtSedistePoRedu.Size = new System.Drawing.Size(122, 25);
            this.txtSedistePoRedu.TabIndex = 8;
            // 
            // FormDodavanjeSale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(252, 150);
            this.Controls.Add(this.txtSedistePoRedu);
            this.Controls.Add(this.txtBrojRedova);
            this.Controls.Add(this.txtBrojSale);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDodajSalu);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "FormDodavanjeSale";
            this.ShowIcon = false;
            this.Text = "Dodavanje nove sale";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDodajSalu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBrojSale;
        private System.Windows.Forms.TextBox txtBrojRedova;
        private System.Windows.Forms.TextBox txtSedistePoRedu;
    }
}