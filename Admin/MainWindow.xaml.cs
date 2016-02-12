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
using Npgsql;
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

                 !!!!PS: PÓKI CO POBIERANIE LOGINU I HASŁA Z BAZY NIE DZIAŁA - TRWAJĄ PRACE NAD TYM!!!!
                 */

                if (loginTextBox.Text=="a" && passTextBox.Password=="a" )

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
