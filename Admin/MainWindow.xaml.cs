using System.Configuration;
using System.Windows;
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


                if (loginTextBox.Text == ConfigurationManager.AppSettings["username"] && passTextBox.Password == ConfigurationManager.AppSettings["password"])




                {
                                                    
                    MainMenu obj = new MainMenu();
           
                    obj.Show();
                    Close();


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