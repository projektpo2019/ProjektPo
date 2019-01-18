using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektPO
{
    public abstract class Produkt:IComparable<Produkt>,IEquatable<Produkt>,ICloneable
    {

        string nazwa;
        DateTime dataWydania;
        string autor;
        double cena;
        static int indeks;
        string nrSeryjny;
      

        public string Nazwa { get => nazwa; set => nazwa = value; }
        public DateTime DataWydania { get => dataWydania; set => dataWydania = value; }
        public string Autor { get => autor; set => autor = value; }
        public double Cena { get => cena; set { if (value < 5) {throw new CenaMinimalnaException(); } else cena = value; } }
        public static int Indeks { get => indeks; set => indeks = value; }
        public string NrSeryjny { get => nrSeryjny; set => nrSeryjny = value; }
       

        static Produkt()
        {
            indeks = 1000;
        }
        public Produkt()
        {
            nazwa = "";
            autor = "";
            dataWydania = DateTime.MinValue;
            cena = 0;
            indeks++;



        }
        public Produkt(string n, string a, string data, double c) : this()
        {
            DateTime d;
            DateTime.TryParseExact(data, new[] { "dd-MM-yyyy", "dd-MM-yy", "yy-MM-dd", "yyyy-MM-dd", "yyyy/MM/dd", "MM/dd/yy", "dd-MMM-yy" }, null, System.Globalization.DateTimeStyles.None, out d);            nazwa = n;            autor = a;            Cena = c;            DataWydania = d;            nrSeryjny = indeks + "/" + dataWydania.Year;


        }
        public override string ToString()
        {
            return "Numer seryjny: " + nrSeryjny + "    Nazwa: " + nazwa + "    Autor: " + autor + "    Data Wydania: " + dataWydania.ToShortDateString() + String.Format(" Cena: {0:0.00} zł", cena) ;
        }

        public int CompareTo(Produkt obj)
        {
            if (obj != null)
            {
                Produkt p = (Produkt)obj;
                int cmp = this.Nazwa.CompareTo(p.Nazwa);
                if (cmp != 0) return cmp;
                else return this.DataWydania.CompareTo(p.DataWydania);

            }
            else return 1;
        }

        public bool Equals(Produkt other)
        {
            if (other == null) return false;
            if (other.NrSeryjny == NrSeryjny)
            {
                return true;
            }
            else return false;
        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
