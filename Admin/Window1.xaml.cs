<<<<<<< c35449793daca8b82ef0ec45828ecfb8e46f3744

﻿using System;
using System.Collections.Generic;
=======
﻿using System.Collections.Generic;
>>>>>>> Dodanie okna dodaj wycieczke
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
<<<<<<< c35449793daca8b82ef0ec45828ecfb8e46f3744
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Data.SqlClient;
using System.Data;
using Npgsql;
=======
using System.Data.SqlClient;
using System.Data;
using Npgsql;

>>>>>>> Dodanie okna dodaj wycieczke

namespace Admin
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }

        private void logoutClick(object sender, RoutedEventArgs e)
        {
            this.Hide();
            MessageBox.Show("Zostałeś poprawnie wylogowany");

        }
        private void ProgramInfo(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Panel Administracyjny - Program został opracowany przez ISK2, która jest studencką grupą, starającą się zapewnić w pełni działającą i stabilną aplikację desktopową do administracji wycieczek ");
        }

        private void Dodaj_Wycieczke(object sender, RoutedEventArgs e)
        {
            Window2 okno = new Window2();

            okno.Show();

        }

        private void ListaWycieczekClick(object sender, RoutedEventArgs e)
        {
            Wycieczki wycieczki = new Wycieczki();
            wycieczki.Show();

            String[] w = { "Wycieczka1", "Wycieczka2", "Wycieczka3", "Wycieczka4", "Wycieczka5", "Wycieczka6", "Wycieczka7" };
            wycieczki.ZaladujListe(w);
        }

<<<<<<< c35449793daca8b82ef0ec45828ecfb8e46f3744
        

       
=======
        private void Dodaj_Wycieczke(object sender, RoutedEventArgs e)
        {
            Window2 okno = new Window2();

            okno.Show();

        }
>>>>>>> Dodanie okna dodaj wycieczke
    }
}
