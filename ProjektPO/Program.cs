using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektPO
{
    public enum Kategoria { hiphop, pop, klasyka, rock, reggae, jazz, metal, discoPolo, filmowa, dlaDzieci, elektoniczna, techno, winylowa, składanka, opera, folk, country, inne }
    public enum KategoriaLiteratury { fantasy, kryminał, romans, science_fiction, reportaż, przygodowy, biografia, dokument, kuchenna, dramat, komedia, dla_dzieci, podróżnicza, edukacyjna, thriller, poezja, filozofia, horror, encyklopedia, historia, poradnik, bajka, inne }
    public enum KategoriaFilmu { fantasy, kryminał, romans, science_fiction, reportaż, przygodowy, biografia, dokument, dramat, komedia, animowany , podróżniczy, edukacyjny, thriller, obyczajowy, horror, familijny , encyklopedia, historia, poradnik, bajka, inne }
    public enum RodzajPlatnosci { za_pobraniem, przelew_bankowy, karta_platnicza}
    public enum SposobWysylki { kurier, poczta_polska, paczkomat, odbior_osobisty}
    public class Program
    {
        static void Main(string[] args)
        {
            PlytaCD plyta1 = new PlytaCD("Małomiasteczkowy", "Dawid Podsiadło","2017-08-15", 30 , Kategoria.pop, "Opolska");
           
            Ksiazka ksiazka1 = new Ksiazka("Baśnie 1000 i jednej nocy", "Allie Morgan", "2017-08-15", 40, KategoriaLiteratury.bajka);
            Film film1 = new Film("Skazani na Shawshank", "Frank Darabont", "16-04-1995", 55, KategoriaFilmu.dramat);
            Film film2 = new Film("Zielona mila", "Frank Darabont", "24-03-2000", 59, KategoriaFilmu.dramat);
            Film film3 = new Film("Ojciec chrzestny", "Francis Ford Coppola", "31-12-1972", 50, KategoriaFilmu.dramat);
            Film film4 = new Film("Dwunastu gniewnych ludzi", "Reginland Rose", "10-0401957", 45, KategoriaFilmu.dramat);
            Film film5 = new Film("Forrest Gump", "Robert Zemeckis", "04-11-1994", 50, KategoriaFilmu.komedia);
            Film film6 = new Film("Lot nad kukułczym gniazdem", "Milos Forman", "31-12-1975", 50, KategoriaFilmu.inne);
            Film film7 = new Film("Ojciec chrzestny II", "Francis Ford Coppola", "12-12-1974", 58, KategoriaFilmu.dramat);
            Film film8 = new Film("Lista Shindlera", "Steven Spielberg", "31-12-1993", 60, KategoriaFilmu.inne);
            Film film9 = new Film("Władca Pierścieni: powrót króla", "Peter Jackson", "01-01-2004", 50, KategoriaFilmu.fantasy);
            Film film10 = new Film("Pulp Fiction", "George Bloom", "12-10-2018", 50, KategoriaFilmu.fantasy);
            Film film11 = new Film("Życie jest piękne", "Jack Johanson", "22-10-2000", 67, KategoriaFilmu.historia);
            Film film12 = new Film("Siedem", "Adam Smith", "12-10-2013", 75, KategoriaFilmu.fantasy);
            Film film13 = new Film("Władca Pierścieni: Dwie wieże", "Johann Smarowsky", "12-10-2018", 50, KategoriaFilmu.romans);
            Film film14 = new Film("Podziemny krąg", "John Bubble", "13-10-2009", 66, KategoriaFilmu.podróżniczy);
            Film film15 = new Film("Chłopcy z ferajny", "Michael Smart", "12-10-2003", 65, KategoriaFilmu.dramat);
            Film film16 = new Film("Piekny umysł", "Steven Soldier", "12-10-2004",78 , KategoriaFilmu.dramat);
            Film film17 = new Film("Pianista", "John Pitch", "12-10-2006", 50, KategoriaFilmu.familijny);
            Film film18 = new Film("Incepcja", "Kate Wilson", "12-10-2006", 10, KategoriaFilmu.thriller);
            Film film19 = new Film("Django", "Adam Johanson", "12-10-2009", 90, KategoriaFilmu.science_fiction);
            Film film20 = new Film("Milczenie owiec", "Samanta Hund", "12-05-2018", 88, KategoriaFilmu.obyczajowy);
            Magazyn m1 = new Magazyn("Magazyn sklepu internetowego SOWA");
            m1.DodajProdukt(plyta1);
            m1.DodajProdukt(ksiazka1);
            m1.DodajProdukt(film1);
            m1.DodajProdukt(film2);
            m1.DodajProdukt(film3);
            m1.DodajProdukt(film4);
            m1.DodajProdukt(film5);
            m1.DodajProdukt(film6);

            m1.DodajProdukt(film7);
            m1.DodajProdukt(film8);
            m1.DodajProdukt(film9);
            m1.DodajProdukt(film10);
            m1.DodajProdukt(film11);
            m1.DodajProdukt(film12);
            m1.DodajProdukt(film13);
            m1.DodajProdukt(film14);
            m1.DodajProdukt(film15);
            m1.DodajProdukt(film16);
            m1.DodajProdukt(film17);
            m1.DodajProdukt(film18);
            m1.DodajProdukt(film19);
            m1.DodajProdukt(film20);
            m1.DodajProdukt(film1);

            PlytaCD plyta2 = new PlytaCD("The Greatest Hits", "Queen", "2017-09-10", 50, Kategoria.pop, "Platinum");
            PlytaCD plyta3 = new PlytaCD("Feels Like Home", "Jones Norah", "2016-10-09", 20, Kategoria.jazz, "One");
            PlytaCD plyta4 = new PlytaCD("Load", "Metallica", "1990-02-03", 30, Kategoria.rock, "Toxic");
            PlytaCD plyta5 = new PlytaCD("To tu", "Kękę", "2018-01-02", 36, Kategoria.hiphop, "Prosto");
            PlytaCD plyta6 = new PlytaCD("A Star Is Born", "Lady Gaga", "2017-12-12", 41, Kategoria.filmowa, "Bradley");
            PlytaCD plyta7 = new PlytaCD("Mini dom", "Kortez", "2017-08-09", 29.90, Kategoria.pop, "Światło");
            PlytaCD plyta8 = new PlytaCD("Oddycham", "Kamil Bednarek", "2016-08-03", 30, Kategoria.reggae, "Talizman");
            PlytaCD plyta9 = new PlytaCD("Divide", "Ed Sheeran", "2017-12-02", 42, Kategoria.pop, "Sun");
            PlytaCD plyta10 = new PlytaCD("Jestem", "Lady Pank", "2017-12-01", 30, Kategoria.pop, "Polska");
            PlytaCD plyta11 = new PlytaCD("W drodze po szczęście", "OSTR", "2018-01-02", 50, Kategoria.hiphop, "Hej");
            PlytaCD plyta12 = new PlytaCD("Randka w ciemności", "Nocny Kochanek", "2017-02-03", 39, Kategoria.rock, "Empik");
            PlytaCD plyta13 = new PlytaCD("Mamma Mia!", "Various Artists", "2015-05-12", 20, Kategoria.składanka, "Best");
            PlytaCD plyta14 = new PlytaCD("Podróż", "Oddział Zamknięty", "2013-10-10", 29, Kategoria.rock, "Swag");
            PlytaCD plyta15 = new PlytaCD("W pięciu smakach", "Brodka", "2015-01-01", 20, Kategoria.inne, "Raj");
            PlytaCD plyta16 = new PlytaCD("Peron", "Jamal", "2017-10-19", 16, Kategoria.reggae, "Warszawska");
            PlytaCD plyta17 = new PlytaCD("Chwile ulotne", "Lanek", "2016-09-02", 29, Kategoria.hiphop, "Siedem");
            PlytaCD plyta18 = new PlytaCD("Lunatycy", "Dżem", "1970-10-10", 40, Kategoria.rock, "Klasyki");
            PlytaCD plyta19 = new PlytaCD("No more", "Din", "2017-09-02", 30, Kategoria.metal, "Fun");
            PlytaCD plyta20 = new PlytaCD("La donna", "Richard Bon", "2016-01-01", 20, Kategoria.opera, "Sun");
            PlytaCD plyta21 = new PlytaCD("Skrzydlate ręce", "Enej", "2016-03-04", 26, Kategoria.pop, "Hejwy");
            m1.DodajProdukt(plyta2);
            m1.DodajProdukt(plyta3);
            m1.DodajProdukt(plyta4);
            m1.DodajProdukt(plyta5);
            m1.DodajProdukt(plyta6);
            m1.DodajProdukt(plyta7);
            m1.DodajProdukt(plyta8);
            m1.DodajProdukt(plyta9);
            m1.DodajProdukt(plyta10);
            m1.DodajProdukt(plyta11);
            m1.DodajProdukt(plyta12);
            m1.DodajProdukt(plyta13);
            m1.DodajProdukt(plyta14);
            m1.DodajProdukt(plyta15);
            m1.DodajProdukt(plyta16);
            m1.DodajProdukt(plyta17);
            m1.DodajProdukt(plyta18);
            m1.DodajProdukt(plyta19);
            m1.DodajProdukt(plyta20);
            m1.DodajProdukt(plyta21);

            Ksiazka ksiazka2 = new Ksiazka("Nieodgadniona", "Remigiusz Mróz", "2017-08-19", 45, KategoriaLiteratury.dramat);
            Ksiazka ksiazka3 = new Ksiazka("Tatuażysta z Auschwitz", "Morris Heather", "2016-08-15", 80, KategoriaLiteratury.dokument);
            Ksiazka ksiazka4 = new Ksiazka("Pozwól mi wrócić", "Paris B.A.", "2017-08-15", 25, KategoriaLiteratury.kryminał);
            Ksiazka ksiazka5 = new Ksiazka("Kasacja. Joanna Chyłka. Tom 1", "Mróz Remigiusz", "2017-11-05", 37, KategoriaLiteratury.historia);
            Ksiazka ksiazka6 = new Ksiazka("Czapkins. Historia Tomka Mackiewicza", "Szczepański Dominik", "2016-09-03", 48, KategoriaLiteratury.horror);
            Ksiazka ksiazka7 = new Ksiazka("Becoming. Moja historia", "Obama Michelle", "2018-01-10", 40, KategoriaLiteratury.biografia);
            Ksiazka ksiazka8 = new Ksiazka("Bajeczki do poduszki dla najmłodszych", "Krzysztof Miś", "2015-09-30", 19, KategoriaLiteratury.dla_dzieci);
            Ksiazka ksiazka9 = new Ksiazka("Zaginięcie. Joanna Chyłka. Tom 2", "Mróz Remigiusz", "2016-08-01", 55, KategoriaLiteratury.dramat);
            Ksiazka ksiazka10 = new Ksiazka("Krótkie odpowiedzi na wielkie pytania", "Hawking Stephen", "2013-03-11", 60, KategoriaLiteratury.filozofia);
            Ksiazka ksiazka11 = new Ksiazka("Cokolwiek wybierzesz. Ukryta sieć. Tom 1", "Szamałek Jakub", "2011-05-17", 47, KategoriaLiteratury.romans);
            Ksiazka ksiazka12 = new Ksiazka("Niewyjaśnione okoliczności", "Shepherd Richard", "2009-02-24", 24, KategoriaLiteratury.biografia);
            Ksiazka ksiazka13 = new Ksiazka("Sponsor. Tom 2", "Haner K.N.", "2017-12-15", 18, KategoriaLiteratury.romans);
            Ksiazka ksiazka14 = new Ksiazka("Magia zmiany. Przekrocz własne granice i osiągnij cel", "Czarodziej Jakub", "2010-12-11", 40, KategoriaLiteratury.thriller);
            Ksiazka ksiazka15 = new Ksiazka("Rodzanice. Lipowo. Tom 10", "Puzyńska Katarzyna", "2011-02-27", 49, KategoriaLiteratury.historia);
            Ksiazka ksiazka16 = new Ksiazka("Srebrna zatoka", "Moyes Jojo", "2006-04-29", 59, KategoriaLiteratury.przygodowy);
            Ksiazka ksiazka17 = new Ksiazka("Zaczarowana zagroda", "Centkiewicz Alina, Centkiewicz Czesław", "2010-03-04", 57, KategoriaLiteratury.dla_dzieci);
            Ksiazka ksiazka18 = new Ksiazka("Będzie bolało", "Kay Adam", "2009-18-05", 69, KategoriaLiteratury.reportaż);
            Ksiazka ksiazka19 = new Ksiazka("Pisarka", "Michalak Katarzyna", "2007-07-07", 42, KategoriaLiteratury.dokument);
            Ksiazka ksiazka20 = new Ksiazka("Weź się ogarnij", "Pani Bukowa", "2017-01-19", 49, KategoriaLiteratury.poradnik);
            Ksiazka ksiazka21 = new Ksiazka("Lunchbox na każdy dzień. Przepisy inspirowane japońskim bento", "Bareła Malwina", "2019-05-14", 17, KategoriaLiteratury.kuchenna);




            m1.DodajProdukt(ksiazka2);
            m1.DodajProdukt(ksiazka3);
            m1.DodajProdukt(ksiazka4);
            m1.DodajProdukt(ksiazka5);
            m1.DodajProdukt(ksiazka6);
            m1.DodajProdukt(ksiazka7);
            m1.DodajProdukt(ksiazka8);
            m1.DodajProdukt(ksiazka9);
            m1.DodajProdukt(ksiazka10);
            m1.DodajProdukt(ksiazka11);
            m1.DodajProdukt(ksiazka12);
            m1.DodajProdukt(ksiazka13);
            m1.DodajProdukt(ksiazka14);
            m1.DodajProdukt(ksiazka15);
            m1.DodajProdukt(ksiazka16);
            m1.DodajProdukt(ksiazka17);
            m1.DodajProdukt(ksiazka18);
            m1.DodajProdukt(ksiazka19);
            m1.DodajProdukt(ksiazka20);
            m1.DodajProdukt(ksiazka21);
            m1.Sortuj();

            Console.WriteLine(m1.ObliczWartosc());
            Console.WriteLine("===========================================================");
            m1.ZapiszXML("magazynXML.xml", m1);
            Magazyn m2=Magazyn.OdczytajXML("magazynXML.xml");
            Console.WriteLine(m2);
            

            //equals dziala
            //Console.WriteLine("Metoda equals !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!\n\n\n\n\n\n\n\n\n\n\n\n");
            //Console.WriteLine(ksiazka1.Equals(film1));
            //METODA SORTUJ DZIALA :D 
            //Console.WriteLine("!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!\n\n\n\n\n\n");
            //Console.WriteLine(m1);
            //m1.Sortuj();
            //Console.WriteLine(m1);

            Console.WriteLine("*************MAGAZYN*******");
            Console.WriteLine(m1);
            Klient klient1 = new Klient("Jan", "Nowak", "Kraków", "Gramatyka 10/13", "36-052", "555666777", "jankow@o2.pl");
            Console.WriteLine(klient1);
            Zamowienie zam1 = new Zamowienie(klient1, RodzajPlatnosci.karta_platnicza, SposobWysylki.kurier,"extra10");
            zam1.DodajdoZamowienia(plyta1, m1);
            zam1.DodajdoZamowienia(ksiazka1, m1);
            Console.WriteLine(zam1);

            zam1.ZapiszXML("zamowienie.xml", zam1);
            Console.WriteLine("/*********** zapisano zamówienie do XML *********************\n");
            Zamowienie zam2 = (Zamowienie)Zamowienie.OdczytajXML("zamowienie.xml");
            Console.WriteLine(zam2);

            //ZamowieniaDoZrealizowania kolejkaZamowien = new ZamowieniaDoZrealizowania();
            //kolejkaZamowien.DodajDoKolejki(zam1);
            //kolejkaZamowien.ZapiszXML("zamowieniaXML.xml", kolejkaZamowien);
            //Console.WriteLine("/*********** zapisano kolejkę zamówień do XML *********************\n");
            //ZamowieniaDoZrealizowania zamdk2 = kolejkaZamowien.OdczytajXML("zamowieniaXML.xml");
            //Console.WriteLine(zamdk2);


            
       
            Console.ReadKey();
        }
    }
}
