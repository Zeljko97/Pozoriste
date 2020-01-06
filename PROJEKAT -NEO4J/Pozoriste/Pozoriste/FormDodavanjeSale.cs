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
            if (!Validacija())
            {
                return;
            }
            else
            {
                int brojSale = Convert.ToInt32(txtBrojSale.Text);
                int brojRedova = Convert.ToInt32(txtBrojRedova.Text);
                // int brojSedista = Convert.ToInt32(txtBrojSedista.Text);
                int SedistaPoRedu = Convert.ToInt32(txtSedistePoRedu.Text);
                int brojSedista = brojRedova * SedistaPoRedu;
                if (dp.AddSala(brojSale, brojSedista, SedistaPoRedu, brojRedova))
                {
                    MessageBox.Show("Uspesno dodavanje sale!", "Sala dodata ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("NIJE USPELO dodavanje sale!", "GRESKA! ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
        }
        #region ogranicenja
        private void txtBrojSale_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txtBrojRedova_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txtSedistePoRedu_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private bool Validacija()
        {
            if (String.IsNullOrEmpty(txtBrojRedova.Text))
            {
                MessageBox.Show("Unesite broj redova","Greska",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return false;
            } else if (String.IsNullOrEmpty(txtBrojSale.Text))
            {
                MessageBox.Show("Unesite broj sale", "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (String.IsNullOrEmpty(txtSedistePoRedu.Text))
            {
                MessageBox.Show("Unesite broj sedista po redu", "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        #endregion
    }
}
