using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.ServiceModel;
namespace Server_Application.Model
{
    class ConnectionForFitness 
    {
      static  Uri serverUri = new Uri(@"http:/localhost:4000/Fitness");
       static BasicHttpBinding binding = new BasicHttpBinding();
        static EndpointAddress endpoint = new EndpointAddress(serverUri);
      public   ServiceHost host = new ServiceHost(typeof(ManagerService));
        public ConnectionForFitness()
        {
            host.AddServiceEndpoint(typeof(IManagerContract), binding, serverUri);
            host.Open();
            
        }
        
    }
}
