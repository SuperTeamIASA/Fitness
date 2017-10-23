using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace FitnessCentreApp.Model
{/// <summary>
/// Клас создает канал передачи данных на сервер по http протоколу
/// </summary>
    class Channal :IDisposable //реализовано по патерну Одиночка
    {
        private static Channal _Channal;
        Uri address = new Uri("http://localhost:4000/Fitness");
        EndpointAddress endpoint;
        BasicHttpBinding binding;
        ChannelFactory<IManagerContract> factory;
        public IManagerContract channal;
        protected Channal()
        {
            binding = new BasicHttpBinding();
            endpoint = new EndpointAddress(address);
            factory = new ChannelFactory<IManagerContract>(binding, endpoint);
            channal = factory.CreateChannel();
            var f =  channal.getsession();
            FileStream fs = new FileStream(AppDomain.CurrentDomain.BaseDirectory + "/sesion.xml", FileMode.Create);
            fs.Write(f,0,f.Length);
            fs.Close();
            
        }
        public static Channal Create()
        {
            if (_Channal==null)
            {
                _Channal = new Channal();
            }
            return _Channal;
        }

        public void Dispose()
        {
            factory.Close();
        }
    }
}
