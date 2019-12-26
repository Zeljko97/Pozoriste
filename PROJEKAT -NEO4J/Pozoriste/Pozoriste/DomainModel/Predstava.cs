using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pozoriste.DomainModel;
namespace Pozoriste.DomainModel
{
    public class Predstava
    {
        public String naslov { get; set; }
        public String zanr { get; set; }
        public String kratakOpis { get; set; }

        public List<Glumac> glumci { get; set; }
        public Reziser reditelj { get; set; }
        public Pisac pisac { get; set; }
    }
}
