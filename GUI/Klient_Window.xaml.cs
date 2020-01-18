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
    /// <summary>
    /// Logika interakcji dla klasy Klient.xaml
    /// </summary>
    public partial class Klient_Window : Window
    {
        klient klient_Window = new klient();
        List<klient> Klienci_Window = new List<klient>();
        ObservableCollection<klienci> Klienci;

        //    Zespół zespół = new Zespół();
        //ObservableCollection<CzlonekZespolu> lista;

        //public MainWindow()
        //{
        //    InitializeComponent();


        //    zespół = zespół.OdczytajXML("zespol.xml") as Zespół;

        //    //zespół = new Zespół("Ala ma kota",null);
        //    textBox_nazwa.Text = zespół.Nazwa;
        //    textbox_kierownik.Text = zespół.Kierownik.ToString();
        //    lista = new ObservableCollection<CzlonekZespolu>(zespół.członkowie);
        //    listbox_członkowie.ItemsSource = lista;

        //}

        public Klient_Window()
        {
            InitializeComponent();
            Klienci = klienci.Odczytaj_Klienci_XML();
        }
        public Klient_Window(klient klient) :this()
        {
            this.klient_Window = klient;
            TextBox_Numer_Klienta.Text = klient.Numer_klienta;
        }

        private void K_Button_Zatwierdź_Numer_Klienta_Click(object sender, RoutedEventArgs e)
        {
            Klient_Menu_Window klient_menu = new Klient_Menu_Window();
            foreach(klient element in Klienci)
            {
                if (element.Numer_klienta == TextBox_Numer_Klienta.Text)
                    klient_menu.ShowDialog();
            }
        }
        //public OsobaWindow(Osoba osoba) : this()
        //{
        //    this.osoba = osoba;
        //    if (osoba.PESEL1 != "00000000000")
        //    {
        //        textBox_Pesel.Text = osoba.PESEL1;
        //        textBox_imie.Text = osoba.Imie;
        //        textBox_nazwisko.Text = osoba.Nazwisko;
        //        textBox_dataUr.Text = osoba.DataUrodzenia.ToShortDateString();
        //        if ((osoba.Plec) == Osoba.Płcie.K)
        //            combobox_płcie.Text = "kobieta";
        //        else
        //            combobox_płcie.Text = "mężczyzna";
        //    }
        //}

    }
}
