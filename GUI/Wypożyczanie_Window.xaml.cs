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
    /// <summary>
    /// Logika interakcji dla klasy Wypożyczanie_Window.xaml
    /// </summary>
    public partial class Wypożyczanie_Window : Window
    {
        private void MoveBottomRightEdgeOfWindow()
        {
            Left = Application.Current.MainWindow.Left;
            Top = Application.Current.MainWindow.Top;
        }
        oferta Oferta = new oferta();
        ObservableCollection<samochody> lista;
        List<samochody> ls = new List<samochody>();

        public Wypożyczanie_Window()
        {
 
            InitializeComponent();
            Oferta = Oferta.OdczytajXML("zapis.xml") as oferta;
         
            lista = new ObservableCollection<samochody>(Oferta.Oferta);
            listbox_oferta_window.ItemsSource = lista;       
        }

        private void Button_wypożycz_Click(object sender, RoutedEventArgs e)
        {
            int zaznaczony = listbox_oferta_window.SelectedIndex;
            samochody zaznaczony2 = listbox_oferta_window.SelectedItem as samochody;
            
            klient k = new klient();
            XmlSerializer serializer = new XmlSerializer(typeof(klient));
            StreamReader reader = new StreamReader("klient.xml");
            k = serializer.Deserialize(reader) as klient;
            reader.Close();
            
            wypożyczanie w1 = new wypożyczanie();
            w1.wypożycz(zaznaczony2, Oferta);

            k.Wypożyczone_klienta(Oferta);

            MessageBox.Show("wypożyczono:\n"+zaznaczony2);
            ls.Add(zaznaczony2);
            ZapiszXML(ls);
            lista.RemoveAt(zaznaczony);
            Oferta.Oferta.Remove(zaznaczony2);

        }

        private void ZapiszXML(List<samochody> ls)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<samochody>));
            StreamWriter writer = new StreamWriter("wypożyczone.xml");
            serializer.Serialize(writer, ls);
            writer.Close();
        }



    }
}
