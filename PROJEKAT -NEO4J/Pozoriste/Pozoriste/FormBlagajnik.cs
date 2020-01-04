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

        public List<Sala> sala;
        public List<Predstava> predstave;
        public List<Sediste> sedista;
        public List<Button> dugmici;
        public int brojRedova, brojSedistaPoRedu;

        public FormBlagajnik()
        {
            sala = new List<Sala>();
            predstave = new List<Predstava>();
            sedista = new List<Sediste>();
            dugmici = new List<Button>();

            InitializeComponent();
        }

        private void FormBlagajnik_Load(object sender, EventArgs e)
        {
            DataProvider dp = new DataProvider();
            if (dp.PoveziBazu() > 0)
            {
                predstave = dp.GetPredstave();

                foreach (Predstava p in predstave)
                {
                    cbPredstave.Items.Add(p.naslov);
                }

                sala = dp.GetSale();

                foreach (Sala s in sala)
                {
                    cbSala.Items.Add(s.brojSale);
                }
            }




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
                    Size s = new Size();
                    s.Width = 20;
                    s.Height = 20;

                    Size z = new Size();
                    Button b = new Button();
                    int j;

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
                                        sedista.Add(sed);
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
                                        foreach (Sediste sedi in sedista)
                                        {
                                            if (sedi.brojSedista == sed.brojSedista && sedi.red == sed.red)
                                            {
                                                sedista.Remove(sedi);
                                                return;
                                            }

                                        }
                                        dugmici.Remove(button);
                                        button.BackColor = Color.LightGray;
                                        // label10.Text = (cena * sedisteSala.Count).ToString()+" RSD";


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
            }
                
            
        }
    }
}
                                
                                
                               

                        
                    
                
            
       
    

