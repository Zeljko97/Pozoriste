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
    public partial class FormDodelaUloge : Form
    {
        DataProvider dp = new DataProvider();
        public FormDodelaUloge()
        {
            InitializeComponent();
            dp.PoveziBazu();
        }
        private void FormDodelaUloge_Load(object sender, EventArgs e)
        {
            Text ="  " +FormAdmin.glumac.ime;
            vidljivost(false);
        }
        private void vidljivost(bool s)
        {
            lblUloga.Visible = s;
            txtUloga.Visible = s;
            btnDodaj.Visible = s;
            lblGlumac.Visible = s;
            lblPredstava.Visible = s;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count == 0)
            {
                MessageBox.Show("Niste izabrali predstavu.","Potrebna je selekcija!",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            int indexRow = dataGridView2.CurrentRow.Index;
            lblGlumac.Text = FormAdmin.glumac.ime;
            string naslov = (string)dataGridView2[0, indexRow].Value;
            lblPredstava.Text = naslov;
            vidljivost(true);

        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtUloga.Text))
            {
                MessageBox.Show("Morate uneti ulogu", "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            String uloga = txtUloga.Text;
            int indexRow = dataGridView2.CurrentRow.Index;
            string naslov = (string)dataGridView2[0, indexRow].Value;
            if (dp.DodeliUlogu(FormAdmin.glumac.ime,naslov,uloga))
            {
                MessageBox.Show("Glumac " + FormAdmin.glumac.ime + " je dobio ulogu '"+ uloga+ "' u predstavi '"+naslov+"'","Uspesno dodeljivanje uloge",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Greska!", "Doslo je do greske",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            vidljivost(false);
            txtUloga.Text = "";
        }

        private void btnDateUloge_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = dp.vratiPredstaveUKojojGlumi(FormAdmin.glumac.ime);
            dataGridView1.Columns["pisac"].Visible = false;
            dataGridView1.Columns["reditelj"].Visible = false;
            dataGridView1.Columns["zanr"].Visible = false;
            dataGridView1.Columns["kratakOpis"].Visible = false;


        }

        private void btnPredstave_Click(object sender, EventArgs e)
        {
            dataGridView2.DataSource = dp.GetPredstave();
            dataGridView1.Columns["pisac"].Visible = false;
            dataGridView1.Columns["reditelj"].Visible = false;
            dataGridView1.Columns["zanr"].Visible = false;
            dataGridView1.Columns["kratakOpis"].Visible = false;

        }

        #region ogranicenje
        private void txtUloga_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetter(e.KeyChar) && !Char.IsControl(e.KeyChar) && !Char.IsWhiteSpace(e.KeyChar))
                e.Handled = true;
        }
        #endregion
    }
}
