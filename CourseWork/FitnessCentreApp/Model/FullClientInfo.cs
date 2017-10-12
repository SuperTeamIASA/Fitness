using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FitnessCentreApp.Model;
using System.Runtime.Serialization;
using System.Drawing;


namespace FitnessCentreApp.Model
{
    [DataContract(Namespace ="Some")]
    class FullClientInfo
    {
        [DataMember]
        int ID { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string Surname { get; set; }
        [DataMember]
        public string Email { get; set; }
        [DataMember]
        public string Phone { get; set; }
        [DataMember]
        public string City { get; set; }
        [DataMember]
        public string Adress { get; set; }
       //public string Image1
       // {
       //     get
       //     {

       //         System.IO.MemoryStream memoryStream1 = new System.IO.MemoryStream();
       //         foreach (byte b1 in imagebytearray) memoryStream1.WriteByte(b1);
       //         Image image1 = Image.FromStream(memoryStream1);
       //         image1.Save("Images\\" + ID+ ".png", System.Drawing.Imaging.ImageFormat.Png);
                
       //         return "Images\\" + ID + ".png";
       //     }
       //        }
        public Aboniment AbonimentInfo { get; set; }

    }
}
