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
    /// Logika interakcji dla klasy Oferta.xaml
    /// </summary>
    public partial class Oferta_Window : Window
    {
        private void MoveBottomRightEdgeOfWindow()
        {
            Left = Application.Current.MainWindow.Left;
            Top = Application.Current.MainWindow.Top;
        }
        public Oferta_Window()
        {
            InitializeComponent();
        
            oferta Oferta = new oferta();
            Oferta = Oferta.OdczytajXML("zapis.xml") as oferta;

            ObservableCollection<samochody> lista;
            lista = new ObservableCollection<samochody>(Oferta.Oferta);
            listbox_oferta_window.ItemsSource = lista;
            
        }
    }
}
