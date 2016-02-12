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
        private void MenuItemOProgramie(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Panel administracyjny - program został opracowany przez ISK2, która jest studencką grupą, starającą się zapewnić w pełni działającą i stabilną aplikację desktopową do administracji wycieczek");
        }
        private void MenuItemWyloguj(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        private void ButtonDodajWycieczke(object sender, RoutedEventArgs e)
        {
            DodajWycieczke obj = new DodajWycieczke();
            obj.Show();
        }
        private void ButtonEdytujWycieczke(object sender, RoutedEventArgs e)
        {
        }
        private void ButtonUsunWycieczke(object sender, RoutedEventArgs e)
        {
            Wycieczki.Items.Remove(Wycieczki.SelectedItem);
        }
<<<<<<< c1407db69e3b8a5a755e7869729ab2dc9c539300
      

        private void Usun_Rezerwacje(object sender, RoutedEventArgs e)
        {

            UsunRezerwacje usun = new UsunRezerwacje();
            usun.Show();

=======

        private void TabControl_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void ButtonDodajKlienta(object sender, RoutedEventArgs e)
        {
            DodajKlienta obj = new DodajKlienta();
            obj.Show();
>>>>>>> Dodawanie Kliento
        }
    }
}