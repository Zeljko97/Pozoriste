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
   
    public partial class Form1 : Form
    {
        DataProvider dp = new DataProvider();
        public Form1()
        {
            InitializeComponent();
            dp.PoveziBazu();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormPocetna fp = new FormPocetna();
            fp.Show();
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            FormAdmin f = new FormAdmin();
            f.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dp.PoveziBazu();
            this.ForeColor = Color.Black;
        }

        private void btnBlagajnik_Click(object sender, EventArgs e)
        {
            FormBlagajnik f = new FormBlagajnik();
            f.Show();
        }

        private void btnPredstave_Click(object sender, EventArgs e)
        {
            List<Predstava> predstave = new List<Predstava>();

            predstave = dp.GetPredstave();

            foreach (Predstava p in predstave)
            {
                listPredstave.Items.Add(p.naslov);
            }
            
        }

        private void listPredstave_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            
        }

        private void listPredstave_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            
        }

        private void listPredstave_ItemActivate(object sender, EventArgs e)
        {
            listGlumci.Clear();
            int i = listPredstave.SelectedIndices[0];
            string s = listPredstave.Items[i].Text;
            
            List<Glumac> glumci = new List<Glumac>();
            glumci = dp.vratiGlumceKojiGlumeU(s);

            foreach(Glumac g in glumci)
            {
                listGlumci.Items.Add(g.ime);
            }


        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Sala s = dp.GetSala(1);
            for (int i = 0; i < s.brojRedova; i++)
            {
                for (int j = 0; j < s.brojSedistaPoRedu; j++)
                {
                    dp.AddSediste(i, j, s);
                }
            }
            MessageBox.Show("Dodato");
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            List<Rezervacija> rez = new List<Rezervacija>();
            rez = dp.GetRezervacije();

            foreach (Rezervacija g in rez)
            {
                listGlumci.Items.Add(g.prikaz.datum);
            }
        }
    }
}
