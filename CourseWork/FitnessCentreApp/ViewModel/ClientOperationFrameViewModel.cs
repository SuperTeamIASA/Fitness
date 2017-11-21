using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FitnessCentreApp.Infrastructure;
using FitnessCentreApp.Model;
using System.Windows.Input;
using System.Xml.Linq;

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
        int _extergroup;
        public int ExterngroupCount
        {
            get
            {
                return _extergroup;
            }
            set
            {
                _extergroup = value;
                OnPropertyChanged("ExterngroupCount");
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
        ObservableCollection<Aboniment> _abonlist;
        public ObservableCollection<Aboniment> AbonimentsList
        {
            get
            {
                if (_abonlist == null)
                {

                    XDocument doc = XDocument.Load(AppDomain.CurrentDomain.BaseDirectory + "/sesion.xml");
                    _abonlist = new ObservableCollection<Aboniment>();
                    foreach (var item in doc.Root.Element("aboniments").Elements())
                    {
                        _abonlist.Add(new Aboniment()
                        {
                            abonID = int.Parse(item.Attribute("id").Value),
                            description = item.Attribute("description").Value,
                            cost = double.Parse(item.Attribute("cost").Value),
                            sale = double.Parse(item.Attribute("sale").Value),
                            pool = bool.Parse(item.Attribute("pool").Value),
                            groupcount = int.Parse(item.Attribute("groupCount").Value),
                            duration = int.Parse(item.Attribute("duration").Value),
                            name = item.Attribute("name").Value
                        });
                    }


                }
                return _abonlist;

            }
            set
            {
                _abonlist = value;
            }
           
        }
        ObservableCollection<Lessons> _lessons;
        public ObservableCollection<Lessons> LessonList
        {
            get
            {
                if(_lessons==null)
                {
                    XDocument doc = XDocument.Load(AppDomain.CurrentDomain.BaseDirectory + "/sesion.xml");
                    _lessons = new ObservableCollection<Lessons>();
                    foreach (var item in doc.Root.Element("lessons").Elements())
                    {
                        _lessons.Add(new Lessons()
                        {
                            lessonid = int.Parse(item.Attribute("id").Value),
                            name = item.Attribute("name").Value,
                            description = item.Attribute("description").Value,
                            duration = int.Parse(item.Attribute("duration").Value),
                            groupcost = decimal.Parse(item.Attribute("groupcost").Value),
                            indivcost = decimal.Parse(item.Attribute("individualcost").Value)
                        });
                    }
                }
                return _lessons;
            }
            set
            {
                _lessons = value;
            }
        }

    }
}
