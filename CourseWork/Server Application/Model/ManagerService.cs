using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Net.Mail;
using System.IO;
using System.Net;
using System.Xml.Linq;

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

            try
            {
                using (FitnessCenterDBEntities db = new FitnessCenterDBEntities())
                {
                    Random rand = new Random();
                    int pass = rand.Next(100000, 999999);
                    Customers client1 = new Customers() { name = client.Name, email = client.Email, lastname = client.Surname, pass = pass.ToString() };
                    db.Customers.Add(client1);
                    db.SaveChanges();
                    MailAddress address = new MailAddress("vladkoval0@gmail.com", "Fitness Center");
                    MailAddress to = new MailAddress(client.Email);
                    MailMessage m = new MailMessage(address, to);
                    m.Subject = "Добро пожаловать в наш фитнес центр";
                    m.IsBodyHtml = true;
                    m.Body = "<h2> Поздравляем " + client.Name + ", вы зарегистрировались как клиент нашего фитнес клуба</h2><p> Ваш логин: " + client.Email + "<p> Пароль: " + pass + "<p> Возпользуйтесь этими данними для доступа к персональному акаунта в нашем приложении <p><p> Приложение можно сказать по ссылке ....<p>";
                    SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
                    
                    smtp.Credentials = new NetworkCredential("vladkoval0@gmail.com", "Vlad1798");
                    smtp.EnableSsl = true;
                    smtp.Send(m);
                    var q = from c in db.Customers
                            where c.email == client.Email
                            select c.customerId;
                    CustomerInfo ci = new CustomerInfo() { Phone = client.Phone, customerId = q.First() };
                    
                    db.CustomerInfo.Add(ci);
                    db.SaveChanges();
                    return 0;
                }
            }
            catch (Exception)
            {
                return 1;
            }
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
