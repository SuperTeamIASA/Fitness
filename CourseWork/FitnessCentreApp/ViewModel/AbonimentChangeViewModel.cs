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
    class AbonimentChangeViewModel : ViewModelBase
    {
        //TODO Do it ViewModel and View
        Channal channel;
        public AbonimentChangeViewModel()
        {
            channel = Channal.Create();
        }

        ObservableCollection<Aboniment> _abonimentList;
        public ObservableCollection<Aboniment> AbonimentList
        {
            get
            {
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
            {
                return _currentAboniment;
            }
            set
            {
                _currentAboniment = value;
            }
        }

        int selectedAboniment;
        public int SelectedAboniment
        {
            get
            {
                return selectedAboniment;
            }
            set
            {
                selectedAboniment = value;
                OnPropertyChanged("SelectedAboniment");
                //AbonimentInfo = channel.channal.Get(AbonimentList[SelectedAboniment].abonID);
            }
        }
    }
}
