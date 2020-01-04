using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Pozoriste.DomainModel;

namespace Pozoriste
{
    public partial class FormKreiranjeRepertoara : Form
    {

        DataProvider dp = new DataProvider();

        public FormKreiranjeRepertoara()
        {
            InitializeComponent();
            dp.PoveziBazu();
        }

        private void btnPredstave_Click(object sender, EventArgs e)
        {
            List<Predstava> predstave = new List<Predstava>();

            predstave = dp.GetPredstave();

            foreach(Predstava p in predstave)
            {
                listPredstave.Items.Add(p.naslov);
            }
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            if (listPredstave.SelectedIndices.Count == 0)
                MessageBox.Show("Izaberite predstavu");
            else
            {
                String naslov = listPredstave.SelectedItems[0].ToString();
                Predstava p = dp.GetPredstava(naslov);
               dp.DodajPredstavuURepertoar(p);
               listRepertoar.Items.Add(p.naslov);
               MessageBox.Show("Dodali ste predstavu u repertoar");
                
            }
        }
    }
}
