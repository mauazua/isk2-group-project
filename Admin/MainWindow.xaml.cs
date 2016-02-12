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
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using System.Security;
using System.Security.Cryptography;
namespace Admin
{
    
    public partial class MainWindow : Window
    {

        
        public MainWindow()
        {
            InitializeComponent();
        }

        private void zalogujClick(object sender, RoutedEventArgs e)
        {
            if (loginTextBox.Text != "" && passTextBox.Password != "")
            {


                if (loginTextBox.Text == System.Configuration.ConfigurationManager.AppSettings["username"] && passTextBox.Password == System.Configuration.ConfigurationManager.AppSettings["password"])


                {
                                                    
                    Window1 obj = new Window1();

                    
                    obj.Show(); //otwiera się nowe okno 
                    this.Hide();//okno logowania ukrywa się po poprawnym zalogowaniu


                }
                else
                {

                    MessageBox.Show("Niepoprawna nazwa użytkownika lub hasło");

                }
            }
            else
            {

                MessageBox.Show("Nazwa użytkownika i hasło są wymagane");

            }   

        }

                
            
            }

}
