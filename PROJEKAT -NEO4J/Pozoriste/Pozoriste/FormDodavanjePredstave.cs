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
    public partial class FormDodavanjePredstave : Form
    {
        DataProvider dp = new DataProvider();
        public FormDodavanjePredstave()
        {
            InitializeComponent();
            dp.PoveziBazu();
        }

        private void btnDodajPredstavu_Click(object sender, EventArgs e)
        {
            if (!Validacija())
            {
                return;
            }
            else
            {
                String naslov = txtNaslov.Text;
                String zanr = cbZanr.Text;
                String kratakOpis = txtKratakOpis.Text;
                if (dp.AddPredstava(naslov, zanr, kratakOpis))
                {
                    MessageBox.Show("Uspesno dodavanje predstave!", "Predstava " + naslov + " je uspesno dodatata dodata ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(" NIJE USPELO dodavanje predstave!", "  GRESKA!! ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void FormDodavanjePredstave_Load(object sender, EventArgs e)
        {

        }
        #region ogranicenja
        private void txtNaslov_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetter(e.KeyChar) && !Char.IsControl(e.KeyChar) && !Char.IsWhiteSpace(e.KeyChar))
                e.Handled = true;
        }
        private bool Validacija()
        {
            if (String.IsNullOrEmpty(txtNaslov.Text))
            {
                MessageBox.Show("Unesite naslov!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (String.IsNullOrEmpty(cbZanr.Text))
            {
                MessageBox.Show("Unesite zanr predstave!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (String.IsNullOrEmpty(txtKratakOpis.Text))
            {
                MessageBox.Show("Unesite opiss o predstavi!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        #endregion


    }
}
