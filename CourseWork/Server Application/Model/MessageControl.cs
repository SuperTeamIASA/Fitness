using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Linq;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server_Application.Model
{
   static class MessageControl
    {
        static string dirpath;
        static MessageControl()
        {
            dirpath = (Directory.CreateDirectory(AppDomain.CurrentDomain.BaseDirectory + "/Message")).FullName;
        }

        static IEnumerator<XElement> GetMessage(int chatuserId)
        {
            XDocument doc = XDocument.Load(dirpath + "/" + chatuserId + ".xml");
            foreach(var a in doc.Root.Elements())
            {
                yield return a;
            }
            
        }
        static void AddMessageStory(int chatuserId)
        {
            XDocument doc = new XDocument(new XElement("chatuser", new XAttribute("userid", chatuserId)));
            doc.Save(dirpath + "/" + chatuserId + ".xml");
        }
        static void AddMessage(int chatuserId, MessageClass mess)
        {
            if (!Directory.GetFiles(dirpath).Contains(dirpath + "/" + chatuserId + ".xml"))
                AddMessageStory(chatuserId);
                XDocument doc = XDocument.Load(dirpath + "/" + chatuserId + ".xml");
            doc.Root.Add(new XElement("message",
                new XAttribute("Autor", mess._autor),
                new XAttribute("Body", mess.MessageText),
                new XAttribute("Data", mess.Data),
                new XAttribute("Time", mess.Timeofmessage)));
            doc.Save(dirpath + "/" + chatuserId + ".xml");
        }
        
    }
}
