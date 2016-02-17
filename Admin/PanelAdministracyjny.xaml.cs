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
namespace Admin
{
    public partial class PanelAdministracyjny : Window
    {
        public PanelAdministracyjny()
        {
            InitializeComponent();
            List<ListaRezerwacji> ListaRezerwacjiPozycja = new List<ListaRezerwacji>();
            List<ListaWycieczek> ListaWycieczekPozycja = new List<ListaWycieczek>();
            List<ListaKlientow> ListaKlientowPozycja = new List<ListaKlientow>();
            Wycieczki.Items.Add(new ListaWycieczek() { NazwaWycieczki = "Test 1" });
            Wycieczki.Items.Add(new ListaWycieczek() { NazwaWycieczki = "Test 2" });
            Wycieczki.Items.Add(new ListaWycieczek() { NazwaWycieczki = "Test 3" });
        }
        private void ButtonUsunRezerwacje(object sender, RoutedEventArgs e)
        {
            UsunRezerwacje obj = new UsunRezerwacje();
            obj.Show();
        }
        private void ButtonDodajWycieczke(object sender, RoutedEventArgs e)
        {
            DodajWycieczke obj = new DodajWycieczke();
            obj.Show();
        }
        private void ButtonEdytujWycieczke(object sender, RoutedEventArgs e)
        {
            if (Wycieczki.SelectedIndex == -1)
            {
                MessageBox.Show("Zaznacz pozycję");
            }
        }
        private void ButtonUsunWycieczke(object sender, RoutedEventArgs e)
        {
            if (Wycieczki.SelectedIndex == -1)
            {
                MessageBox.Show("Zaznacz pozycję");
            }
            else
            {
                Wycieczki.Items.Remove(Wycieczki.SelectedItem);
            }
        }
    }
}