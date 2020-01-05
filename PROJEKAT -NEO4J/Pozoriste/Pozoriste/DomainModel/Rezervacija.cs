using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pozoriste.DomainModel
{
    public class Rezervacija
    {
        public List<Sediste> sedista { get; set; }
        public Prikaz prikaz { get; set; }
        public String brojRezSedista { get; set; }
    }
}
