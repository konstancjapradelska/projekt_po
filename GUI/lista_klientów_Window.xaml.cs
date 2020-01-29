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
    /// Logika interakcji dla klasy lista_klientów_Window.xaml
    /// </summary>
    public partial class lista_klientów_Window : Window
    {
        klient klient_Window = new klient();
        ObservableCollection<klient> lista_klientów;
        klienci Klienci = new klienci();
        private void MoveBottomRightEdgeOfWindow()
        {
            Left = Application.Current.MainWindow.Left;
            Top = Application.Current.MainWindow.Top;
        }
        public lista_klientów_Window()
        {
            MoveBottomRightEdgeOfWindow();
            InitializeComponent();

            Klienci = Klienci.Odczytaj_Klientów_XML("klienci.xml") as klienci;
            lista_klientów = new ObservableCollection<klient>(Klienci.Klienci);
            klient_list.ItemsSource = lista_klientów;
        }
    }
}
