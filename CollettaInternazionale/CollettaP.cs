using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollettaInternazionale
{
    public class CollettaP
    {
        private int n;
        public Dictionary<Partecipante, Importo> Raccolta { get; private set; }
        public Dictionary<string, Partecipante> RaccoltaP { get; private set; }
        public float QuotaTotale { get; private set; }
        public CollettaP()
        {
            QuotaTotale = 0;
            Raccolta = new Dictionary<Partecipante, Importo>();
            RaccoltaP = new Dictionary<string, Partecipante>();
            n = 0;
        }
        public void Aggiungi(Partecipante p,Importo i)
        {
            string key;
            if (p != null)
            {
                n++;
                key = "P" + n.ToString();
                foreach(KeyValuePair<string, Partecipante> kvp in RaccoltaP)
                {
                    if (key == kvp.Key)
                    {
                        n++;
                        key = "P" + n.ToString();
                    }
                }
               // p.Id = key;
                RaccoltaP.Add(key, p);
                Raccolta.Add(p, i);
                QuotaTotale += i.Soldi;
            }
            else
                throw new Exception("il reference del partecipante è null");
        }
        public void Rimuovi(Partecipante p)
        {
            if (p != null)
            {
                QuotaTotale -= Raccolta[p].Soldi;
                Raccolta.Remove(p);
                //RaccoltaP.Remove(p.Id);
                n--;
            }
            else
                throw new Exception("il reference del partecipante è null");
        }
        public void Modifica(Partecipante p, Partecipante n,Importo i,Importo ni)
        {
            if (p != null)
            {
                QuotaTotale -= Raccolta[p].Soldi;
                n.Id = p.Id;
                Raccolta.Remove(p);
                Raccolta.Add(n,ni); 
               // RaccoltaP[n.Id] = n;
                QuotaTotale += Raccolta[n].Soldi;
            }
            else
                throw new Exception("il reference del partecipante è null");
        }
        public void sortByCash()
        {
            Importo temp=new Importo();
            float t = 0;
            KeyValuePair<Partecipante, Importo> y = new KeyValuePair<Partecipante, Importo>();

            for(int i = 0; i < Raccolta.Count; i++){
                foreach (KeyValuePair<Partecipante, Importo> kvp in Raccolta)
                {
                    if (t > Raccolta[kvp.Key].Soldi)
                    {

                        Importo t1 = Raccolta[kvp.Key];
                        Raccolta[kvp.Key] = temp;
                        Raccolta[y.Key] = t1;
                    }
                    t = Raccolta[kvp.Key].Soldi;
                    temp = Raccolta[kvp.Key];
                    y = kvp;
                }
            }
        }
        public void sortByName()
        {
            Importo temp = new Importo();

            foreach (KeyValuePair<Partecipante, Importo> kvp in Raccolta)
            {
                foreach (KeyValuePair<Partecipante, Importo> kvp2 in Raccolta)
                {
                    if (string.Compare(kvp.Key.Nome, kvp2.Key.Nome) > 0)
                    {
                        Importo t1 = Raccolta[kvp.Key];
                        Raccolta[kvp.Key] = temp;
                        Raccolta[kvp2.Key] = t1;
                    }
                    temp = Raccolta[kvp.Key];
                }
            }
        }
        public string getNome(float f)
        {
            foreach (KeyValuePair<Partecipante, Importo> kvp in Raccolta)
            {
                if (f==Raccolta[kvp.Key].Soldi)
                    return kvp.Key.Nome;
            }
            return "partecipante non trovato";
        }

    }//key:mensah value:;12;   cisco
    //key:cisco value:;14;     cornball    
    //key:cornball value:;11;  mensah
    //key:sheesh value:;9;     sheesh
}
