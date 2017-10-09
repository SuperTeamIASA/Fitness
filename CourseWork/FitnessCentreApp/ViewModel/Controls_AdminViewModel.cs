using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FitnessCentreApp.Infrastructure;
using System.Windows.Input;
using FitnessCentreApp.View;
using System.Windows.Controls;
namespace FitnessCentreApp.ViewModel
{
    class Controls_AdminViewModel : ViewModelBase
    {
        RelayCommand _DirectorMode;
        RelayCommand _AddNewClient;
        RelayCommand _OperationsClient;
        RelayCommand _Schedule;
        RelayCommand _News;
        RelayCommand _Chat;
    public   ICommand DirectorModeCommand
        {
            get
            {
                if (_DirectorMode == null)
                    _DirectorMode = new RelayCommand(ExecuteDirectorMode,CanDirectorMode);
                return _DirectorMode;
            }
        }
        public  ICommand AddNewClientCommand
        {
            get
            {
                if (_AddNewClient == null)
                    _AddNewClient = new RelayCommand(Execute_NewClient, Can_NewClient);
                return _AddNewClient;
            }
        }
        public  ICommand OperationClientCommand
        {
            get
            {
                if (_OperationsClient == null)
                    _OperationsClient = new RelayCommand(ExecuteOperationClient, CanOperationClient);
                return _OperationsClient;
            }
        }
        public  ICommand ScheduleCommand
        {
            get
            {
                if (_Schedule == null)
                    _Schedule = new RelayCommand(ExecuteSchedule, CanSchedule);
                return _Schedule;
            }
        }
        public  ICommand NewsCommand
        {
            get
            {
                if (_News == null)
                    _News = new RelayCommand(ExecuteNews, CanNews);
                return _News;
            }
        }
        public ICommand ChatCommand
        {
            get
            {
                if (_Chat == null)
                    _Chat = new RelayCommand(ExecuteChat, CanChat);
                return _Chat;
            }
        }
        void ExecuteDirectorMode(object o)
        {

            LoginWindow win = new LoginWindow();
            win.ShowDialog();

            if (win.DialogResult == true)
            {
                (App.Current.MainWindow.DataContext as MainWindowViewModel).Controls = new Controls_Director();
                (App.Current.MainWindow.DataContext as MainWindowViewModel).MainFrame = new DefaultDirectorFrame();
            }
            
            
            
        }
        bool CanDirectorMode(object o)
        {
            return true;
        }
        void ExecuteNews(object o)
        {
            (App.Current.MainWindow.DataContext as MainWindowViewModel).MainFrame = new NewsFrame();
        }
        bool CanNews(object o)
        {
            return true;
        }
        void ExecuteChat(object o)
        {
            (App.Current.MainWindow.DataContext as MainWindowViewModel).MainFrame = new ChatFrame();
        }
        bool CanChat(object o)
        {
            return true;
        }
        void ExecuteSchedule(object o)
        {
            (App.Current.MainWindow.DataContext as MainWindowViewModel).MainFrame = new Schedule();
        }
        bool CanSchedule(object o)
        {
            return true;
        }
        void ExecuteOperationClient(object o)
        {
            (App.Current.MainWindow.DataContext as MainWindowViewModel).MainFrame = new ClientOperationFrame();
        }
        bool CanOperationClient(object o)
        {
            return true;
        }
        void Execute_NewClient(object o)
        {
            (App.Current.MainWindow.DataContext as MainWindowViewModel).MainFrame = new AddNewClientFrame();
        }
        bool Can_NewClient(object o)
        {
            return true;
        }

    }
}
