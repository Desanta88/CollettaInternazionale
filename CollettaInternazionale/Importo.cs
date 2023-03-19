using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollettaInternazionale
{
    public class Importo
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
    }
}
