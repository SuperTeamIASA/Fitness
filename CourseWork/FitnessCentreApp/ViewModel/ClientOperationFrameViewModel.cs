using System;
using System.Collections.Generic;
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

        public   string NameSearch
        {
            get; set;
        }
        public   string LastNameSearch
        {
            get;
            set;
        }
        public  int SelectedClient { get; set; }
       

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
