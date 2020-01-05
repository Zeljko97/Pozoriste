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
    public partial class FormBlagajnik : Form
    {
        private List<Sala> sale;
        private List<Sediste> sedisteSala;
        private List<Button> dugmici;
        private int brojRedova, brojSedistaPoRedu;
        private List<Predstava> predstave;

        private List<Prikaz> prikazi;
        private Rezervacija rezervacija;
        private double cena;
        List<Rezervacija> rezervacije;
        public FormBlagajnik()
        {
            sale = new List<Sala>();
            sedisteSala = new List<Sediste>();
            dugmici = new List<Button>();
            predstave = new List<Predstava>();

            rezervacija = new Rezervacija();
            prikazi = new List<Prikaz>();
            cena = 0;

            rezervacije = new List<Rezervacija>();

            InitializeComponent();
        }

        private void FormBlagajnik_Load(object sender, EventArgs e)
        {
            DataProvider dp = new DataProvider();
            
            if(dp.PoveziBazu() > 0)
            {
               
                predstave = dp.GetPredstave();
            }

           
            foreach(Predstava p in predstave)
            {
                cbPredstave.Items.Add(p.naslov);
            }

            List<Rezervacija> rezervacije = new List<Rezervacija>();
            rezervacije = dp.GetRezervacije();


        }

        private void cbSala_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataProvider dp = new DataProvider();
            Sala sala = new Sala();

            if (dp.PoveziBazu() > 0)
            {
                if (cbSala.SelectedIndex == -1)
                    return;
                else
                {
                    Size q = new Size();
                    q.Width = 0;
                    flowLayoutPanel1.Controls.Clear();
                    flowLayoutPanel1.MaximumSize = q;

                    sala = dp.GetSala(Int32.Parse(cbSala.Text));
                    brojRedova = sala.brojRedova;
                    brojSedistaPoRedu = sala.brojSedistaPoRedu;

                    Size s = new Size();
                    s.Width = 20;
                    s.Height = 20;
                    Size z = new Size();
                    int j;
                    Button b = new Button();

                    for (int i = 0; i < brojRedova; i++)
                    {
                        for (j = 0; j < brojSedistaPoRedu; j++)
                        {

                            b = new Button();
                            b.Click += (object sender2, EventArgs e2) =>
                                {
                                    Button button = sender2 as Button;
                                    
                                    if (button.BackColor != Color.Blue)
                                    {
                                        String[] ime = button.Name.Split(',');
                                        Sediste sed = new Sediste();
                                        sed.red = Int32.Parse(ime[0]);
                                        sed.brojSedista = Int32.Parse(ime[1]);
                                        sed.zauzeto = true;
                                        sedisteSala.Add(sed);
                                        dugmici.Add(button);
                                        button.BackColor = Color.Blue;

                                    }
                                    else
                                    {
                                        String[] ime = button.Name.Split(',');
                                        Sediste sed = new Sediste();
                                        sed.red = Int32.Parse(ime[0]);
                                        sed.brojSedista = Int32.Parse(ime[1]);
                                        sed.zauzeto = true;
                                        foreach (Sediste sedi in sedisteSala)
                                        {
                                            if (sedi.brojSedista == sed.brojSedista && sedi.red == sed.red)
                                            {
                                                sedisteSala.Remove(sedi);
                                                return;
                                            }
                                        }
                                        dugmici.Remove(button);
                                        button.BackColor = Color.LightGray;

                                    }
                                };
                            b.BackColor = Color.LightGray;
                            b.Name = i.ToString() + "," + j.ToString();
                            b.Text = j.ToString();
                            b.Size = s;
                            flowLayoutPanel1.Controls.Add(b);
                        }
                        z.Width = flowLayoutPanel1.Width;
                        flowLayoutPanel1.MaximumSize = z;
                    }

                }

                //za cenu
                Prikaz p = new Prikaz();
                p = dp.GetPrikazPoVremenu(cbDatum.Text, cbVreme.Text);
                lbCena.Text = p.cena;

                rezervacija.prikaz = p;
            }
        }
            
        

        private void cbPredstave_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataProvider dp = new DataProvider();
            if(dp.PoveziBazu() > 0)
            {
                if (cbPredstave.SelectedIndex == -1)
                    return;
                else
                {
                    flowLayoutPanel1.Controls.Clear();
                    cbVreme.SelectedIndex = -1;
                    cbVreme.Items.Clear();
                    cbSala.SelectedIndex = -1;
                    cbSala.Items.Clear();

                    prikazi = dp.GetPrikazZaPredstavu(cbPredstave.Text);
                    foreach (Prikaz p in prikazi)
                        if (!cbDatum.Items.Contains(p.datum))
                            cbDatum.Items.Add(p.datum);
                }
            }
        }

        private void cbDatum_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbVreme.SelectedIndex = -1;
            DataProvider dp = new DataProvider();
            if(dp.PoveziBazu() > 0)
            {
                if(cbDatum.SelectedIndex == -1)
                    return;
                else{
                    flowLayoutPanel1.Controls.Clear();
                    cbVreme.SelectedIndex = -1;
                    cbVreme.Items.Clear();
                    cbSala.SelectedIndex = -1;
                    cbSala.Items.Clear();

                    prikazi = dp.GetPrikazZaPredstavu(cbPredstave.Text);
                    foreach (Prikaz p in prikazi)
                        if (!cbVreme.Items.Contains(p.vreme))
                            cbVreme.Items.Add(p.vreme);
                }
            }
        }

        private void cbVreme_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbSala.SelectedIndex = -1;
            DataProvider dp = new DataProvider();
            if (dp.PoveziBazu() > 0)
            {
                if (cbDatum.SelectedIndex == -1)
                    return;
                else
                {
                    flowLayoutPanel1.Controls.Clear();
                    cbSala.SelectedIndex = -1;
                    cbSala.Items.Clear();
                    sale = dp.GetSalaPoVremenu(cbDatum.Text, cbVreme.Text);
                    foreach (Sala s in sale)
                        cbSala.Items.Add(s.brojSale);
                    
                }
            }
        }

        private void btnRezervacija_Click(object sender, EventArgs e)
        {
            DataProvider dp = new DataProvider();
            if(dp.PoveziBazu()> 0)
            {
                rezervacija.brojRezSedista = sedisteSala.Count.ToString();
                rezervacija.sedista = sedisteSala;
                if (dp.zauzmiSediste(rezervacija, cbPredstave.Text, cbSala.Text))
                    MessageBox.Show("Uspesno rezervisano.");
                else
                    MessageBox.Show("Greska!");
              
            }
            foreach(Button b in dugmici)
            {
                b.Enabled = false;
                b.BackColor = Color.Red;
            }
        }
    }
}
                                
                                
                               

                        
                    
                
            
       
    

