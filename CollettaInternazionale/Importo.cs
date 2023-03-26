using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollettaInternazionale
{
    public class Importo:IComparable<Importo>,IEquatable<Importo>
    {
        public float Soldi { set; get; }
        public string Valuta { set; get; }

        public Importo(float s,string v)
        {
            Soldi = s;
            Valuta = v;
        }
        public Importo()
        {
            Soldi = 0;
            Valuta = "";
        }
        public override string ToString()
        {
            return ";" + Soldi.ToString() + ";" + Valuta;
        }
        public override int GetHashCode() => (Valuta, Soldi).GetHashCode();

        public override bool Equals(Object o)
        {
            if (!(o is Partecipante))
                return false;

            return Equals((Partecipante)o);
        }
        public bool Equals(Importo i)
        {
            if (i == null)
                return false;
            if (this == i)
                return true;
            return i.Equals(i.Soldi);
        }
        public int CompareTo(Importo i)
        {
            return this.Soldi.CompareTo(i.Soldi);
        }
    }
}
