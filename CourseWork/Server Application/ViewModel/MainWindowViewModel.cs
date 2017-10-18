using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using Server_Application.Infrastructure;
using System.Windows.Input;
using Server_Application.Model;
using System.ComponentModel;
using Server_Application.Properties;
using System.ServiceModel;


namespace Server_Application.ViewModel
{
    class MainWindowViewModel : ViewModelBase
    {
        static string offline = AppDomain.CurrentDomain.BaseDirectory + "/Images/ofline.png";
        static string online = AppDomain.CurrentDomain.BaseDirectory + "/Images/online.png";
        string img1;
        string img2;
     
        ServiceHost host = null;
        bool ServerWorking;
        public static bool adminonline
        {
            get
            {
                return adminonline;
            }
            set
            {
                adminonline = value;
                if (value)
                    ((MainWindowViewModel)App.Current.MainWindow.DataContext).ImageSource1 = online;
                else
                ((MainWindowViewModel)App.Current.MainWindow.DataContext).ImageSource1 = offline;
            }
        }
        
        ObservableCollection<string> log;
        public ObservableCollection<string> LogList
        {
            get
            {
                if (log == null)
                    log = new ObservableCollection<string>();
                return log;   
            }
            set
            {
                log = value;
                OnPropertyChanged("Loglist");
            }
        }
        public  string ImageSource {
            get
            {
                if (string.IsNullOrEmpty(img1))
                    img1 = offline;
                return img1;
            }
            set
            {
                img1 = value;
                OnPropertyChanged("ImageSource");
            }

        }    
        public string ImageSource1
        {
            get
            {
                if (string.IsNullOrEmpty(img2))
                    img2 = offline;
               
                return img2;
               
            }
            set
            {
                img2 = value;
                OnPropertyChanged("ImageSource1");
            }
        }
        public   int ClientCount { get; set; }
        public   int StandbyTime { get; set; }
        RelayCommand _StartServer;
        RelayCommand _ReloadServer;
        RelayCommand _TurnOffServer;
       
        public ICommand StartServer
        {
            get
            {
                if (_StartServer == null)
                    _StartServer = new RelayCommand(ExecuteStartServer, CanStartServer);
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
        public void ExecuteStartServer(object parament)
        {
            if (host == null)
            {
                host = new ServiceHost(typeof(ManagerService), new Uri("http://localhost:4000/Fitness"));
                host.AddServiceEndpoint(typeof(IManagerContract), new BasicHttpBinding(), " ");
                host.Open();

                LogList.Add(DateTime.Now + ": " + "Server started");
                ServerWorking = true;
                ImageSource = online;
                
                
            }
        }
        public bool CanStartServer(object parament)
        {
            return !ServerWorking;
        }
        public void ExecuteReloadCommand(object parament)
        {
            ExecuteTurnOffCommand(1);
            ExecuteStartServer(1);
        }
        public bool CanExecuteReloadServerComd(object parament)
        {
            return ServerWorking;
        }
        public void ExecuteTurnOffCommand(object parament)
        {
            if (host != null)
            {
                
                host.Close();
                LogList.Add( DateTime.Now + ": " + "Server stopped" );
                ServerWorking = false;
                ImageSource = offline;
            }
        }
        public bool CanExecuteTurnOffServerComd(object parament)
        {
            if (ServerWorking)
                return true;
            else return false;
        }
        protected override void OnDispose()
        {
            base.OnDispose();
        }

    }
   public class Log
    {
        public string log { get; set; }
        public override string ToString()
        {
            return log;
        }
    }
}

