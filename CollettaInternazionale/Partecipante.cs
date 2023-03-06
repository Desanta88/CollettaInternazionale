using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollettaInternazionale
{
    public class Partecipante
    {
        public string Nome { get; set; }
        public float Quota { get; set; }
        public string Id { get; set; }
        public Partecipante(string nome, float quota)
        {
            Nome = nome;
            Quota = quota;
        }
        public Partecipante() : this("N/A", 0)
        {

        }
        public override string ToString()
        {
            return Id + ";" + Nome + ";" + Quota.ToString();
        }
    }
}
