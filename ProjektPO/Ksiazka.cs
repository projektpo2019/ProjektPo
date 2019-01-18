using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektPO
{
    public class Ksiazka : Produkt
    {
        private KategoriaLiteratury typKsiazki;

        public KategoriaLiteratury TypKsiazki { get => typKsiazki; set => typKsiazki = value; }

        public Ksiazka():base()
        {   
        }
        public Ksiazka(string n, string a, string data, double c, KategoriaLiteratury typ) :base(n,a,data,c)
        {
            typKsiazki = typ;
            NrSeryjny = NrSeryjny + "/K";
        }
        public override string ToString()
        {
            return base.ToString()+"Typ literatury: "+typKsiazki;
        }
    }
}
