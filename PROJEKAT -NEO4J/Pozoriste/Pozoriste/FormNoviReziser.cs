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
            string ime = txtIme.Text;
            int brojPredstava = Int32.Parse(txtBrojPredstava.Text);

            dp.AddReziser(ime, brojPredstava);

            MessageBox.Show("Dodali ste rezisera.");

        }
    }
}
