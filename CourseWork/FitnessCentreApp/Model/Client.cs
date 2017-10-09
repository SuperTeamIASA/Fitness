using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Runtime.Serialization;

namespace FitnessCentreApp.Model
{
   [DataContract(Namespace ="Some")]
    class Client
    {
        /// <summary>
        /// Имя нового клиента
        /// </summary>
        [DataMember]
        public string Name { get; set; }
        /// <summary>
        /// Фамилия нового клиента
        /// </summary>
        [DataMember]
        public string Surname { get; set; }
        /// <summary>
        /// Email нового клиента
        /// </summary>
        [DataMember] 
        public string Email { get; set; }
        /// <summary>
        /// Телефон нового клиента
        /// </summary>
        [DataMember]
        public string Phone { get; set; }
    }
}
