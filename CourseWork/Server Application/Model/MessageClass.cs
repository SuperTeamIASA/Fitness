using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Runtime.Serialization;

namespace  Server_Application.Model
{
    [DataContract(Namespace ="Some")]
    class MessageClass
    {
        [DataMember]
        long _messageTime;
        public DateTime Timeofmessage
        {
            get
            {
                return DateTime.FromBinary(_messageTime);
            }
            set
            {
                _messageTime = value.ToBinary();
            }
        }
        [DataMember]
        public  int _autor { get; set; }
        [DataMember]
        public string MessageText { get; set; }
        public HorizontalAlignment alignment
        {
            get
            {
                if (_autor == 0)
                    return HorizontalAlignment.Right;
                return HorizontalAlignment.Left;
            }
        }
            
    }
}
