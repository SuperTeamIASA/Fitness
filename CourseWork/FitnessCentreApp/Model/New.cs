using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using System.Runtime.Serialization;
using FitnessCentreApp.Properties;

using System.Drawing;


namespace FitnessCentreApp.Model
{
    [DataContract]
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
        public Uri Image
        {
            get
            {


                return new Uri(AppDomain.CurrentDomain.BaseDirectory + "/Images/" + imagename);
            }
        }

    }


}

    

