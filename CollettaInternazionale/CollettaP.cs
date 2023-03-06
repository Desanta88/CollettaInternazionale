using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollettaInternazionale
{
    public class CollettaP
    {
        private string key;
        private int n;
        public Dictionary<string, Partecipante> Raccolta { get; private set; }
        public float QuotaTotale { get; private set; }
        public CollettaP()
        {
            QuotaTotale = 0;
            Raccolta = new Dictionary<string, Partecipante>();
            n = 1;
        }
        public void Aggiungi(Partecipante p)
        {
            if (p != null)
            {
                key = "P" + n.ToString();
                Raccolta.Add(key, p);
                p.Id = key;
                QuotaTotale += p.Quota;
                n++;
            }
            else
                throw new Exception("il reference del partecipante è null");
        }
        public void Rimuovi(Partecipante p)
        {
            if (p != null)
            {
                Raccolta.Remove(p.Id);
                QuotaTotale -= p.Quota;
                n--;
            }
            else
                throw new Exception("il reference del partecipante è null");
        }
        public void Modifica(Partecipante p, Partecipante n)
        {
            if (p != null)
            {
                QuotaTotale -= Raccolta[p.Id].Quota;
                n.Id = p.Id;
                Raccolta[p.Id] = n;
                QuotaTotale += n.Quota;
            }
            else
                throw new Exception("il reference del partecipante è null");
        }
    }
}
