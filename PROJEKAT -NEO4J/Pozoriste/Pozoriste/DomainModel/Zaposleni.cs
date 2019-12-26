using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pozoriste.DomainModel;

namespace Pozoriste.DomainModel
{
    public class Zaposleni
    {
        public string ime { get; set; }
        public string jmbg { get; set; }
        public string datumRodjenja { get; set; }
        public string mestoRodjenja { get; set; }
        public int radniStaz { get; set; }
        public string radnoMesto { get; set; }
        public string userName { get; set; }
        public string password { get; set; }

        public List<Glumac> glumci { get; set; }
        //treba da se uradi da se ucitavaju i svi glumci, u zaposlene, zato lista glumaca
        
    }
}
