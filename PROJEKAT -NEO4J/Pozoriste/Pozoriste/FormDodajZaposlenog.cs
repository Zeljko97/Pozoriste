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
    public partial class FormDodajZaposlenog : Form
    {

        DataProvider dp = new DataProvider();
        public FormDodajZaposlenog()
        {
            InitializeComponent();
            dp.PoveziBazu();
        }

        private void FormDodajZaposlenog_Load(object sender, EventArgs e)
        {
            for(int i = 0;i<50;i++)
            {
                cbRadniStaz.Items.Add(i);
            }
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            if (!Validacija())
            {
                MessageBox.Show("Niste popunili sva polja.","Greska",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            else
            {
                String ime = txtIme.Text;
                String jmbg = txtJMBG.Text;
                String datum = dateTimePicker1.Text;
                String mesto = txtMesto.Text;
                int radniStaz = Convert.ToInt32(cbRadniStaz.Text);
                String radnoMesto = cbRadnoMesto.Text;

                if (this.dp.AddZaposlen(ime, jmbg, datum, mesto, radniStaz, radnoMesto))
                {
                    MessageBox.Show("Uspesno ste uneli!", ime + " je uspesno dodat", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Dodavanje nije uspesno!", "Greska!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        #region Ogranicenja neka
        private bool Validacija()
        {
            if (String.IsNullOrEmpty(txtIme.Text))
            {
                return false;
            }
            else if (String.IsNullOrEmpty(txtJMBG.Text))
            {
                return false;
            }
            else if (String.IsNullOrEmpty(dateTimePicker1.Text))
            {
                return false;
            }
            else if (String.IsNullOrEmpty(txtMesto.Text))
            {
                return false;
            }
            else if (String.IsNullOrEmpty(cbRadniStaz.Text))
            {
                return false;
            }
            //ako je sve okej.
            return true;
        }
        private void txtIme_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetter(e.KeyChar) && !Char.IsControl(e.KeyChar) &&!Char.IsWhiteSpace(e.KeyChar))
                e.Handled = true;
        }

        private void txtJMBG_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txtMesto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetter(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void cbRadniStaz_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar) && !Char.IsLetter(e.KeyChar))
                e.Handled = true;
        }

        private void cbRadnoMesto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetter(e.KeyChar))
                e.Handled = true;
        }
        #endregion
    }
}
