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
    public partial class Form1 : Form
    {
        DataProvider dp = new DataProvider();
        public Form1()
        {
            InitializeComponent();
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
        }
    }
}
