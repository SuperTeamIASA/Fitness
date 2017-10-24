using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace FitnessCentreApp.Model
{
    [DataContract(Namespace = "Some")]
    class ShortClientInfo
    {
        [DataMember]
       public int ID { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string Surname { get; set; }
    }
}
