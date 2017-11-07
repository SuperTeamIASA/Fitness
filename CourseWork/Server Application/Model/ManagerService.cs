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
            doc.Root.Add(new XElement("aboniments"));
            doc.Root.Add(new XElement("worktimes"));
            doc.Root.Add(new XElement("lessons"));
            doc.Root.Add(new XElement("halls"));
            doc.Root.Add(new XElement("posts"));
            doc.Root.Add(new XElement("emploees"));
            doc.Root.Add(new XElement("trainers"));
            foreach (var n in newsControl.Getnews())
            {
                doc.Root.Element("news").Add(n);
            }
            using (FitnessCenterDBEntities db = new FitnessCenterDBEntities())
            {
                var qwery = from c in db.WorkTimes
                            select c;
                foreach (var item in qwery)
                {
                    doc.Root.Element("worktimes").Add(new XElement("worktime", new XAttribute("worktimeid", item.wtId), new XAttribute("stringf", item.wtname)));
                }
                var qwery1 = from c in db.Aboniments
                             select c;
                foreach (var item in qwery1)
                {
                    doc.Root.Element("aboniments").Add(new XElement("aboniment", new XAttribute("id", item.abonimentId), new XAttribute("description", item.abonimentDescription),
                                                                                new XAttribute("cost", item.abonimentCost), new XAttribute("sale", item.abonimentSale),
                                                                                new XAttribute("pool", item.poolacsess),
                                                                                new XAttribute("groupCount", item.groupCount),
                                                                                new XAttribute("duration", item.abonimentDuration)));
                }
                var qwery2 = from c in db.LessonsType
                             select c;
                foreach (var item in qwery2)
                {
                    doc.Root.Element("lessons").Add(new XElement("lesson",
                                                    new XAttribute("id", item.lessonId),
                                                    new XAttribute("description", item.lessonDescription),
                                                    new XAttribute("name", item.lessonname),
                                                    new XAttribute("groupcost", item.grouplessoncost),
                                                    new XAttribute("individualcost", item.individuallessoncost),
                                                    new XAttribute("duration", item.lessonDurarion)));
                                                                       
                }
                var qwery3 = from c in db.SportHalls
                             select c;
                foreach (var item in qwery3)
                {
                    doc.Root.Element("halls").Add(new XElement("hall",
                                                  new XAttribute("id", item.hallID),
                                                  new XAttribute("description", item.hallDescription),
                                                  new XAttribute("amount", item.hallAmount),
                                                  new XAttribute("image", item.hallimage)));
                }

                var qwery4 = from c in db.Posts
                             select c;
                foreach (var item in qwery4)
                {
                    doc.Root.Element("posts").Add(new XElement("post",
                                                  new XAttribute("id", item.postId),
                                                  new XAttribute("description", item.postDescription),
                                                  new XAttribute("name", item.postName),
                                                  new XAttribute("salary", item.postsalary)));
                }
                var qwery5 = from c in db.Employee
                             select c;
                foreach (var item in qwery5)
                {
                    doc.Root.Element("emploees").Add(new XElement("emp",
                                                     new XAttribute("id", item.employeeId),
                                                     new XAttribute("name", item.empName),
                                                     new XAttribute("lastname", item.emplastName),
                                                     new XAttribute("bdate", item.empBdate),
                                                     new XAttribute("email", item.empEmail),
                                                     new XAttribute("phone", item.empPhone)));
                }
                var qwery6 = from c in db.TrainerInfo
                             select c;
                foreach (var item in qwery6)
                {
                    doc.Root.Element("trainers").Add(new XElement("trainer",
                                                     new XAttribute("trainerId", item.trainerId),
                                                     new XAttribute("empId", item.empid),
                                                     new XAttribute("name", item.Employee.empName),
                                                      new XAttribute("lastname", item.Employee.emplastName),
                                                     new XAttribute("bdate", item.Employee.empBdate),
                                                     new XAttribute("email", item.Employee.empEmail),
                                                     new XAttribute("phone", item.Employee.empPhone),
                                                     new XAttribute("about", item.trainerabout)));
                                            
                }
                
            
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
        public object getShedule(DateTime date)
        {
            using (FitnessCenterDBEntities db = new FitnessCenterDBEntities())
            {
                var qwery = from c in db.GetShedule(date)
                            orderby c.lessontimeId
                            select c;
                foreach (var item in qwery)
                {
                    
                }
            }
                return 0;
        }
    }

}
