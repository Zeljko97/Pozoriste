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
    public partial class FormLogInAdmin : Form
    {
        DataProvider dp = new DataProvider();
        public FormLogInAdmin()
        {
            InitializeComponent();
            dp.PoveziBazu();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtUserName.Text))
            {
                MessageBox.Show("Niste uneli korisnicko ime","Korisnicko ime je neophodno uneti",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            Administrator a = new Administrator();
            a = dp.GetAdmin(txtUserName.Text);
            FormAdmin f = new FormAdmin();
            if(a == null)
            {
                MessageBox.Show("Pogresno korisnicko ime ili lozinka.");
                return;
            }
            else if(a.password == txtPassword.Text)
            {
                f.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Pogresno korisnicko ime ili lozinka.");
            }
        }

    }
}
