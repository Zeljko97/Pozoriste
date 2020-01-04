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

        private void btnRepertoar_Click(object sender, EventArgs e)
        {
            FormKreiranjeRepertoara f = new FormKreiranjeRepertoara();
            f.Show();
        }

        private void btnDodajGlumca_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            txtIme.Visible = true;
            txtZaposlen.Visible = true;
            dateTimePicker1.Visible = true;
            cbPredstave.Visible = true;
            btnDodajG.Visible = true;
            for (int i = 0; i < 1000; i++)
            {
                cbPredstave.Items.Add(i);
            }
        }

        private void btnDodajG_Click(object sender, EventArgs e)
        {
            string ime = txtIme.Text;
            string datum = dateTimePicker1.Text;
            int zaposlen = Int32.Parse(txtZaposlen.Text);
            int brojPredstava = Int32.Parse(cbPredstave.Text);

          

                dp.AddGlumac(ime, datum, zaposlen, brojPredstava);
            MessageBox.Show("Dodali ste glumca");
        }

        private void btnObrisiGlumca_Click(object sender, EventArgs e)
        {
            if(dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Niste izabrali glumca!");
                return;
            }
            int indexRow = dataGridView1.CurrentRow.Index;

          
            string ime = (string)dataGridView1[0, indexRow].Value;

            dp.DeleteGlumac(ime);
            MessageBox.Show("Obrisali ste izabranog glumca iz sistema.");
        }

        private void btnObrisiZaposlenog_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Niste izabrali zaposlenog!");
                return;
            }
            int indexRow = dataGridView1.CurrentRow.Index;


            string ime = (string)dataGridView1[0, indexRow].Value;

            dp.DeleteZaposlen(ime);
            MessageBox.Show("Obrisali ste izabranog zaposlenog iz sistema.");
        }

        private void btnDodajRezisera_Click(object sender, EventArgs e)
        {
            FormNoviReziser f = new FormNoviReziser();
            f.Show();
        }

        private void btnObrisiRezisera_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Niste izabrali rezisera!");
                return;
            }
            int indexRow = dataGridView1.CurrentRow.Index;
            string ime = (string)dataGridView1[0, indexRow].Value;

            dp.DeleteRezisera(ime);
            MessageBox.Show("Obrisali ste izabranog rezisera iz sistema.");
        }
    }
}
