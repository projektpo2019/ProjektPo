using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektPO
{
    public class Film : Produkt
    {
        private KategoriaFilmu rodzajFilmu;

        public KategoriaFilmu RodzajFilmu { get => rodzajFilmu; set => rodzajFilmu = value; }

        public Film():base()
        {

        }
        public Film(string n,string a, string data,double c,KategoriaFilmu f):base(n,a,data,c)
        {
            rodzajFilmu = f;
            NrSeryjny = NrSeryjny + "/F";

        }

        public override string ToString()
        {
            return base.ToString() + "Rodzaj filmu: " + rodzajFilmu;
        }


    }
}
