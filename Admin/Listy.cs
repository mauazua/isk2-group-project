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
    class ListaRezerwacji
    {
        [DataMember]
        public string NazwaWycieczki { get; set; }
        [DataMember]
        public string Imie { get; set; }
        [DataMember]
        public string Nazwisko { get; set; }
    }
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
}