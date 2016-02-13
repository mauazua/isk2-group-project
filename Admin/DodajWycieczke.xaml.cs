using System.IO;
using System.Net;
using System.Windows;
using System.Configuration;
using System;
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
            Close();
        }
        private void ButtonDodaj(object sender, RoutedEventArgs e)
        {

            if (TextBoxNazwaWycieczki.Text != "" & TextBoxMiasto.Text != "" & TextBoxKraj.Text != "" & TextBoxCenaZaOsobe.Text != "" & TextBoxLiczbaMiejsc.Text != "" & DatePickerDataRozpoczecia.Text != "" & DatePickerDataZakonczenia.Text != "") 
            {
                try {
                    var request = (HttpWebRequest)WebRequest.Create(ConfigurationManager.AppSettings["Events-URL"]);
                    request.ContentType = "application/json; charset=utf-8";
                    request.Method = "POST";
                    request.Timeout = 2000;
                    request.Headers.Add(ConfigurationManager.AppSettings["header1"], ConfigurationManager.AppSettings["token"]);
                    request.Headers.Add(ConfigurationManager.AppSettings["header2"], ConfigurationManager.AppSettings["email"]);

                    using (var streamWriter = new StreamWriter(request.GetRequestStream()))
                    {
                        Events trip = new Events();
                        trip.name = TextBoxNazwaWycieczki.Text;
                        trip.start_date = DatePickerDataRozpoczecia.Text;
                        trip.end_date = DatePickerDataZakonczenia.Text;
                        trip.location = TextBoxMiasto.Text;
                        trip.country = TextBoxKraj.Text;
                        trip.price = int.Parse(TextBoxCenaZaOsobe.Text);
                        trip.capacity = int.Parse(TextBoxLiczbaMiejsc.Text);

                        var json = JsonConvert.SerializeObject(trip);
                        streamWriter.Write(json);
                        streamWriter.Flush();

                    }
                    var httpResponse = (HttpWebResponse)request.GetResponse();
                    using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                    {
                        var result = streamReader.ReadToEnd();
                        MessageBox.Show(result);
                    }
                }
                catch(Exception error)
                { MessageBox.Show(Convert.ToString(error)); }
            }
            else
            {
                MessageBox.Show("Wypełnij wszystkie pola!");
            }
        }
    }
}