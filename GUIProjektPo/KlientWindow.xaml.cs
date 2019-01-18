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
    /// Interaction logic for KlientWindow.xaml
    /// </summary>
    
    public partial class KlientWindow : Window
    {
        Klient klient=new Klient();
        public KlientWindow()
        {
            InitializeComponent();


        }
        public KlientWindow(Klient klient):this()
        {
           
                this.klient = klient;
                imiee.Text = klient.Imie;
                nazwiskoo.Text = klient.Nazwisko;
                miejscowoscc.Text = klient.Miejscowosc;
                ulicaa.Text = klient.Ulica;
                kodpocztowyy.Text = klient.KodPocztowy;
                numertell.Text = klient.NrTelefonu;
                emaill.Text = klient.Email;
           
            

            

        }
        //BUTTON zatwierdz
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (imiee.Text == "" || nazwiskoo.Text == "" || miejscowoscc.Text =="" || ulicaa.Text == "" || kodpocztowyy.Text == "" || numertell.Text == "" || emaill.Text == "")
            {
                MessageBox.Show("Zle dane!!!!");
                return;
            }
            else
            {
                if (numertell.Text.Length == 9)
                {
                    klient.Imie = imiee.Text;
                    klient.Nazwisko = nazwiskoo.Text;
                    klient.Miejscowosc = miejscowoscc.Text;
                    klient.Ulica = ulicaa.Text;
                    klient.KodPocztowy = kodpocztowyy.Text;
                    klient.NrTelefonu = numertell.Text;
                    klient.Email = emaill.Text;
                }
                else
                {
                    MessageBox.Show("Złe dane");
                    return;
                }


                this.Close();
        
                
            }
            
        }
    }
}
