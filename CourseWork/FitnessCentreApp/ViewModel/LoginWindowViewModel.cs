using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FitnessCentreApp.Infrastructure;
using System.Windows.Input;
using FitnessCentreApp.Properties;
using FitnessCentreApp.View;
using System.Windows.Controls;
namespace FitnessCentreApp.ViewModel
{
    class LoginWindowViewModel : ViewModelBase
    {
        public LoginWindow window { get; set; }
        RelayCommand _login;
        RelayCommand _cancel;
        public  ICommand CancelCommand
        {
            get
            {
                if (_cancel == null)
                    _cancel = new RelayCommand(Cancel, CanCancel);
                return _cancel;
            }
        }
        public  ICommand LoginCommand
        {
            get
            {
                if (_login == null)
                    _login = new RelayCommand(Login, CanLogin);
                return _login;
            }
       
        }
        public bool DialogResult
        {
            get;set;
        }
        void Cancel(object o)
        {
            (o as LoginWindow).DialogResult = false;
            (o as LoginWindow).Close();
        }
        bool CanCancel(object o)
        {
            return true;
        }
        void Login(object param)
            {
            if (((param as LoginWindow).FindName("Password") as PasswordBox).Password == Settings.Default.directorPassword)
            {
                (param as LoginWindow).DialogResult = true;
                (param as LoginWindow).Close();
            }
            else
            {
                ((param as LoginWindow).FindName("Password") as PasswordBox).Password = String.Empty;
                ((param as LoginWindow).FindName("Password") as PasswordBox).BorderBrush = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Colors.Red);
            }

        }
        bool CanLogin(object param)
        {
            return true;
        }
    }
}
