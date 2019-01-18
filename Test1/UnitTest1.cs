using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProjektPO;

namespace Test1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestKonstruktoraMAgazyn()
        {

            PlytaCD plyta1 = new PlytaCD("Małomiasteczkowy", "Dawid Podsiadło", "2017-08-15", 30, Kategoria.pop, "Opolska");

            Ksiazka ksiazka1 = new Ksiazka("Baśnie 1000 i jednej nocy", "Allie Morgan", "2017-08-15", 40, KategoriaLiteratury.bajka);
            Film film1 = new Film("Nietykalni", "Adam Nowak", "12-10-2018", 50, KategoriaFilmu.dramat);
            Magazyn magazyn1 = new Magazyn("Magazyn testowy");
            magazyn1.DodajProdukt(ksiazka1);
            
            magazyn1.DodajProdukt(film1);

            Assert.AreEqual(magazyn1.NazwaM, "Magazyn testowy");

        }
        [TestMethod] ////zeby metoda byla testowa musi miec atrybut test method
        public void TestKonstruktora1()
        {

            PlytaCD plyta1 = new PlytaCD("Małomiasteczkowy", "Dawid Podsiadło", "2017-08-15", 30, Kategoria.pop, "Opolska");

            Ksiazka ksiazka1 = new Ksiazka("Baśnie 1000 i jednej nocy", "Allie Morgan", "2017-08-15", 40, KategoriaLiteratury.bajka);
            Film film1 = new Film("Nietykalni", "Adam Nowak", "12-10-2018", 50, KategoriaFilmu.dramat);
            Magazyn magazyn1 = new Magazyn("Magazyn testowy");
            magazyn1.DodajProdukt(ksiazka1);

            magazyn1.DodajProdukt(film1);

            Zamowienie z = new Zamowienie();
            z.DodajdoZamowienia(ksiazka1,magazyn1);
            z.DodajdoZamowienia(film1, magazyn1);
            z.DodajdoZamowienia(plyta1, magazyn1);
            double a = magazyn1.ObliczWartosc();
            double b = 90;
            Assert.AreEqual(ksiazka1.Nazwa,"Baśnie 1000 i jednej nocy");
            Assert.AreEqual(ksiazka1.Cena, 40);
            Assert.AreEqual(film1.Cena, 50);
            Assert.AreEqual(film1.Cena + ksiazka1.Cena, 90);
            
        }
        //jezeli  memay exceptiom to tworzymy pod test method [ExpectedException(typeof    )]

    }
}
