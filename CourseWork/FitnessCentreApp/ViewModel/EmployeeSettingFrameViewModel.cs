//using System;
//using System.Collections.Generic;
//using System.Collections.ObjectModel;
//using System.Linq;
//using System.Text;
//using System.Xml.Linq;
//using System.Threading.Tasks;
//using FitnessCentreApp.Infrastructure;
//using System.Windows.Input;
//using FitnessCentreApp.Model;
//using FitnessCentreApp.View;
//using System.Drawing;

//namespace FitnessCentreApp.ViewModel
//{
//    class EmployeeSettingFrameViewModel : ViewModelBase
//    {
//        //TODO Do this ViewModel
//        Channal channal;
//        RelayCommand _AddEmployee;
//        RelayCommand _EmployeesSetting;
//        RelayCommand _DeleteEmployee;
//        RelayCommand _Update;
//        ObservableCollection<Employee> _employeeCollection;
//        public EmployeeSettingFrameViewModel()
//        {
//            channal = Channal.Create();
//        }

//        public ObservableCollection<Employee> EMPLOYEE
//        {
//            get
//            {
//                if (_employeeCollection == null)
//                {
//                    _employeeCollection = new ObservableCollection<Employee>();
//                    XDocument doc = XDocument.Load(AppDomain.CurrentDomain.BaseDirectory + "/sesion.xml");
//                    foreach (var n in doc.Root.Element("employee").Elements())
//                    {
//                        _employeeCollection.Add(new New()
//                        {
//                            Title = n.Attribute("Title").Value,
//                            NewsId = int.Parse(n.Attribute("id").Value),
//                            NewText = n.Attribute("Text").Value,
//                            imagename = n.Attribute("Image").Value

//                        });
//                    }
//                }

//                return _newsCollection;
//            }
//        }
//        public ICommand AddNewCommand
//        {
//            get
//            {
//                if (_AddNews == null)
//                    _AddNews = new RelayCommand(ExecuteAddNews, CanAddNews);
//                return _AddNews;
//            }
//        }
//        public ICommand NewSettingCommand
//        {
//            get
//            {
//                if (_NewsSetting == null)
//                    _NewsSetting = new RelayCommand(ExecuteNewSetting, CanNewSetting);
//                return _NewsSetting;
//            }
//        }
//        public ICommand DeleteCommand
//        {
//            get
//            {
//                if (_DeleteNews == null)
//                    _DeleteNews = new RelayCommand(ExecuteDelete, CanDelete);
//                return _DeleteNews;
//            }
//        }
//        public ICommand UpdateCommand
//        {
//            get
//            {
//                if (_Update == null)
//                    _Update = new RelayCommand(ExecuteUpdate, CanUpdate);
//                return _Update;
//            }
//        }
//    }
//}
