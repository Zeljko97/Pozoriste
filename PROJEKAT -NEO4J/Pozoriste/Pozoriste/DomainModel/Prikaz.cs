using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pozoriste.DomainModel
{
    public class Prikaz
    {
        public Sala sala { get; set; }
        public Predstava predstava { get; set; }
        
        public String datum { get; set; }
        public String vreme { get; set; }
        public String cena { get; set; }

        public Prikaz() { }
        public Prikaz(Sala sala, Predstava predstava, String datum, String vreme, String cena)
        {
            this.sala = sala;
            this.predstava = predstava;
            this.datum = datum;
            this.vreme = vreme;
            this.cena = cena;
        }
    }
}
