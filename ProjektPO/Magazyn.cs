using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ProjektPO
{
    [Serializable]
    [XmlInclude(typeof(Produkt))]
    [XmlInclude(typeof(PlytaCD))]
    [XmlInclude(typeof(Film))]
    [XmlInclude(typeof(Ksiazka))]
    public class Magazyn:ICloneable
    {
        string nazwaM;
        private List<Produkt> listaProduktow;
        int iloscProduktow;
        /// <summary>
        /// //
        /// </summary>
        public string NazwaM { get => nazwaM; set => nazwaM = value; }
        public List<Produkt> ListaProduktow { get => listaProduktow; set => listaProduktow = value; }
        public int IloscProduktow { get => iloscProduktow; set => iloscProduktow = value; }

        public Magazyn()
        {
            nazwaM = "";
            listaProduktow = new List<Produkt>();
            iloscProduktow = 0;

        }

        public Magazyn(string n):this()
        {
            nazwaM = n;
        }

        public void DodajProdukt(Produkt P)
        {
            listaProduktow.Add(P);
            iloscProduktow++;
        }
        public void UsunProdukt(Produkt P)
        {
            if (listaProduktow.Contains(P))
            {
                listaProduktow.Remove(P);
                iloscProduktow--;
            }
            
        }

        public  bool SprawdzDostepnosc(string nazwa)
        {
            
            foreach(Produkt P in listaProduktow)
            {
                if (P.Nazwa == nazwa) return true;


            }
            return false;

        }
        public bool SprawdzDostepnosc(Produkt p)
        {
            foreach (Produkt P in listaProduktow)
            {
                if (listaProduktow.Contains(p)) return true;
            }
            return false;
        }
        public double ObliczWartosc()
        {
            double suma = 0;
            foreach(Produkt P in listaProduktow)
            {
                suma = suma + P.Cena;
            }
            return suma;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Nazwa: " + nazwaM+"\n");
            sb.AppendLine("Zawartość magazynu: ");
            foreach (Produkt P in listaProduktow)
            {
                sb.AppendLine(P.ToString()+"\n");

            }
            sb.AppendLine("Liczba produktów w magazynie: " + iloscProduktow);
            sb.AppendLine("Wartość magazynu: " + ObliczWartosc() + "zł");
            return sb.ToString();
        }
        public void Sortuj()
        {
            listaProduktow.Sort();
        }

        public object Clone()
        {
            Magazyn kopia = new Magazyn();
            kopia.nazwaM = this.nazwaM;
            foreach(Produkt p in listaProduktow)
            {
                Produkt ps = (Produkt)p.Clone();
                kopia.DodajProdukt(ps);
            }
            kopia.iloscProduktow = this.iloscProduktow;
            return kopia;
        }
        public void ZapiszXML(string n,Magazyn m)
        {
            XmlSerializer sr = new XmlSerializer(typeof(Magazyn));
            StreamWriter sw = new StreamWriter(n);
            sr.Serialize(sw, m);
            sw.Close();
        }
        public static Magazyn OdczytajXML(string n)
        {
            {
                Magazyn odczytanyMagazyn;
                try
                {
                    XmlSerializer sr = new XmlSerializer(typeof(Magazyn));
                    TextReader tr = new StreamReader(n);
                    odczytanyMagazyn = (Magazyn)sr.Deserialize(tr);
                    return odczytanyMagazyn;
                }
                catch(FileNotFoundException)
                {
                    Console.WriteLine("Plik nie został odczytany");
                }
                return null;
            }
        }
    }
}
