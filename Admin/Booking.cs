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
    class Booking
        
    {
        [DataMember]
        public int user_id { get; set; }
        [DataMember]
        public int event_id { get; set; }
        
    }
}
