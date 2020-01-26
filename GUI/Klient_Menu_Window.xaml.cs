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
using po_projekt;

namespace GUI
{
    /// <summary>
    /// Logika interakcji dla klasy Klient_Menu_Window.xaml
    /// </summary>
    public partial class Klient_Menu_Window : Window
    {
        public Klient_Menu_Window()
        {
            InitializeComponent();
        }

        private void Button_oferta_Click(object sender, RoutedEventArgs e)
        {
            Oferta_Window oferta = new Oferta_Window();
            oferta.Show();
        }

        private void Button_rezerwuj_Click(object sender, RoutedEventArgs e)
        {
            Rezerwacja_Window rezerwacja = new Rezerwacja_Window();
            rezerwacja.Show();
        }

        private void Button_wypożycz_Click(object sender, RoutedEventArgs e)
        {
            Wypożyczanie_Window wypożyczanie = new Wypożyczanie_Window();
            wypożyczanie.Show();
        }

        private void Button_lista_wypożyczeń_Click(object sender, RoutedEventArgs e)
        {
            Lista_Wypożyczeń_Window lista_w = new Lista_Wypożyczeń_Window();
            lista_w.Show();
        }

        private void Button_koniec_klient_Click(object sender, RoutedEventArgs e)
        {
            MainWindow koniec = new MainWindow();
            koniec.Show();
        }
    }
}
