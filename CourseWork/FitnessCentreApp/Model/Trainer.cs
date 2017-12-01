using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace FitnessCentreApp.Model
{
    [DataContract(Namespace = "Some")]
    class Trainer
    {
        [DataMember]
        public int trainerId { get; set; }
        [DataMember]
        public int empId { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string LastName { get; set; }
        [DataMember]
        public long _bdate;
        public DateTime Bdate
        {
            get { return DateTime.FromBinary(_bdate); }
            set
            {
                _bdate = value.ToBinary();
            }
        }
        [DataMember]
        public string email { get; set; }
        [DataMember]
        public string phone { get; set; }
        [DataMember]
        public string about { get; set; }
        [DataMember]
        public string photo { get; set; }
    }
}
