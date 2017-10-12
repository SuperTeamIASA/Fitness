using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Server_Application.Model
{
    class ManagerService : IManagerContract
    {
        public void AddNew(New news)
        {
           
            throw new NotImplementedException();
        }

        public int AddNewClient(Client client)
        {
            return 0;
        }

        public void DeleteNew(New news)
        {
            throw new NotImplementedException();
        }

        public ChatUser[] GetChatUsers()
        {
            throw new NotImplementedException();
        }

        public MessageClass[] GetMessage(ChatUser user)
        {
            throw new NotImplementedException();
        }

        public New[] GetNews()
        {
            List<New> list = new List<New>();
            list.Add(new New() { Title = "Заголовок", NewText = "много много текса", Image1 = "twitter.png" });
            list.Add(new New() { Title = "Заголовок1", NewText = "много много текса22221112", Image1 = "twitter.png" });
            return list.ToArray();
        }

        public byte[] getsession()
        {
            FileStream fs = new FileStream(@"C:\Users\vladk\documents\visual studio 2015\Projects\CourseWork\Server Application\Model\q.xml", FileMode.Open);
            byte[] array = new byte[10000];
            fs.Read(array, 0, 10000);
            fs.Close();
            return array;
        }

        public void SendMessade(ChatUser user, MessageClass message)
        {
            throw new NotImplementedException();
        }
    }
}
