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
    public partial class FormNoviReziser : Form
    {
        DataProvider dp = new DataProvider();

        public FormNoviReziser()
        {
            InitializeComponent();
            dp.PoveziBazu();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            if (!Validacija())
            {
                MessageBox.Show("Popunite sva polja", "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                string ime = txtIme.Text;
                int brojPredstava = Int32.Parse(txtBrojPredstava.Text);

                if (dp.AddReziser(ime, brojPredstava))
                {
                    MessageBox.Show("Reziser " + ime + " je uspesno dodat.", "Uspesno dodavanje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Doslo je do greske prilikom dodavanja", "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                
            }

        }

        private void txtIme_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetter(e.KeyChar) && !Char.IsControl(e.KeyChar) && !Char.IsWhiteSpace(e.KeyChar))
                e.Handled = true;
        }

        private void txtBrojPredstava_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar) )
                e.Handled = true;
        }
        private bool Validacija()
        {
            if (String.IsNullOrEmpty(txtIme.Text))
            {
                return false;
            }
            else if (String.IsNullOrEmpty(txtBrojPredstava.Text))
            {
                return false;
            }
            return true;
        }
    }
}
