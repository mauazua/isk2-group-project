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
    class Trip

    {
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
}
