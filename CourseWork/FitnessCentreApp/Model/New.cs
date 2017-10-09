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
        /// <summary>
        /// Заголовок
        /// </summary>
        [DataMember]
        public string Title { get; set; }
        /// <summary>
        /// Основной текст
        /// </summary>
        [DataMember]
        public string NewText { get; set; }
        /// <summary>
        /// Картинка в виде масива байт
        /// </summary>
        [DataMember]
        public byte[] imagebytearray { get; set; }
        /// <summary>
        /// обвертка для масива байт
        /// </summary>
        public Bitmap Image1
        {
            get
            {
              
                System.IO.MemoryStream memoryStream1 = new System.IO.MemoryStream();
                foreach (byte b1 in imagebytearray) memoryStream1.WriteByte(b1);
                Image image1 = Image.FromStream(memoryStream1);
                image1.Save(@"Images/" + Title.ToLower() + ".png", System.Drawing.Imaging.ImageFormat.Png);
                Bitmap b = new Bitmap(image1);
                return b;
            }
            set
            {

                System.IO.MemoryStream memoryStream = new System.IO.MemoryStream();
                value.Save(memoryStream, System.Drawing.Imaging.ImageFormat.Png);
                imagebytearray = memoryStream.ToArray();
            }



        }



    }
}
    

