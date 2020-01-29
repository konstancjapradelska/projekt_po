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
    /// Logika interakcji dla klasy lista_pracownikow_Window.xaml
    /// </summary>
    public partial class lista_pracownikow_Window : Window
    {
        
        ObservableCollection<pracownik> lista_pracownikow;
        pracownicy Pracownicy = new pracownicy();
        private void MoveBottomRightEdgeOfWindow()
        {
            Left = Application.Current.MainWindow.Left;
            Top = Application.Current.MainWindow.Top;
        }
        public lista_pracownikow_Window()
        {
            MoveBottomRightEdgeOfWindow();
            InitializeComponent();
            Pracownicy = Pracownicy.Odczytaj_Pracowników_XML("pracownicy.xml") as pracownicy;
            lista_pracownikow = new ObservableCollection<pracownik>(Pracownicy.Pracownicy);
            pracownicy_list.ItemsSource = lista_pracownikow;
        }
    }
}
