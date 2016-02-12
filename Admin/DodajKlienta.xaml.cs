using System;
using System.IO;
using System.Net;
using System.Windows;
using System.Windows.Forms;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Windows.Controls;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
using System.Runtime.Serialization;

namespace Admin
{
    /// <summary>
    /// </summary>
    public partial class DodajKlienta : Window
    {
        public DodajKlienta()
        {
            InitializeComponent();
            TextBoxImie.Focus();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
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
                nowa.PESEL = int.Parse(TextBoxPESEL.Text);
                nowa.DataUrodzenia = DatePickerDataUrodzenia.Text;
                nowa.TelKontaktowy = int.Parse(TextBoxTelKontaktowy.Text);
                

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
    }
}
