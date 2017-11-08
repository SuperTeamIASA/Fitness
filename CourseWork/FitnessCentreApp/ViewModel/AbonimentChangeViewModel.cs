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
    class AbonimentChangeViewModel : ViewModelBase
    {
        //TODO Do it ViewModel and View
        Channal channel;
        RelayCommand _add;
        RelayCommand _delete;
        RelayCommand _change;
        public ICommand Add
        {
            get
            {
                if (_add == null)
                    _add = new RelayCommand(AddExecute, CanAdd);
                return _add;
            }
        }

        private bool CanAdd(object obj)
        {
            return true; //TODO Проверка на звполнение строк
        }

        private void AddExecute(object obj)
        {
            channel.channal.AddAboniment(AbonimentInfo);
            AbonimentInfo = new Aboniment();
        }

        public    ICommand Change
        {
            get
            {
                if (_change == null)
                    _change = new RelayCommand(ChangeExecute, CanChange);
                return _change;
            }
        }

        private bool CanChange(object obj)
        {
            throw new NotImplementedException();
        }

        private void ChangeExecute(object obj)
        {
            channel.channal.ChangeAboniment(AbonimentList[SelectedAboniment].abonID,AbonimentInfo);
            AbonimentInfo = new Aboniment();
        }

        public    ICommand Delete
        {
            get
            {
                if (_delete == null)
                    _delete = new RelayCommand(DeleteExecute, CanDelete);
                return _delete;
            }
        }

        private bool CanDelete(object obj)
        {
            return true;
        }

        private void DeleteExecute(object obj)
        {
            channel.channal.DeleteAboniment(AbonimentList[SelectedAboniment].abonID);
            AbonimentList.RemoveAt(SelectedAboniment);
        }

        public AbonimentChangeViewModel()
        {
            channel = Channal.Create();
        }

        ObservableCollection<Aboniment> _abonimentList;
        public ObservableCollection<Aboniment> AbonimentList
        {
            get
            {
                if (_abonimentList == null)
                {
                    XDocument doc = XDocument.Load(AppDomain.CurrentDomain.BaseDirectory + "/sesion.xml");
                    _abonimentList = new ObservableCollection<Aboniment>();
                    foreach (var item in doc.Root.Element("aboniments").Elements())
                    {
                        _abonimentList.Add(new Aboniment()
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
                return _abonimentList;
            }
            set
            {
                _abonimentList = value;

            }

        }
        Aboniment _currentAboniment;
        public Aboniment AbonimentInfo
        {
            get
            {   if (_currentAboniment == null)
                    _currentAboniment = new Aboniment();
                return _currentAboniment;
            }
            set
            {
                _currentAboniment = value;
                OnPropertyChanged("AbonimentInfo");
            }
        }

        int _selectedAboniment;
        public int SelectedAboniment
        {
            get
            {
                return _selectedAboniment;
            }
            set
            {
                _selectedAboniment = value;
                OnPropertyChanged("SelectedAboniment");
                AbonimentInfo = AbonimentList[_selectedAboniment];
            }
        }
    }
}
