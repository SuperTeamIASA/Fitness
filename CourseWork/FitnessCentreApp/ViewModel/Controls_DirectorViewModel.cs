using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FitnessCentreApp.Infrastructure;
using System.Windows.Input;
using FitnessCentreApp.View;
namespace FitnessCentreApp.ViewModel
{
    class Controls_DirectorViewModel : ViewModelBase
    {
        RelayCommand _AdministratorMode;
        RelayCommand _EmployeeSets;
        RelayCommand _PostSets;
        RelayCommand _Accounting;
        RelayCommand _AbonimetsCommand;
    public     ICommand AdminModeCommand
        {
            get
            {
                if (_AdministratorMode == null)
                    _AdministratorMode = new RelayCommand(ExecuteAdminMode, CanAdminMode);
                return _AdministratorMode;
            }
        }
       public  ICommand EmployySetsCommand
        {
            get
            {
                if (_EmployeeSets == null)
                    _EmployeeSets = new RelayCommand(ExecuteEmloyeeSets, CanEmployeeSets);
                return _EmployeeSets;
            }
        }
      public   ICommand PostSetsCommand
        {
            get
            {
                if (_PostSets == null)
                    _PostSets = new RelayCommand(ExecutePostSets, CanPostSets);
                return _PostSets;
            }
        }
      public   ICommand AccountingCommand
        {
            get
            {
                if (_Accounting == null)
                    _Accounting = new RelayCommand(ExecuteAccounting, CanAccounting);
                return _Accounting;
            }
        }
        public ICommand AbonimetsCommand
        {
            get
            {
                if (_AbonimetsCommand == null)
                    _AbonimetsCommand = new RelayCommand(Executeabons, CanAbons);
                return _AbonimetsCommand;
            }
        }

        private bool CanAbons(object obj)
        {
            return true;
        }

        private void Executeabons(object obj)
        {
            (App.Current.MainWindow.DataContext as MainWindowViewModel).MainFrame = new AbonimentsChanges();
        }

        void ExecuteAdminMode(object o)
        {
            (App.Current.MainWindow.DataContext as MainWindowViewModel).Controls  = new Controls_Admin();
            (App.Current.MainWindow.DataContext as MainWindowViewModel).MainFrame = new DefaultAdminFrame();
        }
        bool CanAdminMode(object o)
        {
            return true;
        }
        void ExecuteEmloyeeSets(object o)
        {
            (App.Current.MainWindow.DataContext as MainWindowViewModel).MainFrame = new EmployeeSettingFrame();
        }
        bool CanEmployeeSets(object o)
        {
            return true;
        }
        void ExecutePostSets(object o)
        {
            (App.Current.MainWindow.DataContext as MainWindowViewModel).MainFrame = new PostSettingFrame();
        }
        bool CanPostSets(object o)
        {
            return true;
        }
        void ExecuteAccounting(object o)
        {
            (App.Current.MainWindow.DataContext as MainWindowViewModel).MainFrame = new IncomeCashFrame();
        }
        bool CanAccounting(object o )
        {
            return true;
        }
    }
}
