using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Xml.Linq;
using System.Text;
using Server_Application.Properties;
using System.Threading.Tasks;

namespace Server_Application.Model
{
    static   class newsControl
    {
      static  string dirpath;
         static newsControl()
        {
            dirpath = (Directory.CreateDirectory(AppDomain.CurrentDomain.BaseDirectory + "/News")).FullName;

        }
    public    static IEnumerable<XElement> Getnews()
        {
            DirectoryInfo dir = new DirectoryInfo(dirpath);
            foreach (var a in dir.GetFiles("*.xml", SearchOption.TopDirectoryOnly))
                 {
                XDocument doc = XDocument.Load(a.FullName);
                yield return doc.Root;
               
            }
            
            
            
        }
      public  static void AddNew(New _new)
        {
            Settings.Default.newCurrentId++;
            XDocument doc = new XDocument( new XElement("new", 
                new XAttribute("id", Settings.Default.newCurrentId),
                new XAttribute("Title", _new.Title),
                new XAttribute("Text", _new.NewText),
                new XAttribute("Image", _new.imagename)));
            doc.Save(dirpath + "/new" + Settings.Default.newCurrentId + ".xml");
        }
    public    static void ChangeNew(New news)
        {
            XDocument doc = XDocument.Load(dirpath + "/new" + news.NewsId + ".xml");
            doc.Root.Attribute("Title").Value = news.Title;
            doc.Root.Attribute("Text").Value = news.NewText;
            doc.Root.Attribute("Image").Value = news.imagename;

            doc.Save(dirpath + "/new" + news.NewsId + ".xml");
        }
        public static void DeleteNew(New news)
        {
            File.Delete(dirpath + "/new" + news.NewsId + ".xml");
        }

    }
}
