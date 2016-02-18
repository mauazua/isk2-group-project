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
using System.IO;
using System.Net;
using System.Windows.Forms;
using System.Runtime.Serialization.Json;
using System.Windows.Navigation;
using System.Data.SqlClient;
using System.Data;
using Npgsql;
using System.Runtime.Serialization;
namespace Admin
{
    public partial class DodajKlienta : Window
    {
        public DodajKlienta()
        {
            InitializeComponent();
            TextBoxImie.Focus();
        }
        private void ButtonCofnij(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        private void ButtonDodaj(object sender, RoutedEventArgs e)
        {
            if (TextBoxImie.Text != "" & TextBoxNazwisko.Text != "" & TextBoxPesel.Text != "" & DatePickerDataUrodzenia.Text != "" & TextBoxNumerTelefonu.Text != "")
            {
                var webAddr = "http://192.168.23.128:3000/api/events";
                var httpWebRequest = (HttpWebRequest)WebRequest.Create(webAddr);
                httpWebRequest.ContentType = "application/json; charset=utf-8";
                httpWebRequest.Method = "POST";
                using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
                {
                    ListaKlientow nowa = new ListaKlientow();
                    nowa.Imie = TextBoxImie.Text;
                    nowa.Nazwisko = TextBoxNazwisko.Text;
                    nowa.Pesel = int.Parse(TextBoxPesel.Text);
                    nowa.DataUrodzenia = DatePickerDataUrodzenia.Text;
                    nowa.NumerTelefonu = int.Parse(TextBoxNumerTelefonu.Text);
                    string jsonString = JsonHelper.JsonSerializer(nowa);
                    streamWriter.Write(jsonString);
                    streamWriter.Flush();
                }
                var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
                using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                {
                    var result = streamReader.ReadToEnd();
                    System.Windows.MessageBox.Show(result);
                }
            }
            else
            {
                System.Windows.MessageBox.Show("Wypełnij wszystkie pola");
            }
        }
    }
}