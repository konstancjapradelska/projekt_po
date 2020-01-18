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
using System.Windows.Navigation;
using System.Windows.Shapes;
using po_projekt;

namespace GUI
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_klient_Click(object sender, RoutedEventArgs e)
        {
            Klient_Window klient_w = new Klient_Window();
            klient_w.ShowDialog();
        }

        private void Button_pracownik_Click(object sender, RoutedEventArgs e)
        {
            Pracownik_Window pracownik_w = new Pracownik_Window();
            pracownik_w.ShowDialog();
        }
    }
}
