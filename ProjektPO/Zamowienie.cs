using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Xml.Serialization;
using System.IO;

namespace ProjektPO
{
    [Serializable]
    [XmlInclude(typeof(Klient))]
    [XmlInclude(typeof(PlytaCD))]
    [XmlInclude(typeof(Ksiazka))]
    [XmlInclude(typeof(Film))]
    public class Zamowienie
    {
        RodzajPlatnosci platnosc;
        SposobWysylki wysylka;
        Klient klient;
        List<Produkt> zamowioneProdukty;
        static int numerZamowienia;
        
        
        
        static string kodRabatowy;

        public RodzajPlatnosci Platnosc { get => platnosc; set => platnosc = value; }
        public SposobWysylki Wysylka { get => wysylka; set => wysylka = value; }
        public List<Produkt> ZamowioneProdukty { get => zamowioneProdukty; set => zamowioneProdukty = value; }
        public Klient Klient { get => klient; set => klient = value; }
        public static int NumerZamowienia { get => numerZamowienia; set => numerZamowienia = value; }
        
        
        public static string KodRabatowy { get => kodRabatowy; set => kodRabatowy = value; }

        static Zamowienie()
        {
            numerZamowienia = 0;
            kodRabatowy = "extra10";
            
        }
        
        public Zamowienie()
        {
            
            klient = null;
            numerZamowienia++;
            zamowioneProdukty = new List<Produkt>();
            
        }
        public Zamowienie(Klient k, RodzajPlatnosci p, SposobWysylki w,string kod):this()
        {
            KodRabatowy = kod;
            klient = k;
            platnosc = p;
            wysylka = w;

         
        }

        public void DodajdoZamowienia(Produkt P,Magazyn m)
        {
            if (m.SprawdzDostepnosc(P))
            {
                zamowioneProdukty.Add(P);
               
                m.UsunProdukt(P);
            }
            else
            Console.WriteLine("Zamowienie nie może zostac zrealizowane :( ");
            //tu trzeba dac else z informacja zwrotna
            
                
         
            
        }
        public bool SprawdzKodRabatowy()
        {
            if (kodRabatowy == "extra10") return true;
            else return false;
                
        }

        public double ObliczWartosc()
        {
            double suma=0;
            foreach(Produkt p in zamowioneProdukty)
            {
                suma = suma + p.Cena;
                
            }
            if(wysylka == SposobWysylki.kurier)
            {
                suma = suma + 20;
                
            }
            if (wysylka == SposobWysylki.odbior_osobisty)
            {
                suma = suma + 0;
            }
            if (wysylka == SposobWysylki.paczkomat)
            {
                suma = suma + 15;
            }
            if (wysylka == SposobWysylki.poczta_polska)
            {
                suma = suma + 10;
            }
            if (SprawdzKodRabatowy())
                return suma * 0.9;
            else
                return suma;

        }
        
        
        
        
        
        

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Numer zamówienia:" + numerZamowienia);
            sb.Append(klient.ToString());
            foreach (Produkt P in zamowioneProdukty)
            {
                sb.AppendLine(P.ToString());
            }
            sb.AppendLine("Rodzaj płatności:" + platnosc);
            sb.AppendLine("Sposób dostawy:" + wysylka);
            sb.AppendLine("*********Podsumowanie zamówienia: ***********");
            sb.AppendLine("Łączna wartość zamówienia: " + ObliczWartosc() + " zł");
            if (SprawdzKodRabatowy()) sb.AppendLine("Skorzystałeś z kodu rabatowego - 10%");
            else sb.AppendLine("Sprawdź czy wpisałeś poprawny kod rabatowy");
            return sb.ToString();
        }
        public void ZapiszXML(string n, Zamowienie z)
        {
            XmlSerializer sr = new XmlSerializer(typeof(Zamowienie));
            StreamWriter sw = new StreamWriter(n);
            sr.Serialize(sw, z);
            sw.Close();

        }

        public static Zamowienie OdczytajXML(string n)
        {
            Zamowienie listaOdczytana;
            try
            {
                XmlSerializer sr = new XmlSerializer(typeof(Zamowienie));
                TextReader tr = new StreamReader(n);
                listaOdczytana = (Zamowienie)sr.Deserialize(tr);
                return listaOdczytana;
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("Plik nie został odczytany.");
            }
            return null;
        }



    }
}
