using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Neo4jClient;
using Neo4jClient.Cypher;
using Pozoriste.DomainModel;

namespace Pozoriste
{
    public class DataProvider
    {
        private GraphClient client;

        public int PoveziBazu()
        {
            client = new GraphClient(new Uri("http://localhost:7474/db/data"), "neo4j", "zeljkobaze");

            try
            {
                client.Connect();
            }
            catch(Exception exc)
            {
                return -1;
            }
            return 1;
        }
        #region Glumci
        public  List<Glumac> GetGlumci()
        {
            Dictionary<string, object> queryDict = new Dictionary<string,object>();

            var query = new CypherQuery("match (n:Glumac) return n;",queryDict, CypherResultMode.Set);

            List<Glumac> glumci = ((IRawGraphClient)client).ExecuteGetCypherResults<Glumac>(query).ToList();
            return glumci;
        }

        public bool AddZaposlen(String ime, String jmbg, String datumRodjenja, String mestoRodjenja, int radniStaz, String radnoMesto)
        {
            var query = new CypherQuery("CREATE (z:Zaposleni {ime:'" + ime + "', jmbg:'" + jmbg + "', datumRodjenja:'" + datumRodjenja + "', mestoRodjenja:'" + mestoRodjenja + "', radniStaz:" + radniStaz + ", radnoMesto:'" + radnoMesto + "'})", new Dictionary<string, object>(), CypherResultMode.Set);
         // var query1 = new CypherQuery("MATCH (a:Zaposleni),(b:Pozoriste) WHERE a.ime:'" + ime + "' CREATE (a)-[:RADI_U]->(b)", new Dictionary<string, object>(), CypherResultMode.Set);

            try
            {
                ((IRawGraphClient)client).ExecuteCypher(query);
                ((IRawGraphClient)client).ExecuteCypher(query1);
            }
            catch(Exception e)
            {
                return false;
            }
            try
            {
                
                ((IRawGraphClient)client).ExecuteCypher(query1);
            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }

        #endregion


        #region Predstave
        public List<Predstava> GetPredstave()
        {
            Dictionary<string, object> queryDict = new Dictionary<string, object>();
            var query = new CypherQuery("match (n:Predstava) return n;", queryDict, CypherResultMode.Set);

            List<Predstava> predstave = ((IRawGraphClient)client).ExecuteGetCypherResults<Predstava>(query).ToList();
            return predstave;
        }

        #endregion


        #region Reziseri
        public List<Reziser> GetReziseri()
        {
            Dictionary<string, object> queryDict = new Dictionary<string, object>();
            var query = new CypherQuery("match (n:Reziser) return n;", queryDict, CypherResultMode.Set);

            List<Reziser> reditelji = ((IRawGraphClient)client).ExecuteGetCypherResults<Reziser>(query).ToList();
            return reditelji;

        }

        #endregion

        #region Pisci
        public List<Pisac> GetPisci()
        {
            Dictionary<string, object> queryDict = new Dictionary<string, object>();
            var query = new CypherQuery("match (n:Pisac) return n;", queryDict, CypherResultMode.Set);

            List<Pisac> pisci = ((IRawGraphClient)client).ExecuteGetCypherResults<Pisac>(query).ToList();
            return pisci;
        }


        #endregion


        #region Zaposleni
        public List<Zaposleni> GetZaposleni()
        {
            Dictionary<string, object> queryDict = new Dictionary<string, object>();
            var query = new CypherQuery("match (n:Zaposleni) return n;", queryDict, CypherResultMode.Set);

            List<Zaposleni> zaposleni = ((IRawGraphClient)client).ExecuteGetCypherResults<Zaposleni>(query).ToList();
            return zaposleni;
        }

        #endregion
    }
}
