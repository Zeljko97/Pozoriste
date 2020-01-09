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
        public List<Predstava> rep=new List<Predstava>(); // za repertoar
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
              // dp.DodajPredstavuURepertoar(p);
               listRepertoar.Items.Add(p.naslov);
                rep.Add(p);
               MessageBox.Show("Dodali ste predstavu u repertoar");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String datum = dateTimePicker1.Text;
            dp.KreirajRepertoar(rep, datum);
            MessageBox.Show("Repertoar za datum" + datum +" je uspesno kreiran!","Uspesno kreiranje repertoara",MessageBoxButtons.OK,MessageBoxIcon.Information);
            rep.Clear();
            this.Close();
        }

        private void FormKreiranjeRepertoara_Load(object sender, EventArgs e)
        {

        }

        private void btnUcitajRepertoare_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = dp.GetRepertoars();

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
