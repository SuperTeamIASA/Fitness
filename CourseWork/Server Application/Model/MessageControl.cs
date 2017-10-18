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

     public   static IEnumerable<XElement> GetMessage(int chatuserId)
        {
            XDocument doc = XDocument.Load(dirpath + "/" + chatuserId + ".xml");
            foreach(var a in doc.Root.Elements())
            {
                yield return a;
            }
            
        }
      public  static void AddMessageStory(int chatuserId)
        {
            XDocument doc = new XDocument(new XElement("chatuser", new XAttribute("userid", chatuserId)));
            doc.Save(dirpath + "/" + chatuserId + ".xml");
            
        }
       public  static void AddMessage(int chatuserId, MessageClass mess)
        {
            if (!Directory.GetFiles(dirpath).Contains(dirpath + "/" + chatuserId + ".xml"))
                AddMessageStory(chatuserId);
                XDocument doc = XDocument.Load(dirpath + "/" + chatuserId + ".xml");
            doc.Root.Add(new XElement("message",
                new XAttribute("Autor", mess._autor),
                new XAttribute("Body", mess.MessageText),
                new XAttribute("DataTime", mess.Timeofmessage.ToString())));
               
            doc.Save(dirpath + "/" + chatuserId + ".xml");
        }
              
     public   static IEnumerable<MessageClass> GetMessageHistory(int chatuserId)
        {
            if (!Directory.GetFiles(dirpath).Contains(dirpath + "/" + chatuserId + ".xml"))
                AddMessageStory(chatuserId);
            XDocument doc = XDocument.Load(dirpath + "/" + chatuserId + ".xml");
           foreach(var a in doc.Root.Elements())
            {
                MessageClass mc = new MessageClass();
                mc.MessageText = a.Attribute("Body").Value;
                mc._autor = (a.Attribute("Autor").Value == "Admin") ? 0 : 1;
                mc.Timeofmessage = DateTime.Parse(a.Attribute("DateTime").Value);
                yield return mc;
            }


        }
        public static IEnumerable<ChatUser> GetChatUsers()
        {

            List<int> usersId = new List<int>();
            foreach (var item in Directory.GetFiles(dirpath))
            {
                string s = string.Empty;
                for(int i=item.Length-5; ; i--)
                {
                    if (item[i] == '/')
                        break;
                    s += item[i];
                }
                s = new string(s.ToCharArray().Reverse().ToArray());
                usersId.Add(Int32.Parse(s));
                                 
            }
            using (FitnessCenterDBEntities db = new FitnessCenterDBEntities())
            {
                var qwery = from c in db.Customers
                            where usersId.Contains(c.customerId)
                            select c;
                foreach(var a in qwery)
                {
                    ChatUser CU = new ChatUser() { Name = a.name, Surname = a.lastname, userId = a.customerId };
                    yield return CU;
                }
            }
        }
    }
}
