using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows.Controls;
using FitnessCentreApp.View;
using System.ComponentModel;

namespace FitnessCentreApp.ViewModel
{
    class MainWindowViewModel : ViewModelBase
    {
        private static Page _controls;
        private static Page _mainFrame;
      public  Page Controls
            {
            get
            {
                if (_controls == null)
                    _controls = new Controls_Admin();
                return _controls;
            }
            set
            {
                _controls = value;
                OnPropertyChanged("Controls");
            }
            }
      public  Page MainFrame
        {
            get
            {
                if (_mainFrame == null)
                    _mainFrame = new DefaultAdminFrame();
                return _mainFrame;
            }
            set
            {
                _mainFrame = value;
                OnPropertyChanged("MainFrame");
            }
        }

    }
}
