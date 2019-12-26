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
    public partial class FormAdmin : Form
    {
        DataProvider dp = new DataProvider();

        public FormAdmin()
        {
            InitializeComponent();

            dp.PoveziBazu();
        }
        
        private void btnZaposleni_Click(object sender, EventArgs e)
        {
            List<Zaposleni> zaposleni = new List<Zaposleni>();
            zaposleni = dp.GetZaposleni();

            dataGridView1.DataSource = zaposleni;
        }
        


        private void btnGlumci_Click(object sender, EventArgs e)
        {
            List<Glumac> glumci = new List<Glumac>();
            glumci = dp.GetGlumci();

            dataGridView1.DataSource = glumci;
        }

        private void btnReziseri_Click(object sender, EventArgs e)
        {
            List<Reziser> reziseri = new List<Reziser>();
            reziseri = dp.GetReziseri();

            dataGridView1.DataSource = reziseri;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormDodajZaposlenog f = new FormDodajZaposlenog();
            f.Show();
        }
    }
}
