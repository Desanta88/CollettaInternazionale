using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollettaInternazionale
{
    public class Partecipante:IComparable<Partecipante>,IEquatable<Partecipante>
    {
        public string Nome { get; set; }
        public int Id { get; set; }
        public Partecipante(string nome)
        {
            Nome = nome;
            Id = GetHashCode();
        }
        public Partecipante() : this("N/A")
        {

        }
        public override string ToString()
        {
            return Id + ";" + Nome;
        }
        public override int GetHashCode()=>(Nome).GetHashCode();
        public override bool Equals(Object o)
        {
            if (!(o is Partecipante))
                return false;

            return Equals((Partecipante)o);
        }
        public bool Equals(Partecipante p)
        {
            if (p == null)
                return false;
            if (this == p)
                return true;
            return Nome.Equals(p.Nome);
        }
        public int CompareTo(Partecipante p)
        {
            return Nome.CompareTo(p.Nome);
        }
    }
}
