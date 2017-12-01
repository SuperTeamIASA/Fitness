using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;


namespace Server_Application.Model
{
    [DataContract(Namespace ="Some")]
    class Post
    {
        [DataMember]
        public int postId { get; set; }
        [DataMember]
        public string postName { get; set; }
        [DataMember]
        public string description { get; set; }
        [DataMember]
        public decimal salary { get; set; }
    }
}
