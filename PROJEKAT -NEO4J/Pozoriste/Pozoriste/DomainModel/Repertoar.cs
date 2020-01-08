using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pozoriste.DomainModel
{
    public class Repertoar
    {
        public string datum { get; set; }
        public List<Predstava> predstave { get; set; }

        public void AddPredstava(Predstava p)
        {
            this.predstave.Add(p);
        }
    }
}
