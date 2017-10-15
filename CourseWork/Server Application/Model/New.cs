using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Drawing;


namespace Server_Application.Model
{
    [DataContract(Namespace ="Some")]
    class New
    {
        [DataMember]
        public int NewsId { get; set; }
        [DataMember]
        public string Title { get; set; }
        [DataMember]
        public string NewText { get; set; }
        [DataMember]
        public string imagename { get; set; }

       








    }
}
    

