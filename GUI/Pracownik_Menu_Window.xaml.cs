﻿using System;
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
    
    public partial class Pracownik_Menu_Window : Window
    {
        private void MoveBottomRightEdgeOfWindow()
        {
            Left = Application.Current.MainWindow.Left;
            Top = Application.Current.MainWindow.Top;
        }

        public Pracownik_Menu_Window()
        {
            MoveBottomRightEdgeOfWindow();
            InitializeComponent();
        }

        private void Oferta_button_Click(object sender, RoutedEventArgs e)
        {
            Oferta_Window oferta = new Oferta_Window();
            oferta.Show();
        }

        private void Klienci_button_Click(object sender, RoutedEventArgs e)
        {
            lista_klientów_Window lk = new lista_klientów_Window();
            lk.Show();
        }

        private void Pracownicy_button_Click(object sender, RoutedEventArgs e)
        {
            lista_pracownikow_Window lp = new lista_pracownikow_Window();
            lp.Show();
        }
    }
}
