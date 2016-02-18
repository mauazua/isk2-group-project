using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
namespace Admin
{
    [Serializable]
    [DataContract]
    class ListaWycieczek
    {
        [DataMember]
        public string NazwaWycieczki { get; set; }
        [DataMember]
        public string DataRozpoczecia { get; set; }
        [DataMember]
        public string DataZakonczenia { get; set; }
        [DataMember]
        public string Miasto { get; set; }
        [DataMember]
        public string Kraj { get; set; }
        [DataMember]
        public int CenaZaOsobe { get; set; }
        [DataMember]
        public int LiczbaMiejsc { get; set; }
    }
    class ListaKlientow
    {
        [DataMember]
        public string Imie { get; set; }
        [DataMember]
        public string Nazwisko { get; set; }
    }
    public class User
    {
        [DataMember]
        public int id { get; set; }
        [DataMember]
        public object first_name { get; set; }
        [DataMember]
        public object last_name { get; set; }
        [DataMember]
        public string email { get; set; }
    }
    public class Events
    {
        [DataMember]
        public int id { get; set; }
        [DataMember]
        public string name { get; set; }
        [DataMember]
        public string start_date { get; set; }
        [DataMember]
        public string end_date { get; set; }
        [DataMember]
        public string location { get; set; }
        [DataMember]
        public string country { get; set; }
        [DataMember]
        public int price { get; set; }
        [DataMember]
        public int capacity { get; set; }
    }
    public class RootObject
    {
        [DataMember]
        public int id { get; set; }
        [DataMember]
        public int user_id { get; set; }
        [DataMember]
        public int event_id { get; set; }
        [DataMember]
        public bool confirmed { get; set; }
        [DataMember]
        public User user { get; set; }
        [DataMember]
        public Events @event { get; set; }
    }
}