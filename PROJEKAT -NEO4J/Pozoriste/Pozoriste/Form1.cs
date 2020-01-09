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
            FormLogInAdmin f = new FormLogInAdmin();
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
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            listPredstave.Visible = true;
            listGlumci.Visible = true;

            List<Predstava> predstave = new List<Predstava>();

            predstave = dp.GetPredstave();

            foreach (Predstava p in predstave)
            {
                Reziser r = dp.GetReziserByPredstava(p.naslov);
                listPredstave.Items.Add(p.naslov);
                listPredstave.Items.Add("Reziser: " + r.ime);
                listPredstave.Items.Add("");
            }

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

        private void btnRepertoar_Click(object sender, EventArgs e)
        {
            listRepertoar.Visible = true;
            Repertoar r = new Repertoar();
            r = dp.GetRepertoar(dateTimePicker1.Text);
            if(r==null)
            {
                MessageBox.Show("Za ovaj datum nema repertoara.");
                return;
            }
            r.predstave = dp.GetPredstavePoDatumuIgranja(r.datum);

            foreach(Predstava p in r.predstave)
            {
                listRepertoar.Items.Add(p.naslov);
            }
        }

        private void listRepertoar_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listGlumci_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }

        private void listPredstave_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listGlumci_ItemActivate(object sender, EventArgs e)
        {
            
            int i = listGlumci.SelectedIndices[0];
            string s = listGlumci.Items[i].Text;
            listGlumci.Clear();
            Glumac glumac = dp.GetGlumac(s);
            List<Predstava> predstave = dp.GetPredstaveByGlumac(s);

            listGlumci.Items.Add("- Ime: " + glumac.ime);
            listGlumci.Items.Add("- Broj predstava: " + glumac.brojPredstava.ToString());
            listGlumci.Items.Add("- Zaposlen (godina): " + glumac.zaposlen.ToString());
            listGlumci.Items.Add("- Predstave:");
            foreach(Predstava p in predstave)
            {
                listGlumci.Items.Add(p.naslov);
            }
        }
    }
}
