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
using System.Configuration;
using Newtonsoft.Json;
namespace Admin
{
    public partial class DodajWycieczke : Window
    {
        public DodajWycieczke()
        {
            InitializeComponent();
            TextBoxNazwaWycieczki.Focus();
        }
        private void ButtonCofnij(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        private void ButtonDodaj(object sender, RoutedEventArgs e)
        {
            if (TextBoxNazwaWycieczki.Text != "" & DatePickerDataRozpoczecia.Text != "" & DatePickerDataZakonczenia.Text != "" & TextBoxMiasto.Text != "" & TextBoxKraj.Text != "" & TextBoxCenaZaOsobe.Text != "" & TextBoxLiczbaMiejsc.Text != "")
            {
                try
                {
                    var request = (HttpWebRequest)WebRequest.Create(ConfigurationManager.AppSettings["Events-URL"]);
                    request.ContentType = "application/json; charset=utf-8";
                    request.Method = "POST";
                    request.Timeout = 2000;
                    request.Headers.Add(ConfigurationManager.AppSettings["header1"], ConfigurationManager.AppSettings["token"]);
                    request.Headers.Add(ConfigurationManager.AppSettings["header2"], ConfigurationManager.AppSettings["email"]);
                    using (var streamWriter = new StreamWriter(request.GetRequestStream()))
                    {
                        ListaWycieczek Wycieczka = new ListaWycieczek();
                        Wycieczka.NazwaWycieczki = TextBoxNazwaWycieczki.Text;
                        Wycieczka.DataRozpoczecia = DatePickerDataRozpoczecia.Text;
                        Wycieczka.DataZakonczenia = DatePickerDataZakonczenia.Text;
                        Wycieczka.Miasto = TextBoxMiasto.Text;
                        Wycieczka.Kraj = TextBoxKraj.Text;
                        Wycieczka.CenaZaOsobe = int.Parse(TextBoxCenaZaOsobe.Text);
                        Wycieczka.LiczbaMiejsc = int.Parse(TextBoxLiczbaMiejsc.Text);
                        var json = JsonConvert.SerializeObject(Wycieczka);
                        streamWriter.Write(json);
                        streamWriter.Flush();
                    }
                    var httpResponse = (HttpWebResponse)request.GetResponse();
                    using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                    {
                        var result = streamReader.ReadToEnd();
                        System.Windows.MessageBox.Show(result);
                    }
                }
                catch (Exception error)
                { System.Windows.MessageBox.Show(Convert.ToString(error)); }
            }
            else
            {
                System.Windows.MessageBox.Show("Wypełnij wszystkie pola");
            }
        }
    }
}