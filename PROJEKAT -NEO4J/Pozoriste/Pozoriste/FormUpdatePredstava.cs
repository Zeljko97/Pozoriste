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
            String naslov = FormAdmin.predstava.naslov;
            String zanr = cbZanr.Text;
            String kratakOpis = txtKratakOpis.Text;

            if (dp.UpdatePredstava(naslov,zanr,kratakOpis))
            {
                MessageBox.Show("Uspesno azuriranje predstave!", "Predstava " + naslov + " je uspesno azurirana dodata ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(" Neuspesno azuriranje predstave!", "  GRESKA!! ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.Close();
        }

        private void FormUpdatePredstava_Load(object sender, EventArgs e)
        {
            txtKratakOpis.Text = FormAdmin.predstava.kratakOpis;
            lblNaslov.Text = FormAdmin.predstava.naslov;
            cbZanr.Text = FormAdmin.predstava.zanr;
            Text = "Azuriranje predstave :" + FormAdmin.predstava.naslov;

        }
    }
}
