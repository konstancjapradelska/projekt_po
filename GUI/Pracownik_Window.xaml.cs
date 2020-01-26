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
    public partial class Pracownik_Window : Window
    {
        pracownik pracownik_Window = new pracownik();
        ObservableCollection<pracownik> lista_pracowników;
        pracownicy Pracownicy = new pracownicy();


        public Pracownik_Window()
        {
            InitializeComponent();

        }
        

        private void K_Button_Zatwierdź_Numer_Pracownika_Click(object sender, RoutedEventArgs e)
        {
            


            if(TextBox_Haslo.Text == "programowanie")
            {

                Pracownicy = Pracownicy.Odczytaj_Pracowników_XML("pracownicy.xml") as pracownicy;

                lista_pracowników = new ObservableCollection<pracownik>(Pracownicy.Pracownicy);

                pracownik_Window.Identyfikator = TextBox_Numer_Pracownika.Text;

                pracownik t = new pracownik();
                t = Pracownicy.sprawdzenie(pracownik_Window) as pracownik;
                Pracownik_Menu_Window pracownik_menu = new Pracownik_Menu_Window();
                if (t.Imie != "")
                {
                    MessageBox.Show(pracownik_Window.Identyfikator);
                    pracownik_menu.Show();
                }
                else
                    MessageBox.Show("Podano zły numer");

            }
            else
            {
                MessageBox.Show("Złe hasło");
            }

        }
    }
}
