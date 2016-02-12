using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Windows;
using System.Configuration;

namespace Admin
{
    
    public partial class UsunRezerwacje : Window
    {
        public UsunRezerwacje()
        {
            
            try {
                InitializeComponent();
                getbookings();
                }
            catch(Exception e)
            {
                MessageBox.Show(Convert.ToString(e));
            }
        }

        private void getbookings()
        {
            try
            {        
                WebRequest request = WebRequest.Create(ConfigurationManager.AppSettings["Booking-URL"]);
                request.Timeout = 1000;                
                request.Method = "GET";               
                request.Headers.Add(ConfigurationManager.AppSettings["header1"], ConfigurationManager.AppSettings["token"]);
                request.Headers.Add(ConfigurationManager.AppSettings["header2"], ConfigurationManager.AppSettings["email"]);
                using (WebResponse response = request.GetResponse())
                {
                    using (Stream stream = response.GetResponseStream())
                    {
                        StreamReader reader = new StreamReader(stream);
                        string respond = reader.ReadToEnd();
                        List<RootObject> bookings = new List<RootObject>
                        { };
                        
                        bookings = JsonConvert.DeserializeObject<List<RootObject>>(respond);
                        foreach (RootObject b in bookings)
                        {
                            listBox.Items.Add("ID: " + b.id + "           " + "Nazwa wycieczki: " + b.@event.name + " || " + "Email użytkownika: " + b.user.email); 
                                                       
                        }
                        
                    }

                }
            }
            catch (Exception e)
            { MessageBox.Show(Convert.ToString(e)); }
        }
        private void deletebookings(int id)
        {
            try {
                WebRequest request = WebRequest.Create(ConfigurationManager.AppSettings["Booking-URL"] + id);
                request.Method = "DELETE";
                request.Timeout = 1000;
                request.Headers.Add(ConfigurationManager.AppSettings["header1"], ConfigurationManager.AppSettings["token"]);
                request.Headers.Add(ConfigurationManager.AppSettings["header2"], ConfigurationManager.AppSettings["email"]);
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                }
            catch(Exception e)
            {
                MessageBox.Show(Convert.ToString(e));
            }
        }

        private void usun(object sender, RoutedEventArgs e)
        {
            if(listBox.SelectedIndex == -1)
            {
                MessageBox.Show("Musisz wybrać rezerwację do usunięcia!");
            }
            else
            {
                MessageBoxResult messageBoxResult = MessageBox.Show("Jesteś pewien?", "Potwierdzenie usunięcia", MessageBoxButton.OKCancel);
                    if (messageBoxResult == MessageBoxResult.OK) 
                    {
                        
                        string s = listBox.SelectedItem.ToString();
                        string str = s.Substring(4, 10);
                        int i = Convert.ToInt32(str);
                        RootObject r = new RootObject();
                        r.id = i;
                        deletebookings(r.id);
                        MessageBox.Show(Convert.ToString("Usunieto rezerwację o numerze: " + r.id));
                        listBox.Items.Remove(listBox.SelectedItem);

                    }
                    else
                    {
                        MessageBox.Show("Przerwano usuwanie");
                    }        
                                       
            }
        }

        private void anuluj(object sender, RoutedEventArgs e)
        {
            Close();           
        }
    }
}
