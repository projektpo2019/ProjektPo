using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektPO
{
    [Serializable]
    
    public class Klient:IComparable<Klient>,ICloneable
    {
        
        string imie;
        string nazwisko;
        string miejscowosc;
        string ulica;
        string kodPocztowy;
        string nrTelefonu;
        string email;
        static int identyfikator;

        public string Imie { get => imie; set => imie = value; }
        public string Nazwisko { get => nazwisko; set => nazwisko = value; }
        public string Miejscowosc { get => miejscowosc; set => miejscowosc = value; }
        public string Ulica { get => ulica; set => ulica = value; }
        public string KodPocztowy { get => kodPocztowy; set => kodPocztowy = value; }
        public string NrTelefonu { get => nrTelefonu; set { if (value.Length != 9) throw new FormatException("Numer telefonu musi mieć 9 cyfr."); nrTelefonu = value; } }
        public string Email { get => email; set => email = value; }
        public static int Identyfikator { get => identyfikator; set => identyfikator = value; }

        static Klient()
        {
            identyfikator = 100;
        }

        public Klient()
        {
            imie = "";
            nazwisko = "";
            miejscowosc = "";
            ulica = "";
            kodPocztowy = "00000";
            nrTelefonu = "000000000";
            email = "";
            identyfikator++;
        }
        public Klient(string i, string n, string miejsc, string ul, string kod, string nrTel, string e_mail)
        {
            imie = i;
            nazwisko = n;
            miejscowosc = miejsc;
            ulica = ul;
            KodPocztowy = kod;
            NrTelefonu = nrTel;
            email = e_mail;
           
        }

        public override string ToString()
        {
            return "Imię:"+" "+imie+" Nazwisko "+nazwisko+" E-mail "+email+"  Adres: "+ulica+" "+kodPocztowy+" "+miejscowosc ;
        }

        public int CompareTo(Klient obj)
        {
            if (obj != null)
            {
                Klient k = (Klient)obj;
                int cmp = this.Nazwisko.CompareTo(k.Nazwisko);
                if (cmp != 0) return cmp;
                else return this.imie.CompareTo(k.imie);
            }
            else return 1;
        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
