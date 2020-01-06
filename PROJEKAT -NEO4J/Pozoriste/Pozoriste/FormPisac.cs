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
    public partial class FormPisac : Form
    {
        DataProvider dp = new DataProvider();
        public FormPisac()
        {
            InitializeComponent();
            dp.PoveziBazu();
        }

        private void btnUcitajPisce_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = dp.GetPisci();
            dataGridView1.Columns["broj_komada"].Visible = false;
        }

        private void FormPisac_Load(object sender, EventArgs e)
        {
            Text = "Pisac predstave: " + FormAdmin.predstava.naslov;
            lblUputsvo.Text = "Oznacite pisca koji je napisao selektovano delo '" + FormAdmin.predstava.naslov+"'";

        }
        private void btnDodajPisca_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Niste izabrali pisca dela!", "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int indexRow = dataGridView1.CurrentRow.Index;
            string ime = (string)dataGridView1[0, indexRow].Value;
            //selektivano je ime pisca,i prosledjujemo naslov predstave
            string naslov = FormAdmin.predstava.naslov;
            if (dp.DodeliPisacDelo(ime,naslov))
            {
                MessageBox.Show("Pisac"+ime+" je napisao" + naslov,"Dodela uspesna",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Doslo je do greske .." + naslov, "Greska!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnNovPisac_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtIme.Text))
            {
                MessageBox.Show("Morate uneti ime i prezime pisca", "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            String ime = txtIme.Text;
            int brojDela = 0;
            brojDela = Convert.ToInt32(txtBrojDela.Text);
            
            if (dp.AddPisac(ime,brojDela))
            {
                MessageBox.Show(ime+" je uspesno dodat.", "Dodavanje uspesno", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtBrojDela.Text = "";
                txtIme.Text = "";
            }
            else
            {
                MessageBox.Show("Neuspesno dodavanje pisca", "Dodavanje neuspesno", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
        private void btnObrisiPisca_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Niste izabrali pisca dela!", "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int indexRow = dataGridView1.CurrentRow.Index;
            string ime = (string)dataGridView1[0, indexRow].Value;
            if (dp.DeletePisac(ime))
            {
                MessageBox.Show("Pisac" + ime + " je uspesno obrisan iz baze podataka.","Brisanje uspesno",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Doslo je do greske!", "Brisanje neuspesno", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #region ogranicenja
        private void txtIme_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetter(e.KeyChar) && !Char.IsControl(e.KeyChar) && !Char.IsWhiteSpace(e.KeyChar))
                e.Handled = true;
        }

        private void txtBrojDela_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }
        #endregion
    }
}
