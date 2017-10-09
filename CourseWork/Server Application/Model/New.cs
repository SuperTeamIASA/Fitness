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
        public string Title { get; set; }
        [DataMember]
        public string NewText { get; set; }
        [DataMember]
        public byte[] imagebytearray { get; set; }


        public string Image1
        {
            get
            {
              
                System.IO.MemoryStream memoryStream1 = new System.IO.MemoryStream();
                foreach (byte b1 in imagebytearray) memoryStream1.WriteByte(b1);
                Image image1 = Image.FromStream(memoryStream1);
                image1.Save(@"Images/" + Title.ToLower() + ".png", System.Drawing.Imaging.ImageFormat.Png);
                return @"Images/" + Title.ToLower() + ".png";
            }
            set
            {
                Image image = Image.FromFile(value);

                System.IO.MemoryStream memoryStream = new System.IO.MemoryStream();
                image.Save(memoryStream, System.Drawing.Imaging.ImageFormat.Png);
                imagebytearray = memoryStream.ToArray();
            }



        }



    }
}
    

