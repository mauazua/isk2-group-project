using System.Windows;
using System.Threading;

namespace Admin
{
    public partial class MainMenu : Window
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void logoutClick(object sender, RoutedEventArgs e)
        {
            Hide();
            MessageBox.Show("Zostałeś poprawnie wylogowany");
            
        }
        private void ProgramInfo(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Panel Administracyjny");  
        }

        private void click3(object sender, RoutedEventArgs e)
        {
            Window2 obj = new Window2();

            obj.Show();
            Close();
        }

        private void Usun_Rezerwacje(object sender, RoutedEventArgs e)
        {

            UsunRezerwacje usun = new UsunRezerwacje();
            usun.Show();

        }
    }
}
