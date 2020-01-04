using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Neo4jClient;
using Neo4jClient.Cypher;
using Pozoriste.DomainModel;

namespace Pozoriste
{
    public partial class FormPocetna : Form
    {

        private GraphClient client;
        DataProvider dp = new DataProvider();

        public FormPocetna()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Predstava p = new Predstava();
            p = dp.GetPredstava("Radovan III");
            List<Predstava> p1 = new List<Predstava>() ;
            p1.Add(p);
            dataGridView1.DataSource = p1;
        }

        private void FormPocetna_Load(object sender, EventArgs e)
        {
            
            dp.PoveziBazu();
        }
    }
}
