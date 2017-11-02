using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace Server_Application.Model
{
    [DataContract(Namespace ="Some")]
    class Aboniment
    {
        [DataMember]
        public int abonID { get; set; }
        [DataMember]
        public int groupcount { get; set; }
        [DataMember]
        public DateTime selldata { get; set; }
            
    }
}
