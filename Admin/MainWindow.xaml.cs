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
namespace Admin
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            TextBoxLogin.Focus();
        }
        private void ButtonZaloguj(object sender, RoutedEventArgs e)
        {
            if (TextBoxLogin.Text != "" && PasswordBoxHaslo.Password != "")
            {
                /*
                NpgsqlConnection con = new NpgsqlConnection("Server=localhost;Port=5432;User Id=postgres;Password=miszamisza1; Database=AdminLogin;");
                con.Open();
                NpgsqlCommand com = new NpgsqlCommand("Select * from admindata where login='@UserId' and password='@word';",con);
                com.Parameters.AddWithValue("@UserId", loginTextBox.Text);
                com.Parameters.AddWithValue("@word", passTextBox.Password);
                com.CommandType = CommandType.Text;
                NpgsqlDataAdapter adapt = new NpgsqlDataAdapter(com);
                adapt.SelectCommand = com;
                DataSet ds = new DataSet();
                adapt.Fill(ds);
                con.Close();
                int count = ds.Tables[0].Rows.Count;
                if (count==1)
                 */
                if // (TextBoxLogin.Text == ConfigurationManager.AppSettings["username"] && PasswordBoxHaslo.Password == ConfigurationManager.AppSettings["password"])
                   (TextBoxLogin.Text == "1" && PasswordBoxHaslo.Password == "1")
                {
                    PanelAdministracyjny obj = new PanelAdministracyjny();
                    obj.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Nieprawidłowy login lub hasło");
                }
            }
            else
            {
                MessageBox.Show("Wpisz login i hasło");
            }
        }
    }
}