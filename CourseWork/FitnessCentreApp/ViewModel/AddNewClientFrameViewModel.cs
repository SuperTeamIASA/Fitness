using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FitnessCentreApp.Infrastructure;
using System.Windows.Input;
using FitnessCentreApp.Properties;
using FitnessCentreApp.Model;
namespace FitnessCentreApp.ViewModel
{
    class AddNewClientFrameViewModel : ViewModelBase
    {
        Client _currentClient;
        Channal channal;
        string _result;
        public AddNewClientFrameViewModel()
        {
            channal = Channal.Create();
        }
        public Client CurrentClient
        {
            get
            {
                if (_currentClient == null)
                    _currentClient = new Client();
                return _currentClient;
            }
            set
            {
                _currentClient = value;
                OnPropertyChanged("CurrentClient");
            }
        }
        public string Result
        {
            get
            {
                return _result;
            }
            set
            {
                _result = value;
                OnPropertyChanged("Result");
            }
        }

        RelayCommand _AddClient;
        RelayCommand _DeleteRow;
        public ICommand AddClientCommand
        {
            get
            {
                if (_AddClient == null)
                    _AddClient = new RelayCommand(ExecuteAddClient, CanAddClient);
                return _AddClient;
            }
        }
        public ICommand DeleteRowCommand
        {
            get
            {
                if (_DeleteRow == null)
                    _DeleteRow = new RelayCommand(ExecuteDeleteRow, CanDeleteRow);
                return _DeleteRow;
            }
        }

        private bool CanDeleteRow(object obj)
        {
            if (!string.IsNullOrEmpty(CurrentClient.Name) ||
                !string.IsNullOrEmpty(CurrentClient.Surname) || !string.IsNullOrEmpty(CurrentClient.Email) || !string.IsNullOrEmpty(CurrentClient.Phone))
                return true;
            return false;
        }

        private void ExecuteDeleteRow(object obj)
        {
            _currentClient = null;
            //CurrentClient.Name = String.Empty;
            //CurrentClient.Surname = String.Empty;
            //CurrentClient.Email = String.Empty;
            //CurrentClient.Phone = String.Empty;
            Result = String.Empty;
        }

        private bool CanAddClient(object obj)
        {
            if (string.IsNullOrEmpty(CurrentClient.Name) ||
               string.IsNullOrEmpty(CurrentClient.Surname) || string.IsNullOrEmpty(CurrentClient.Email) || string.IsNullOrEmpty(CurrentClient.Phone))
                return false;
            return true;
        }

        private void ExecuteAddClient(object obj)
        {
            int res = channal.channal.AddNewClient(CurrentClient);
            if (res == 0)
                {
                ExecuteDeleteRow(obj);
                Result = Resources.AddGoodResult;
                }
        }

    }
}
