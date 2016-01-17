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
        private void click3(object sender, RoutedEventArgs e)
        {
            Window2 obj = new Window2();


            obj.Show(); //otwiera się nowe okno 
            this.Hide();
        }
    }
}
