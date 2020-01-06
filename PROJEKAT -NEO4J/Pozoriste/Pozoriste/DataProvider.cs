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

        public bool AddGlumac(String ime, String datumRodjenja, int zaposlen, int brojPredstava)
        {
            var query = new CypherQuery("CREATE (z:Glumac {ime:'" + ime + "',  datumRodjenja:'" + datumRodjenja + "', zaposlen:" + zaposlen + ", brojPredstava:" + brojPredstava  + "})", new Dictionary<string, object>(), CypherResultMode.Set);

            try
            {
                ((IRawGraphClient)client).ExecuteCypher(query);

            }
            catch (Exception e)
            {
                return false;
            }

            return true;
        }

        public bool DeleteGlumac(String ime)
        {
            var query = new CypherQuery("MATCH (n:Glumac {ime: '" + ime + "' })DETACH DELETE n", new Dictionary<string, object>(), CypherResultMode.Set);

            try
            {
                ((IRawGraphClient)client).ExecuteCypher(query);

            }
            catch (Exception e)
            {
                return false;
            }

            return true;
        }


        public List<Glumac> vratiGlumceKojiGlumeU(String naslovPredstave)
        {
            var query = new CypherQuery("MATCH (n:Glumac)-[:GLUMI_U]-(p:Predstava) where p.naslov = '" + naslovPredstave + "' return n", new Dictionary<string, object>(), CypherResultMode.Set);
            List<Glumac> glumci = ((IRawGraphClient)client).ExecuteGetCypherResults<Glumac>(query).ToList();
            return glumci;
        }

        public List<Predstava> vratiPredstaveKojeJeRezirao(string reziser)
        {
            //MATCH (n:Predstava)-[:REZIRAO]-(r:Reziser) where r.ime = 'Jagos Markovic' return n
            var query = new CypherQuery("MATCH (n:Predstava)-[:REZIRAO]-(r:Reziser) where r.ime = '" + reziser + "' return n", new Dictionary<string, object>(), CypherResultMode.Set);
            List<Predstava> predstave = ((IRawGraphClient)client).ExecuteGetCypherResults<Predstava>(query).ToList();
            return predstave;
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

        public Predstava GetPredstava(string naslov)
        {
            Dictionary<string, object> queryDict = new Dictionary<string, object>();
            var query = new CypherQuery("MATCH (Predstava{ naslov:'" + naslov + "'}) RETURN Predstava; ", queryDict, CypherResultMode.Set);

            Predstava p = ((IRawGraphClient)client).ExecuteGetCypherResults<Predstava>(query).SingleOrDefault();
            return p;
        }

        public bool DeletePredstava(string naslov)
        {
            var query = new CypherQuery("MATCH (n:Predstava {naslov: '" + naslov + "' }) DETACH DELETE n", new Dictionary<string, object>(), CypherResultMode.Set);
            try
            {
                ((IRawGraphClient)client).ExecuteCypher(query);
            }
            catch (Exception e)
            {
                return false;
            }
            return true;
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

        public bool AddReziser(String ime, int brojPredstava)
        {
            var query = new CypherQuery("CREATE (z:Reziser {ime:'" + ime + "', brojPredstava:" + brojPredstava + "})", new Dictionary<string, object>(), CypherResultMode.Set);

            try
            {
                ((IRawGraphClient)client).ExecuteCypher(query);

            }
            catch (Exception e)
            {
                return false;
            }

            return true;
        }
        public bool ReziraoJe(String reziser, string naslovPredstave)
        {
            //MATCH (a:Reziser),(b:Predstava) WHERE a.ime = 'Jagos Markovic' AND b.naslov = 'Tako je (ako vam se tako cini)' CREATE (a)-[:REZIRAO {Predstava:['Tako je (ako vam se tako cini']}]->(b)
            var query = new CypherQuery("MATCH (a:Reziser),(b:Predstava) WHERE a.ime = '" + reziser + "' AND b.naslov = '" + naslovPredstave + "' MERGE (a)-[:REZIRAO {Predstava:['"+naslovPredstave+"']}]->(b)", new Dictionary<string, object>(), CypherResultMode.Set);
            try
            {
                ((IRawGraphClient)client).ExecuteCypher(query);
            }
            catch (Exception e)
            {
                return false;
            }

            return true;

        }

        public bool DeleteRezisera(String ime)
        {
            var query = new CypherQuery("MATCH (n:Reziser {ime: '" + ime + "' })DETACH DELETE n", new Dictionary<string, object>(), CypherResultMode.Set);

            try
            {
                ((IRawGraphClient)client).ExecuteCypher(query);

            }
            catch (Exception e)
            {
                return false;
            }

            return true;
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
        public Zaposleni getZaposlen(string ime)
        {
            Dictionary<string, object> queryDict = new Dictionary<string, object>();
            var query = new CypherQuery("MATCH (Zaposleni{ ime:'" + ime + "'}) RETURN Zaposleni; ", queryDict, CypherResultMode.Set);

            Zaposleni p = ((IRawGraphClient)client).ExecuteGetCypherResults<Zaposleni>(query).SingleOrDefault();
            return p;
        }
        public bool AddZaposlen(String ime, String jmbg, String datumRodjenja, String mestoRodjenja, int radniStaz, String radnoMesto)
        {
            var query = new CypherQuery("CREATE (z:Zaposleni {ime:'" + ime + "', jmbg:'" + jmbg + "', datumRodjenja:'" + datumRodjenja + "', mestoRodjenja:'" + mestoRodjenja + "', radniStaz:" + radniStaz + ", radnoMesto:'" + radnoMesto + "'})", new Dictionary<string, object>(), CypherResultMode.Set);
            
            try
            {
                ((IRawGraphClient)client).ExecuteCypher(query);
            }
            catch (Exception e)
            {
                return false;
            }
            //MATCH (a:Zaposleni),(b:Pozoriste) WHERE a.ime='Marina Stosic' CREATE (a)-[:RADI_U]->(b)
            query = new CypherQuery("MATCH (a:Zaposleni),(b:Pozoriste) WHERE a.ime='" + ime + "' CREATE (a)-[:RADI_U]->(b)", new Dictionary<string, object>(), CypherResultMode.Set);
            try
            {
                ((IRawGraphClient)client).ExecuteCypher(query);
            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }
        //update zaposlenog
        public bool UpdateZaposlen(String ime, String jmbg, String datumRodjenja, String mestoRodjenja, int radniStaz, String radnoMesto)
        {
            //MATCH (n:Zaposleni { ime: '' })
           // SET n = { datumRodjenja: '' ,ime: '' , jmbg: '' , mestoRodjenja: '' , radniStaz:  , radnoMesto: ''}
        //RETURN n
            var query = new CypherQuery("MATCH (z:Zaposleni { ime:'" + ime + "'}) SET z = { datumRodjenja:'" + datumRodjenja +"', ime:'" + ime + "', jmbg:'" + jmbg + "', mestoRodjenja:'" + mestoRodjenja + "', radniStaz:" + radniStaz + ", radnoMesto:'" + radnoMesto + "'} return z", new Dictionary<string, object>(), CypherResultMode.Set);

            try
            {
                ((IRawGraphClient)client).ExecuteCypher(query);
            }
            catch (Exception e)
            {
                return false;
            }
            query = new CypherQuery("MATCH (a:Zaposleni),(b:Pozoriste) WHERE a.ime='" + ime + "' MERGE (a)-[:RADI_U]->(b)", new Dictionary<string, object>(), CypherResultMode.Set);
            try
            {
                ((IRawGraphClient)client).ExecuteCypher(query);
            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }

        public bool DeleteZaposlen(String ime)
        {
            var query = new CypherQuery("MATCH (n:Zaposleni {ime: '" + ime + "' })DETACH DELETE n", new Dictionary<string, object>(), CypherResultMode.Set);

            try
            {
                ((IRawGraphClient)client).ExecuteCypher(query);

            }
            catch (Exception e)
            {
                return false;
            }

            return true;
        }
        #endregion

        #region Repertoar
        public void DodajPredstavuURepertoar(Predstava p)
        {
            Repertoar r = new Repertoar();
            r.AddPredstava(p);
        }
        public void KreirajRepertoar(List<Predstava> predstave,string datum)
        {
            //da ne bi bilo ponavljanja MERGE
            var query = new CypherQuery("MERGE (z:Repertoar {datum:'" + datum + "'})", new Dictionary<string, object>(), CypherResultMode.Set);
            try
            {
                ((IRawGraphClient)client).ExecuteCypher(query);
            }
            catch (Exception e)
            {
                return;
            }
            foreach (var a in predstave)
            {
                //MATCH (a:Reziser),(b:Predstava) WHERE a.ime = 'Jagos Markovic' AND b.naslov = 'Tako je (ako vam se tako cini)' CREATE (a)-[:REZIRAO {Predstava:['Tako je (ako vam se tako cini']}]->(b)
                query = new CypherQuery("MATCH (z:Repertoar),(b:Predstava) WHERE z.datum = '"+datum+"' AND b.naslov = '"+a.naslov+"' MERGE (z)-[:NA_REPERTOARU {Predstava:['"+a.naslov+"']}]->(b)", new Dictionary<string, object>(), CypherResultMode.Set);
                try
                {
                    ((IRawGraphClient)client).ExecuteCypher(query);
                }
                catch (Exception e)
                {
                    return;
                }
            }
        }

        //public List<Predstava> vratiPrestaveNaOsnovuNaslova(List<string> naslovi)
        //{

        //}
        #endregion


        #region Sale
        public List<Sala> GetSale()
        {
            Dictionary<string, object> queryDict = new Dictionary<string, object>();
            var query = new CypherQuery("match (n:Sala) return n;", queryDict, CypherResultMode.Set);

            List<Sala> sale = ((IRawGraphClient)client).ExecuteGetCypherResults<Sala>(query).ToList();
            return sale;
        }

        public Sala GetSala(int brojSale)
        {
            var query = new CypherQuery("match (n:Sala) where n.brojSale=" + brojSale + " return n", new Dictionary<string, object>(), CypherResultMode.Set);
            Sala sala = ((IRawGraphClient)client).ExecuteGetCypherResults<Sala>(query).Single();
            return sala;
        }
        public List<Sala> GetSalaPoVremenu(string a, string b)
        {
            var query = new CypherQuery("match (n:Sala)-[:U_SALI]-(p:Prikaz) where p.datum='" + a + "' and p.vreme='" + b + "' return n", new Dictionary<string, object>(), CypherResultMode.Set);
            List<Sala> s = ((IRawGraphClient)client).ExecuteGetCypherResults<Sala>(query).ToList();
            return s;
        }

        public bool AddSala(int brojSale, int brojSedista, int SedistaPoRedu, int brojRedova)
        {
            //CREATE(Sala1: Sala {brojSale:1, brojSedista:100, brojRedova:10, brojSedistaPoRedu:10})
            var query = new CypherQuery("MERGE (s:Sala {brojSale:" + brojSale + ", brojSedista:" + brojSedista + ", brojRedova:" + brojRedova + ", brojSedistaPoRedu:" + SedistaPoRedu + "})", new Dictionary<string, object>(), CypherResultMode.Set);
            try
            {
                ((IRawGraphClient)client).ExecuteCypher(query);
            }
            catch (Exception e)
            {
                return false;
            }
            //MATCH (a:Sala),(b:Pozoriste) CREATE (a)-[:NALAZI_SE]->(b)
            query = new CypherQuery("MATCH (s:Sala),(b:Pozoriste) WHERE s.brojSale=" + brojSale + " MERGE (s)-[:NALAZI_SE]->(b)", new Dictionary<string, object>(), CypherResultMode.Set);
            try
            {
                ((IRawGraphClient)client).ExecuteCypher(query);
            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }

        public bool DeleteSala(int brojSale)
        {
            var query = new CypherQuery("MATCH (n:Sala {brojSale: " + brojSale + " }) DETACH DELETE n", new Dictionary<string, object>(), CypherResultMode.Set);
            try
            {
                ((IRawGraphClient)client).ExecuteCypher(query);
            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }

        #endregion

        #region Prikazi

        public List<Prikaz> GetPrikazi()
        {
            var query = new CypherQuery("MATCH (n:Prikaz) return n", new Dictionary<string, object>(), CypherResultMode.Set);
            List<Prikaz> prikaz = ((IRawGraphClient)client).ExecuteGetCypherResults<Prikaz>(query).ToList();
            return prikaz;
        }

        public List<Prikaz> GetPrikazZaPredstavu(String naslov)
        {
            var query = new CypherQuery("MATCH (n:Prikaz)-[:ODIGRAVA_SE]-(a:Predstava) where a.naslov='" + naslov + "' return n", new Dictionary<string, object>(), CypherResultMode.Set);
            List<Prikaz> prikaz = ((IRawGraphClient)client).ExecuteGetCypherResults<Prikaz>(query).ToList();
            return prikaz;
        }

        public Prikaz GetPrikazPoVremenu(string a, string b)
        {
            var query = new CypherQuery("match (p:Prikaz) where p.datum='" + a + "' and p.vreme='" + b + "' return p", new Dictionary<string, object>(), CypherResultMode.Set);
            Prikaz s = ((IRawGraphClient)client).ExecuteGetCypherResults<Prikaz>(query).SingleOrDefault();
            return s;
        }
        
        #endregion


        #region Rezervacija

        public List<Rezervacija> GetRezervacije()
        {
            Dictionary<string, object> queryDict = new Dictionary<string, object>();
            var query = new CypherQuery("match (n:Rezervacija) return n;", queryDict, CypherResultMode.Set);

            List<Rezervacija> rezervacija = ((IRawGraphClient)client).ExecuteGetCypherResults<Rezervacija>(query).ToList();
            return rezervacija;
        }
        public bool zauzmiSediste(Rezervacija r, String predstava, String sala)
        {
            var query2 = new CypherQuery("match ((q:Sala)-[:U_SALI]-(m:Prikaz)-[:ODIGRAVA_SE]-(b:Predstava))" +
                " where m.datum='" + r.prikaz.datum + "' and m.vreme='" + r.prikaz.vreme + "'" +
                " and b.naslov='" + predstava + "' and q.brojSale=" + Int32.Parse(sala)+
                " create (n:Rezervacija {brojSedista:'" + r.brojRezSedista + "'})", new Dictionary<string, object>(), CypherResultMode.Set);
           
            try
            {
                ((IRawGraphClient)client).ExecuteCypher(query2);
            }
            catch (Exception e)
            {
                return false;
            }
            // return true;
          /*  foreach (Sediste s in r.sedista)
            {
                var query = new CypherQuery("match (r:Rezervacija)-[:ZAKAZAO]-(b:Gost)" +
                    "where r.brojSedista='" + r.brojRezSedista  +
                    "create (n:Sediste {red:'" + s.red + "', brojSedista:'" + s.brojSedista + "'})", new Dictionary<string, object>(), CypherResultMode.Set);
              
                try
                {
                    ((IRawGraphClient)client).ExecuteCypher(query);
                }
                catch (Exception e)
                {
                    return false;
                }

            }*/
            return true;

        }
        #endregion

    }
}
