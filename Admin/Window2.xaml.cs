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

    public partial class Window2 : Window
    {
        public Window2()
        {
            InitializeComponent();

        }

        private void Wyślij_Click(object sender, RoutedEventArgs e)
        {

            var webAddr = "http://192.168.23.128:3000/api/events";
            var httpWebRequest = (HttpWebRequest)WebRequest.Create(webAddr);
            httpWebRequest.ContentType = "application/json; charset=utf-8";
            httpWebRequest.Method = "POST";

            using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
            {



                Trip nowa = new Trip();
                nowa.name = textBox.Text;
                nowa.start_date = datepicker1.Text;
                nowa.end_date = datepicker2.Text;
                nowa.location = textBox_Copy.Text;
                nowa.country = textBox_Copy1.Text;
                nowa.price = int.Parse(textBox_Copy2.Text);
                nowa.capacity = int.Parse(textBox_Copy3.Text);


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
