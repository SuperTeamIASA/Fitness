﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessCentreApp.Model
{
  static  class ImageControl
    {
        static string dirpath;
        static ImageControl()
        {
            dirpath = Directory.CreateDirectory(AppDomain.CurrentDomain.BaseDirectory + "/Images").FullName;
        }
        public static byte[] ImageToByte(string path)
        {
            try
            {
                FileInfo a = new FileInfo(path);
                a.CopyTo(dirpath + "/" + a.Name);
                System.Drawing.Imaging.ImageFormat e;
                switch (path.Split('.')[1])
                {
                    case "jpg": e = System.Drawing.Imaging.ImageFormat.Jpeg; break;
                    case "png": e = System.Drawing.Imaging.ImageFormat.Png; break;
                    case "gif": e = System.Drawing.Imaging.ImageFormat.Gif; break;
                    default: e = System.Drawing.Imaging.ImageFormat.Bmp; break;

                }


                System.IO.MemoryStream memoryStream = new System.IO.MemoryStream();
                System.Drawing.Bitmap.FromFile(path).Save(memoryStream, e);
                return memoryStream.ToArray();
            }
            catch (Exception)
            {
                return null;
            }

        }
        public static void ByteToImage(byte[] array, string name)
        {
            System.IO.MemoryStream memoryStream1 = new System.IO.MemoryStream();
            foreach (byte b1 in array) memoryStream1.WriteByte(b1);

            string s = name.Split('.')[1];
            System.Drawing.Imaging.ImageFormat e;
            switch (s)
            {
                case "jpg": e = System.Drawing.Imaging.ImageFormat.Jpeg; break;
                case "png": e = System.Drawing.Imaging.ImageFormat.Png; break;
                case "gif": e = System.Drawing.Imaging.ImageFormat.Gif; break;
                default: e = System.Drawing.Imaging.ImageFormat.Bmp; break;

            }


            System.Drawing.Image image1 = System.Drawing.Image.FromStream(memoryStream1);
            image1.Save(dirpath + "/" + name, e);
            memoryStream1.Close();


        }
        
    }
}
