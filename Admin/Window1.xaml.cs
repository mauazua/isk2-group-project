using System;
using System.Windows;

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
            
            MainWindow main = new MainWindow();
            MessageBox.Show("Zostałeś poprawnie wylogowany");
            main.Show();
            Close();

        }
        private void ProgramInfo(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Panel Administracyjny - Program został opracowany przez ISK2, która jest studencką grupą, starającą się zapewnić w pełni działającą i stabilną aplikację desktopową do administracji wycieczek ");  
        }

        private void ListaWycieczekClick(object sender, RoutedEventArgs e)
        {
            Wycieczki wycieczki = new Wycieczki();
            wycieczki.Show();

            String[] w = { "Wycieczka1", "Wycieczka2", "Wycieczka3", "Wycieczka4", "Wycieczka5", "Wycieczka6", "Wycieczka7" };
            wycieczki.ZaladujListe(w);
        }

        

       
    }
}
