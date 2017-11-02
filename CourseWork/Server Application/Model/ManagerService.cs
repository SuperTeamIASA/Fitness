using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Net.Mail;
using System.IO;
using System.Net;
using System.ServiceModel;
using System.Xml.Linq;
using Server_Application.ViewModel;
namespace Server_Application.Model
{
    
    class ManagerService : IManagerContract,IDisposable
    {
        public static int CountManagers { get { return CountManagers; } set { CountManagers = value; } }
        public ManagerService()
        {
            MainWindowViewModel.adminonline = true;
        }
        public void AddNew(New news)
        {
            newsControl.AddNew(news);
        }

        public int AddNewClient(Client client)
        {

            try
            {
                using (FitnessCenterDBEntities db = new FitnessCenterDBEntities())
                {
                    Random rand = new Random();
                    int pass = rand.Next(100000, 999999);
                    
                    db.AddClient(client.Name, client.Surname, client.Email, pass.ToString());
                    
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
                    db.AddCustomerInfo(q.First(), string.Empty, null, string.Empty, null, client.Phone, string.Empty, string.Empty);
                 
                    db.SaveChanges();
                    return 0;
                }
            }
            catch (Exception)
            {
                return 1;
            }
          }
            
        private string ToNormPhome(string phone)
        {
            int[] phoneInt = new int[10];
            int i = 0;
            foreach (var c in phone)
            {
                if (Char.IsDigit(c))
                {
                    phoneInt[i] = (int)Char.GetNumericValue(c);
                }
            }
            string s = "(";
            for (int ij = 0; ij < 3; ij++)
                s += phoneInt[i];
            s += ")";
            for (int ij = 3; ij < phoneInt.Length; ij++)
                s += phoneInt[i];
            return s;

        }            

        public void DeleteNew(New news)
        {
            newsControl.DeleteNew(news);
        }

        public void Dispose()
        {
            MainWindowViewModel.adminonline = false;
        }

        public ChatUser[] GetChatUsers()
        {
            return MessageControl.GetChatUsers().ToArray();
        }

        public MessageClass[] GetMessage(ChatUser user)
        {
           return MessageControl.GetMessageHistory(user.userId).ToArray<MessageClass>();
           
        }
        
        public byte[] getsession()
        {
            try
            {
                File.Delete(AppDomain.CurrentDomain.BaseDirectory + "/sesion.xml");
            }
            catch(FileNotFoundException)
            {

            }            
            XDocument doc = new XDocument(new XElement("sesion"));
            doc.Root.Add(new XElement("news"));
            doc.Root.Add(new XElement("messages"));
            foreach (var n in newsControl.Getnews())
            {
                doc.Root.Element("news").Add(n);
            }
            doc.Save(AppDomain.CurrentDomain.BaseDirectory + "/sesion.xml");
            FileStream fs = new FileStream(AppDomain.CurrentDomain.BaseDirectory + "/sesion.xml", FileMode.Open);            
            byte[] array = new byte[fs.Length];
            fs.Read(array, 0, (int)fs.Length);
            fs.Close();
            return array;
        }

        public void SendMessade(ChatUser user, MessageClass message)
        {
            MessageControl.AddMessage(user.userId, message);
        }

        public void SendImage(string name, byte[] array)
        {
            ImageControl.SaveImage(array, name);
        }

        public byte[] GetImage(string name)
        {
           return ImageControl.GetImage(name);
        }

        public FullClientInfo GetClient(int Id)
        {
            using (FitnessCenterDBEntities db = new FitnessCenterDBEntities())
            {
                var qwery = from c in db.Customers
                            where c.customerId == Id
                            select c;
                FullClientInfo cc = new FullClientInfo();
                foreach (var item in qwery)
                {
                    cc = new FullClientInfo()
                    {
                        Email = item.email,
                        Name = item.name,
                        Surname = item.lastname,
                        Phone = item.CustomerInfo.First().Phone,
                        City = item.CustomerInfo.First().city,
                        Adress = item.CustomerInfo.First().adress,
                        information = item.CustomerInfo.First().detailinfo,
                        Gender = (item.CustomerInfo.First().sex).Value ? "Мужчина" : "Женщина",
                        image = item.CustomerInfo.First().userimage,
                        bdate = (DateTime)item.CustomerInfo.First().bdate,
                        AbonimentInfo = new Aboniment()
                        {
                            abonID = (int)item.AbonimentsWithClient.First().abonimentId,
                            selldata = (DateTime)item.AbonimentsWithClient.First().selldate,
                            groupcount = (int)item.AbonimentsWithClient.First().externgroup
                        }
                    };
                        
                        
                    
                }
                return cc;
            }
        }

        public ShortClientInfo[] GetShortClientInfo(string name, string lastname)
        {
            using (FitnessCenterDBEntities db = new FitnessCenterDBEntities())
            {
                List<ShortClientInfo> list = new List<ShortClientInfo>();
                var qwery = from c in db.GETClientsByName(name, lastname)
                            select c;
                foreach (var item in qwery)
                {
                    list.Add(new ShortClientInfo() { ID = item.customerId, Name = item.name, Surname = item.pass });
                }
                return list.ToArray();
            }
        }
    }

}
