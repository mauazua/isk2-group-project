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
using System.Runtime.Serialization;
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
            var webAddr = "http://192.168.23.128:3000/api/events";
            var httpWebRequest = (HttpWebRequest)WebRequest.Create(webAddr);
            httpWebRequest.ContentType = "application/json; charset=utf-8";
            httpWebRequest.Method = "POST";

            using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
            {
                ListaWycieczek nowa = new ListaWycieczek();
                nowa.NazwaWycieczki = TextBoxNazwaWycieczki.Text;
                nowa.DataRozpoczecia = DatePickerDataRozpoczecia.Text;
                nowa.DataZakonczenia = DatePickerDataZakonczenia.Text;
                nowa.Miasto = TextBoxMiasto.Text;
                nowa.Kraj = TextBoxKraj.Text;
                nowa.CenaZaOsobe = int.Parse(TextBoxCenaZaOsobe.Text);
                nowa.LiczbaMiejsc = int.Parse(TextBoxLiczbaMiejsc.Text);

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