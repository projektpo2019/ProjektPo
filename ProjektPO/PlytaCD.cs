using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektPO
{
    public class PlytaCD : Produkt
    {
        private Kategoria kategoriaMuzyki;
        string wytwornia;

        public Kategoria KategoriaMuzyki { get => kategoriaMuzyki; set => kategoriaMuzyki = value; }
        public string Wytwornia { get => wytwornia; set => wytwornia = value; }

        public PlytaCD():base()
        {
            wytwornia = "";
        
        }
        public PlytaCD(string n, string a, string data, double c, Kategoria K, string w):base(n,a,data,c)
        {
            kategoriaMuzyki = K;
            wytwornia = w;
            NrSeryjny = NrSeryjny + "/CD";
        }
        public override string ToString()
        {
            return base.ToString()+"  Wytwórnia:"+wytwornia+"  Kategoria muzyki: " +kategoriaMuzyki;
        }
    }
}
