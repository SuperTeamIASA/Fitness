using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace Server_Application.Model
{
    class ClientConnection : IDisposable
    {
        static Uri serverUri = new Uri(@"http:/localhost:4000/Client");
        static BasicHttpBinding binding = new BasicHttpBinding();
        static EndpointAddress endpoint = new EndpointAddress(serverUri);
        ServiceHost host = new ServiceHost(typeof(ClientService));
       
        public ClientConnection()
        {
            host.AddServiceEndpoint(typeof(IClientContract), binding, serverUri);
            host.Open();
        }

        public void Dispose()
        {
            host.Close();
        }
    }
}
