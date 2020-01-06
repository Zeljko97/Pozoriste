using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pozoriste
{
    public partial class FormDodavanjeSale : Form
    {
        DataProvider dp = new DataProvider();
        public FormDodavanjeSale()
        {
            InitializeComponent();
            dp.PoveziBazu();
        }

        private void btnDodajSalu_Click(object sender, EventArgs e)
        {
            int brojSale = Convert.ToInt32(txtBrojSale.Text);
            int brojRedova = Convert.ToInt32(txtBrojRedova.Text);
           // int brojSedista = Convert.ToInt32(txtBrojSedista.Text);
            int SedistaPoRedu = Convert.ToInt32(txtSedistePoRedu.Text);
            int brojSedista = brojRedova * SedistaPoRedu;
            if (dp.AddSala(brojSale, brojSedista, SedistaPoRedu, brojRedova))
            {
                MessageBox.Show("Uspesno dodavanje sale!", "Sala dodata ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
	        {
                MessageBox.Show("NIJE USPELO dodavanje sale!", "GRESKA! ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            
            this.Close();
        }
    }
}
