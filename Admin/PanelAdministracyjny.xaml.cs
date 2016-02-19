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
            List<ListaWycieczek> ListaWycieczekPozycja = new List<ListaWycieczek>();
            List<ListaKlientow> ListaKlientowPozycja = new List<ListaKlientow>();
            Wycieczki.Items.Add(new ListaWycieczek() { NazwaWycieczki = "Czechy", Miasto = "Praga", Kraj = "Czechy", CenaZaOsobe = 500, LiczbaMiejsc = 20 });
            Wycieczki.Items.Add(new ListaWycieczek() { NazwaWycieczki = "Brazylia", Miasto = "Rio", Kraj = "Brazylia", CenaZaOsobe = 4000, LiczbaMiejsc = 30 });
            Wycieczki.Items.Add(new ListaWycieczek() { NazwaWycieczki = "Francja", Miasto = "Paryż", Kraj = "Francja", CenaZaOsobe = 2500, LiczbaMiejsc = 25 });
            Wycieczki.Items.Add(new ListaWycieczek() { NazwaWycieczki = "Niemcy", Miasto = "Berlin", Kraj = "Niemcy", CenaZaOsobe = 2000, LiczbaMiejsc = 15 });
            Wycieczki.Items.Add(new ListaWycieczek() { NazwaWycieczki = "Włochy", Miasto = "Rzym", Kraj = "Włochy", CenaZaOsobe = 3500, LiczbaMiejsc = 25 });
            Klienci.Items.Add(new ListaKlientow() { Imie = "Artur", Nazwisko = "Kowalski", Pesel = 90010112345, NumerTelefonu = 508434678, AdresEmail = "arturkowalski@mail.pl" });
            Klienci.Items.Add(new ListaKlientow() { Imie = "Stefan", Nazwisko = "Nowak", Pesel = 90010112346, NumerTelefonu = 675935254, AdresEmail = "stefannowak@mail.pl" });
            Klienci.Items.Add(new ListaKlientow() { Imie = "Marcin", Nazwisko = "Mirecki", Pesel = 90010112347, NumerTelefonu = 785954223, AdresEmail = "marcinmirecki@mail.pl" });

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
        private void ButtonRezerwacje(object sender, RoutedEventArgs e)
        {
            UsunRezerwacje obj = new UsunRezerwacje();
            obj.Show();
        }
        private void ButtonDodajKlienta(object sender, RoutedEventArgs e)
        {
            DodajKlienta obj = new DodajKlienta();
            obj.Show();
        }
        private void ButtonUsunKlienta(object sender, RoutedEventArgs e)
        {
            if (Klienci.SelectedIndex == -1)
            {
                MessageBox.Show("Zaznacz pozycję");
            }
            else
            {
                Klienci.Items.Remove(Klienci.SelectedItem);
            }
        }
    }
}