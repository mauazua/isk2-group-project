using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Admin
{
    [DataContract]
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
}
