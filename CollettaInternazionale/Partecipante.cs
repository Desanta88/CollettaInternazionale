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
        public string Id { get; set; }
        public Partecipante(string nome)
        {
            Nome = nome;
        }
        public Partecipante() : this("N/A")
        {

        }
        public override string ToString()
        {
            return Id + ";" + Nome;
        }
        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }
        public override bool Equals(Object o)
        {
            if (!(o is Partecipante))
                return false;

            return Equals((Partecipante)o);
        }
    }
}
