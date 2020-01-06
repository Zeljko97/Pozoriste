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
    public partial class FormUpdatePredstava : Form
    {
        DataProvider dp = new DataProvider();
        public FormUpdatePredstava()
        {
            InitializeComponent();
            dp.PoveziBazu();
        }

        private void btnUpdatePredstava_Click(object sender, EventArgs e)
        {
            if (!Validacije())
            {
                return;
            }
            else
            {
                String naslov = FormAdmin.predstava.naslov;
                String zanr = cbZanr.Text;
                String kratakOpis = txtKratakOpis.Text;

                if (dp.UpdatePredstava(naslov, zanr, kratakOpis))
                {
                    MessageBox.Show("Uspesno azuriranje predstave!", "Predstava " + naslov + " je uspesno azurirana dodata ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show(" Neuspesno azuriranje predstave!", "  GRESKA!! ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            
        }

        private void FormUpdatePredstava_Load(object sender, EventArgs e)
        {
            txtKratakOpis.Text = FormAdmin.predstava.kratakOpis;
            lblNaslov.Text = FormAdmin.predstava.naslov;
            cbZanr.Text = FormAdmin.predstava.zanr;
            Text = "Azuriranje predstave :" + FormAdmin.predstava.naslov;

        }

        #region ogranicenje
        private bool Validacije()
        {
            if (String.IsNullOrEmpty(txtKratakOpis.Text))
            {
                MessageBox.Show("Unesite makar nesto u opisu", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (String.IsNullOrEmpty(cbZanr.Text))
            {
                MessageBox.Show("Izaberite zanr predstave.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        #endregion
    }
}
