using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;


namespace Server_Application.Model
{
   [DataContract(Namespace ="Some")]
    class Client
    {
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string Surname { get; set; }
        [DataMember] 
        public string Email { get; set; }
        [DataMember]
        public string Phone { get; set; }
    }
}
