using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using ProjektPO;


namespace GUIProjektPo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Magazyn magazyn = new Magazyn();
        Zamowienie zam = new Zamowienie();
        ZamowieniaDoZrealizowania zamowieniaDoRealizacji = new ZamowieniaDoZrealizowania();
        ObservableCollection<Produkt> lista;
        ObservableCollection<Produkt> listaZamowionych;

        public MainWindow()
        {
            InitializeComponent();

            magazyn = (Magazyn)Magazyn.OdczytajXML("magazynXML.xml");
            lista = new ObservableCollection<Produkt>(magazyn.ListaProduktow);
            listaZamowionych = new ObservableCollection<Produkt>(zam.ZamowioneProdukty);
            listtBox_produkty.ItemsSource = lista;
            magazyn.IloscProduktow = lista.Count;
            magazyn.NazwaM = "nasz MAgazyn";
            
        }

        private void Button_dodaj_Click(object sender, RoutedEventArgs e)
        //{
        
        //    if(p!=null)
        {
            Produkt p = (Produkt)listtBox_produkty.SelectedItem;
            if (listtBox_produkty.SelectedItem != null)
            {

              zam.DodajdoZamowienia(p,magazyn);
                listaZamowionych.Add(p);
                lista.Remove(p);
                ListBox_wybraneProdukty.ItemsSource = listaZamowionych;

            //    if ( == null)
            //    {
            //        listaZamowionych = new ObservableCollection<Produkt>();
            //    }
            //    int wybrany = listtBox_produkty.SelectedIndex;
                
            //    lista.RemoveAt(wybrany);


            }
            else
            {
              MessageBox.Show("Nie wybrałeś produktów.");
               return;
            }




        }
            
            
            
        

        private void Button_dalej_Click(object sender, RoutedEventArgs e)
        {
            Klient k = new Klient();
            KlientWindow okno = new KlientWindow(k);
            okno.ShowDialog();

            zam.Klient = k;
            TextBox_klient.Text = k.ToString();
            okno.Close();
            
           
           
            

            
            

            


        }

        private void Button_szczegolyzamowienia_Click(object sender, RoutedEventArgs e)
        {

            Zamowienie za = new Zamowienie();
           
            ZamowienieWindow oknoZam = new ZamowienieWindow(za);
            zam.Platnosc = za.Platnosc;
            zam.Wysylka = zam.Wysylka;
            
            
            
            oknoZam.ShowDialog();
            double a = zam.ObliczWartosc();
            TextBox_wartosc.Text = String.Format(" Cena: {0:0.00} zł", a);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            zam.ZapiszXML("zamowienie.xml", zam);
            magazyn.ZapiszXML("magazynXML.xml",magazyn);
            this.Close();
        }
    }
}
