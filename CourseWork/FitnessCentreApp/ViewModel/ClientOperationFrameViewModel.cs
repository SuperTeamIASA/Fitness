using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FitnessCentreApp.Infrastructure;
using FitnessCentreApp.Model;
using System.Windows.Input;
namespace FitnessCentreApp.ViewModel
{
    class ClientOperationFrameViewModel : ViewModelBase
    {
        RelayCommand _BuyGroup;
        RelayCommand _BuySinge;
        Channal channel;
        public ClientOperationFrameViewModel()
        {
            channel = Channal.Create();
        }
        public ICommand BuyGroup
        {
            get
            {
                if (_BuyGroup == null)
                    _BuyGroup = new RelayCommand(ExecuteBuyGroup, CanBuyGroup);
                return _BuyGroup;
            }
        }
        
       public  ICommand BuySingle
        {
            get
            {
                if (_BuySinge == null)
                    _BuySinge = new RelayCommand(ExecuteBuySingle, CanBuySingle);
                return _BuySinge;
            }
        }
         FullClientInfo _currentClient;
        ObservableCollection<ShortClientInfo> _clientList;
        public ObservableCollection<ShortClientInfo> clientList
        {
            get
            {
                return _clientList;
            }
            set
            {
                _clientList = value;

            }

        }

        public FullClientInfo ClientInfo
        {
            get
            {
                return _currentClient;
            }
            set
            {
                _currentClient = value;
            }
        }
        string _nameSearch;
        string _lastnameSearch;
        public   string NameSearch
        {
            get
            {
                return _nameSearch;
            }
            set
            {
                _nameSearch = value;
                OnPropertyChanged("NameSearch");
               clientList = new ObservableCollection<ShortClientInfo>( channel.channal.GetShortClientInfo(NameSearch, LastNameSearch));
            }
        }
        public   string LastNameSearch
        {
            get
            {
                return _lastnameSearch;
            }
            set
            {
                _lastnameSearch = value;
                OnPropertyChanged("LastNameSearch");
                clientList = new ObservableCollection<ShortClientInfo>(channel.channal.GetShortClientInfo(NameSearch, LastNameSearch));
            }
        }
        int selectedclient;
        public  int SelectedClient
        {
            get
            {
                return selectedclient;
            }
            set
            {
                selectedclient = value;
                OnPropertyChanged("SelectedClient");
                ClientInfo = channel.channal.GetClient(clientList[SelectedClient].ID);


            }
        }

        private bool CanBuySingle(object obj)
        {
            throw new NotImplementedException();
        }

        private void ExecuteBuySingle(object obj)
        {
            throw new NotImplementedException();
        }

        private bool CanBuyGroup(object obj)
        {
            throw new NotImplementedException();
        }

        private void ExecuteBuyGroup(object obj)
        {
            throw new NotImplementedException();
        }
    }
}
