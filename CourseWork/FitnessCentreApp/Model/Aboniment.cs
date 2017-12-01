using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;


namespace FitnessCentreApp.Model
{
    [DataContract(Namespace = "Some")]
    class Aboniment
    {
        [DataMember]
        public int abonID { get; set; }
        [DataMember]
        public int groupcount { get; set; }
        [DataMember]
        public long selldatebits;
        public DateTime selldata
        {
            get
            {
                return DateTime.FromBinary(selldatebits);
            }
            set
            {
                selldatebits = value.ToBinary();
            }
        }
        [DataMember]
        public string name { get; set; }
        [DataMember]
        public double cost { get; set; }
        [DataMember]
        public double sale { get; set; }
        [DataMember]
        public bool pool { get; set; }
        [DataMember]
        public string description { get; set; }
        [DataMember]
        public int duration { get; set; }
            
    }
}
