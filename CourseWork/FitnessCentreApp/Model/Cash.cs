using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
namespace FitnessCentreApp.Model
{
    [DataContract]
    class Cash
    {
        [DataMember]
        public decimal allincash { get; set; }
        [DataMember]
        public decimal salarycash { get; set; }
        public decimal podatok { get
            {
                return Convert.ToDecimal(Convert.ToDouble(salarycash) * 0.195);
            } }
        public decimal flowcash
        {
            get
            {
                return allincash - salarycash - podatok;
            }
        }
    }
}
