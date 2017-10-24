using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Windows;

namespace Server_Application.Model
{
    [DataContract(Namespace ="Some")]
    class ChatUser
    {
        [DataMember]
        public int userId { get; set; }
        /// <summary>
        /// Имя клиента
        /// </summary>
        [DataMember]
      public  string Name { get; set; }


        /// <summary>
        /// Фамилия клиента
        /// </summary>
        [DataMember]
        public string Surname { get; set; }
        


    }
}
