using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;
<<<<<<< efb548df890438ef1d07ec2e0b29bdbdb6deace2
=======

>>>>>>> Poprawienie requestow, nadal na sztywno, bo bylo testowane na wewnetrznym serwerze z nasza aplikacja ruby.
namespace Admin
{
    public class JsonHelper
    {
        public static string JsonSerializer<T>(T t)
        {
            DataContractJsonSerializer ser = new DataContractJsonSerializer(typeof(T));
            MemoryStream ms = new MemoryStream();
            ser.WriteObject(ms, t);
            string jsonString = Encoding.UTF8.GetString(ms.ToArray());
            ms.Close();
            return jsonString;
        }
<<<<<<< efb548df890438ef1d07ec2e0b29bdbdb6deace2
    }
}
=======

    }
}
>>>>>>> Poprawienie requestow, nadal na sztywno, bo bylo testowane na wewnetrznym serwerze z nasza aplikacja ruby.
