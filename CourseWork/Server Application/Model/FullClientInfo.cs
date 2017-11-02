using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Runtime.Serialization;
using System.Drawing;


namespace Server_Application.Model
{
    [DataContract(Namespace ="Some")]
    class FullClientInfo
    {
        
        [DataMember]
        int ID { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string Surname { get; set; }
        [DataMember]
        public string Email { get; set; }
        [DataMember]
        public string Phone { get; set; }
        [DataMember]
        public string City { get; set; }
        [DataMember]
        public string Adress { get; set; }
        [DataMember]
        public string Gender { get; set; }
        [DataMember]
        public string information { get; set; }
        [DataMember]
        public string image { get; set; }
        [DataMember]
        long bdatebyt;
        public DateTime bdate {
            get
            {
                return DateTime.FromBinary(bdatebyt);
            }
            set
            {
               bdatebyt = value.ToBinary();
            }
        }
        public Aboniment AbonimentInfo { get; set; }

    }
}
