﻿using System;
using System.Collections.Generic;
using System.IO;
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
        [DataMember]
        public string Gender { get; set; }
        [DataMember]
        public string information { get; set; }
        [DataMember]
        string image { get; set; }
        public string Image
        {
            get
            {
                try
                {
                    File.Open(AppDomain.CurrentDomain.BaseDirectory + "/Image/" + image, FileMode.Open);
                    return AppDomain.CurrentDomain.BaseDirectory + "/Image/" + image;
                }
                catch (FileNotFoundException)
                {
                    ImageControl.ByteToImage(Channal.Create().channal.GetImage(image), image);
                    return AppDomain.CurrentDomain.BaseDirectory + "/Image/" + image;
                }
            }
        }
     
        public Aboniment AbonimentInfo { get; set; }

    }
}
