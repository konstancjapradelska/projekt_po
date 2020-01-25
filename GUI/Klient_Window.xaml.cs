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
using System.Windows.Shapes;
using po_projekt;

namespace GUI
{
    public partial class Klient_Window : Window
    { 
        klient klient_Window = new klient();
        ObservableCollection<klient> lista_klientów;
        klienci Klienci = new klienci();
        
        public Klient_Window()
        {
            InitializeComponent();
        }
        private void K_Button_Zatwierdź_Numer_Klienta_Click(object sender, RoutedEventArgs e)
        { 
            Klienci = Klienci.Odczytaj_Klientów_XML("klienci.xml") as klienci;

            lista_klientów = new ObservableCollection<klient>(Klienci.Klienci);
            bool numer = false;
            TextBox_Numer_Klienta.Text = klient_Window.Numer_klienta;
            string nk = klient_Window.Numer_klienta;
            MessageBox.Show(nk);
            numer = Klienci.sprawdzenie(klient_Window);
            Klient_Menu_Window klient_menu = new Klient_Menu_Window();
            if (numer)
                klient_menu.Show();
            else
                MessageBox.Show("Podano zły numer");
        }
    }
}
