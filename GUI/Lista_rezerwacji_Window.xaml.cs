using System;
using System.Collections.Generic;
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
    /// Logika interakcji dla klasy Lista_rezerwacji_Window.xaml
    /// </summary>
    public partial class Lista_rezerwacji_Window : Window
    {
        List<samochody> ls = new List<samochody>();
        private void MoveBottomRightEdgeOfWindow()
        {
            Left = Application.Current.MainWindow.Left;
            Top = Application.Current.MainWindow.Top;
        }
        public Lista_rezerwacji_Window()
        {
            ls = OdczytajXML();
            MoveBottomRightEdgeOfWindow();
            InitializeComponent();
            ls = OdczytajXML();
            MoveBottomRightEdgeOfWindow();
            InitializeComponent();
            rezerwacje_list.ItemsSource = ls;
        }

        public List<samochody> OdczytajXML()
        {
            List<samochody> ls2 = new List<samochody>();
            XmlSerializer serializer = new XmlSerializer(typeof(List<samochody>));
            StreamReader reader = new StreamReader("zarezerwowane.xml");
            ls2 = serializer.Deserialize(reader) as List<samochody>;
            reader.Close();
            return ls2;
        }
    }
}
