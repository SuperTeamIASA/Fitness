﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Windows;

namespace FitnessCentreApp.Model
{
    [DataContract(Namespace ="Some")]
    class ChatUser
    {
        [DataMember]
        public int userId { get; set; }
       
        [DataMember]
      public  string Name { get; set; }

      
        [DataMember]
        public string Surname { get; set; }
         


    }
}
