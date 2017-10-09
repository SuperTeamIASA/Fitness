using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Server_Application.Infrastructure;
using System.Windows.Input;
using Server_Application.Model;
using System.ComponentModel;
using System.ServiceModel;
namespace Server_Application.ViewModel
{
    class MainWindowViewModel : ViewModelBase
    {
        ServiceHost host = null;
        List<string> LogList = new List<string>();
        string ImageSource { get; set; }
        string ImageSource1 { get; set; }
        int ClientCount { get; set; }
        int StandbyTime { get; set; }
         RelayCommand _StartServer;
        RelayCommand _ReloadServer;
        RelayCommand _TurnOffServer;
     //   ConnectionForFitness con;
     
        public ICommand StartServer 
        {
            get
            {
                if (_StartServer == null)
                    _StartServer = new RelayCommand(ExecuteStartServer,CanStartServer);
                return _StartServer;
            }
        }
        public ICommand ReloadServer
        {
            get
            {
                if (_ReloadServer == null)
                    _ReloadServer = new RelayCommand(ExecuteReloadCommand, CanExecuteReloadServerComd);
                return _ReloadServer;
            }
        }
        public ICommand TurnOffServer
        {
            get
            {
                if (_TurnOffServer == null)
                    _TurnOffServer = new RelayCommand(ExecuteTurnOffCommand, CanExecuteTurnOffServerComd);
                return _TurnOffServer;
            }
        }
        public void  ExecuteStartServer(object parament)
        {
            if (host == null)
            {
                host = new ServiceHost(typeof(ManagerService), new Uri("http://localhost:4000/Fitness"));
                host.AddServiceEndpoint(typeof(IManagerContract), new BasicHttpBinding(), " ");
                host.Open();
                LogList.Add("Server started" + DateTime.Now);
            }
        }
        public bool CanStartServer(object parament)
        {
            return true;
        }
        public void ExecuteReloadCommand(object parament)
        {

        }
        public bool CanExecuteReloadServerComd(object parament)
        {
            return true;
        }
        public void ExecuteTurnOffCommand(object parament)
        {
            if (host != null)
                host.Close();
        }
        public bool CanExecuteTurnOffServerComd(object parament)
        {
            return true;
        }
        protected override void OnDispose()
        {
            base.OnDispose();
        }

    }
}
