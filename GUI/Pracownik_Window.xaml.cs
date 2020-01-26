using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
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
using System.Xml.Serialization;
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
                bool numer = false;
                pracownik_Window.Identyfikator = TextBox_Numer_Pracownika.Text;
                
                numer = Pracownicy.sprawdzenie(pracownik_Window);
                Pracownik_Menu_Window pracownik_menu = new Pracownik_Menu_Window();
                if(numer)
                {
                    pracownik_Window = Pracownicy.Pobierz(pracownik_Window.Identyfikator) as pracownik;

                    string nazwa = "pracownik.xml";
                    XmlSerializer serializer = new XmlSerializer(typeof(pracownik));
                    StreamWriter writer = new StreamWriter(nazwa);
                    serializer.Serialize(writer, pracownik_Window);
                    writer.Close();
                    pracownik_menu.Show();
                }
                else
                    MessageBox.Show("Podano zły identyfikator");
            }
            else
            {
                MessageBox.Show("Złe hasło");
            }
        }
    }
}
