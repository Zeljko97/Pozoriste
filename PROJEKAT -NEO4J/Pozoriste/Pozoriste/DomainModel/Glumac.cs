using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pozoriste.DomainModel
{
    public class Glumac
    {
        public String ime { get; set; }
        public DateTime datumRodjenja { get; set; }
        public int zaposlen { get; set; }
        public int brojPredstava { get; set; }

        public List<Predstava> predstave { get; set; }

        public Uloga glumiU (Predstava predstava, String uloga)
        {  
            return null;
        }

    }
}
