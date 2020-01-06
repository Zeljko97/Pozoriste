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
    public partial class FormUpdateZaposleni : Form
    {
        DataProvider dp = new DataProvider();
        public FormUpdateZaposleni()
        {
            InitializeComponent();
            dp.PoveziBazu();
        }

        private void FormUpdateZaposleni_Load(object sender, EventArgs e)
        {
            lblDatumRodjenja.Text = FormAdmin.z.datumRodjenja;
            lblIme.Text = FormAdmin.z.ime;
            lblJMBG.Text = FormAdmin.z.jmbg;
            txtMesto.Text = FormAdmin.z.mestoRodjenja;
            cbRadniStaz.Text = FormAdmin.z.radniStaz.ToString();
            cbRadnoMesto.Text = FormAdmin.z.radniStaz.ToString();
            for (int i = 0; i < 50; i++)
            {
                cbRadniStaz.Items.Add(i);
            }
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            String ime = lblIme.Text;
            String datum = lblDatumRodjenja.Text;
            String jmbg = lblJMBG.Text;
            String mesto = txtMesto.Text;
            int radniStaz = Convert.ToInt32(cbRadniStaz.Text);
            String radnoMesto = cbRadnoMesto.Text;

            if (this.dp.UpdateZaposlen(ime, jmbg, datum, mesto, radniStaz, radnoMesto))
            {
                MessageBox.Show("Uspesno ste update korisnika!!", ime + " je uspesno dodat", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Dodavanje nije uspesno!", "Greska!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
