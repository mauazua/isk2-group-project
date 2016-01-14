using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
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

namespace Admin
{

    public partial class Window3 : Window
    {
        public Window3()
        {
            InitializeComponent();
        }



        private void cofnij(object sender, RoutedEventArgs e)
        {

        }

     
        

        private void usuń(object sender, RoutedEventArgs e)
        {
            try {

                var webAddr = "http://192.168.23.128:3000/api/bookings/1";
                var httpWebRequest = (HttpWebRequest)WebRequest.Create(webAddr);
                httpWebRequest.ContentType = "application/json; charset=utf-8";
                httpWebRequest.Method = "DELETE";

                using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
                {

                    Booking booking = new Booking();
                    booking.user_id = int.Parse(textBox.Text);
                    booking.event_id = int.Parse(textBox1.Text);


                    string jsonString = JsonHelper.JsonSerializer(booking);
                    streamWriter.Write(jsonString);
                    streamWriter.Flush();
                }

                var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
                using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                {
                    var result = streamReader.ReadToEnd();
                    MessageBox.Show(result);
                }
            }
            catch(Exception )
            { }
        }


    


    }
}
