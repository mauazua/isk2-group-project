using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Admin

{
    [DataContract]
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
