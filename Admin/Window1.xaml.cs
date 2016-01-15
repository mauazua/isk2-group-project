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
using System.Data.SqlClient;
using System.Data;
using Npgsql;

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
            Window2 obj = new Window2();

            obj.Show();
        }
        private void Lista_Rezerwacji(object sender, RoutedEventArgs e)
        {
            Window3 obj = new Window3();

            obj.Show();
        }
        private void Potwierdz_Rezerwacje(object sender, RoutedEventArgs e)
        {
            Window5 okno = new Window5();

            okno.Show();
        }
        private void Lista_Wycieczek(object sender, RoutedEventArgs e)
        {
            Window4 obj = new Window4();

            obj.Show();
        }
    }
}