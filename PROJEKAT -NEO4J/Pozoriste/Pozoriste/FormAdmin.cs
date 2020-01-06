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
        //za update
        public static Zaposleni z = null;
        public static Predstava predstava = null;
        public static Glumac glumac = null;
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

            dataGridView3.DataSource = glumci;
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
            vidljivost(true);
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
            MessageBox.Show("Uspesno ste dodali glumca",ime+" je uspesno dodat.",MessageBoxButtons.OK,MessageBoxIcon.Information);
            vidljivost(false);
            
        }

        private void btnObrisiGlumca_Click(object sender, EventArgs e)
        {
            if(dataGridView3.SelectedRows.Count == 0)
            {
                MessageBox.Show("Niste izabrali glumca!");
                return;
            }
            int indexRow = dataGridView3.CurrentRow.Index;

          
            string ime = (string)dataGridView3[0, indexRow].Value;

            if (dp.DeleteGlumac(ime))
            {
                MessageBox.Show("Obrisali ste izabranog glumca iz sistema.");
            }
            else { MessageBox.Show("Doslo je do greske."); }
           
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


        #region dodatno
        private void vidljivost(bool s)
        {
            label1.Visible = s;
            label2.Visible = s;
            label3.Visible = s;
            label4.Visible = s;
            txtIme.Visible = s;
            txtIme.Text = "";
            txtZaposlen.Visible = s;
            txtZaposlen.Text = "";
            dateTimePicker1.Visible = s;
            cbPredstave.Visible = s;
            cbPredstave.SelectedValue = "";
            btnDodajG.Visible = s;
        }
        private void UcitajPredstave()
        {
            List<Predstava> predstave = new List<Predstava>();

            predstave = dp.GetPredstave();

            foreach (Predstava p in predstave)
            {
                listPredstave.Items.Add(p.naslov);
            }
        }
        #endregion

        private void btnPredstave_Click(object sender, EventArgs e)
        {
            UcitajPredstave();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }


        private void btnReziseri_Click_1(object sender, EventArgs e)
        {
            List<Reziser> reziseri = new List<Reziser>();
            reziseri = dp.GetReziseri();

            dataGridView2.DataSource = reziseri;
        }

        private void btnDodajRezisera_Click_1(object sender, EventArgs e)
        {
            FormNoviReziser f = new FormNoviReziser();
            f.Show();
        }

        private void btnObrisiRezisera_Click_1(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count == 0)
            {
                MessageBox.Show("Niste izabrali rezisera!");
                return;
            }
            int indexRow = dataGridView2.CurrentRow.Index;
            string ime = (string)dataGridView2[0, indexRow].Value;

            dp.DeleteRezisera(ime);
            MessageBox.Show("Obrisali ste izabranog rezisera iz sistema.");
        }

        private void btnReziraj_Click(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count == 0)
            {
                MessageBox.Show("Niste izabrali rezisera!");
                return;
            }
            int indexRow = dataGridView2.CurrentRow.Index;
            string ime = (string)dataGridView2[0, indexRow].Value;

            string text = listPredstave.GetItemText(listPredstave.SelectedItem);

            dp.ReziraoJe(ime, text);
            MessageBox.Show("Reziser " + ime + "  je rezirao predstavu: " + text, "Informacija dodavanja grane", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listPredstave.ClearSelected();
        }

        private void btnPredstave_Click_1(object sender, EventArgs e)
        {
            UcitajPredstave();
        }

        private void btnUpdateZaposleni_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Niste izabrali glumca!");
                return;
            }
            int indexRow = dataGridView1.CurrentRow.Index;
            string ime = (string)dataGridView1[0, indexRow].Value;
            z = dp.getZaposlen(ime);
            FormUpdateZaposleni f = new FormUpdateZaposleni();
            f.Show();
        }
        #region sale
        
        private void btnPrikaziSale_Click(object sender, EventArgs e)
        {
            UcitajSale();
        }
        private void UcitajSale()
        {
            List<Sala> sale = new List<Sala>();
            sale = dp.GetSale();

            dataGridView4.DataSource = sale;
        }

        private void btnDodajSalu_Click(object sender, EventArgs e)
        {
            FormDodavanjeSale fds = new FormDodavanjeSale();
            fds.Show();
        }

        private void btnObrisiSalu_Click(object sender, EventArgs e)
        {
            if (dataGridView4.SelectedRows.Count == 0)
            {
                MessageBox.Show("Niste izabrali glumca!");
                return;
            }
            int indexRow = dataGridView4.CurrentRow.Index;
            int brojSale = (int)dataGridView4[0, indexRow].Value;


            if (dp.DeleteSala(brojSale))
            {
                MessageBox.Show("Obrisali ste izabranu salu iz sistema!","Uspesno obrisano!",MessageBoxButtons.OK,MessageBoxIcon.Information);
                UcitajSale();
            }
            else
            {
                MessageBox.Show("Neuspesno brisanje!!", "GRESKA!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            
        }
        #endregion
        #region predstave
        private void btnPrikaziPredstave_Click(object sender, EventArgs e)
        {
            List<Predstava> predstave = new List<Predstava>();
            predstave = dp.GetPredstave();

            dataGridView5.DataSource = predstave;
            dataGridView5.Columns["kratakOpis"].Visible = false;
            dataGridView5.Columns["reditelj"].Visible = false;
            dataGridView5.Columns["pisac"].Visible = false;
        }

        private void dataGridView5_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dataGridView5.SelectedRows.Count == 0)
            {
                MessageBox.Show("Niste izabrali predstavu!","Greska",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            int indexRow = dataGridView5.CurrentRow.Index;
            string naslov = (string)dataGridView5[0, indexRow].Value;
            Predstava p = dp.GetPredstava(naslov);
            MessageBox.Show(p.kratakOpis, naslov, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView5.SelectedRows.Count == 0)
            {
                MessageBox.Show("Niste izabrali predstavu!", "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int indexRow = dataGridView5.CurrentRow.Index;
            string naslov = (string)dataGridView5[0, indexRow].Value;

            if (dp.DeletePredstava(naslov))
            {
                MessageBox.Show("Uspesno brisanje predstave "+naslov, "Predstava " + naslov + " je uspesno azurirana dodata ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(" Neuspesno brisanje predstave!", "  GRESKA!! ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dataGridView5.SelectedRows.Count == 0)
            {
                MessageBox.Show("Niste izabrali predstavu!", "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int indexRow = dataGridView5.CurrentRow.Index;
            string naslov = (string)dataGridView5[0, indexRow].Value;
            predstava = dp.GetPredstava(naslov);
            FormUpdatePredstava fup = new FormUpdatePredstava();
            fup.Show();

        }

        private void btnDodajPredstavu_Click(object sender, EventArgs e)
        {
            FormDodavanjePredstave fdp = new FormDodavanjePredstave();
            fdp.Show();
        }
        private void btnDodajPisca_Click(object sender, EventArgs e)
        {
            if (dataGridView5.SelectedRows.Count == 0)
            {
                MessageBox.Show("Niste izabrali predstavu!", "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int indexRow = dataGridView5.CurrentRow.Index;
            string naslov = (string)dataGridView5[0, indexRow].Value;
            predstava = dp.GetPredstava(naslov);
            FormPisac fp = new FormPisac();
            fp.Show();
        }
        #endregion



        private void btnDodeliUlogu_Click(object sender, EventArgs e)
        {
            if (dataGridView3.SelectedRows.Count == 0)
            {
                MessageBox.Show("Niste izabrali glumca!");
                return;
            }
            int indexRow = dataGridView3.CurrentRow.Index;
            string ime = (string)dataGridView3[0, indexRow].Value;
            glumac = dp.GetGlumac(ime);
            FormDodelaUloge fdu = new FormDodelaUloge();
            fdu.Show();

        }
    }
}
