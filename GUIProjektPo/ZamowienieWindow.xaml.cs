using System;
using System.Collections.Generic;
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
using System.Windows.Shapes;
using ProjektPO;

namespace GUIProjektPo
{
    /// <summary>
    /// Interaction logic for ZamowienieWindow.xaml
    /// </summary>
    /// 
    
    public partial class ZamowienieWindow : Window
    {
       
        public ZamowienieWindow()
        {
            InitializeComponent();
        }

       public ZamowienieWindow(Zamowienie z):this()
        {
            if (z.Wysylka == SposobWysylki.kurier)
            {
                ComboBox_sposobWysylki.Text = "Kurier";
            }
            else if(z.Wysylka==SposobWysylki.odbior_osobisty)
            {
                ComboBox_sposobWysylki.Text = "Odbior osobisty";
            }
            else if (z.Wysylka == SposobWysylki.paczkomat)
            {
                ComboBox_sposobWysylki.Text = "Paczkomat";
            }
            else if (z.Wysylka == SposobWysylki.poczta_polska)
            {
                ComboBox_sposobWysylki.Text = "Poczta Polska";
            }



            if (z.Platnosc == RodzajPlatnosci.karta_platnicza)
            {
                ComboBox_rodzajPlatnosci.Text = "Karta Platnicza";
            }
            else if (z.Platnosc == RodzajPlatnosci.przelew_bankowy)
            {
                ComboBox_rodzajPlatnosci.Text = "Przelew bankowy";
            }
            else if (z.Platnosc == RodzajPlatnosci.za_pobraniem)
            {
                ComboBox_rodzajPlatnosci.Text = "Za pobraniem";
            }

         


        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void ComboBox_sposobWysylki_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
