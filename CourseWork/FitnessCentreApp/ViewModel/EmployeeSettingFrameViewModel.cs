using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using System.Threading.Tasks;
using FitnessCentreApp.Infrastructure;
using System.Windows.Input;
using FitnessCentreApp.Model;
using FitnessCentreApp.View;
using System.Drawing;

namespace FitnessCentreApp.ViewModel
{
    class EmployeeSettingFrameViewModel : ViewModelBase
    {
        //TODO Do this View
        Channal channal;
        RelayCommand _AddEmployee;
        RelayCommand _EmployeesSetting;
        RelayCommand _DeleteEmployee;
        RelayCommand _Update;
        ObservableCollection<Employee> _employeeCollection;
        public EmployeeSettingFrameViewModel()
        {
            channal = Channal.Create();
        }
        ObservableCollection<Employee> _emplist;
        public ObservableCollection<Employee> EmpList
        {
            get
            {
                if(_emplist == null)
                {
                    _emplist = new ObservableCollection<Employee>();
                    XDocument  doc = XDocument.Load(AppDomain.CurrentDomain.BaseDirectory + "/sesion.xml");
                    foreach (var item in doc.Root.Element("emploees").Elements())
                    {
                        _emplist.Add(new Employee()
                        {
                            empId = int.Parse(item.Attribute("id").Value),
                            empName = item.Attribute("name").Value,
                            empLastName = item.Attribute("lastname").Value,
                            empEmail = item.Attribute("email").Value,
                            empPhone = item.Attribute("phone").Value,
                            empBdate = DateTime.Parse(item.Attribute("bdate").Value),
                            postId = int.Parse(item.Attribute("postId").Value),
                            empDate = DateTime.Parse(item.Attribute("empDate").Value),
                            empGender = bool.Parse(item.Attribute("empGender").Value)
                            

                        });
                    }
                }
                return _emplist;
            }
        }
        int _selectedIndex;
        public int SelectedIndex
        {
            get
            {
                return _selectedIndex;
            }
            set
            {
                _selectedIndex = value;
                OnPropertyChanged("SelectedIndex");
                SelectedEmp = EmpList[value];
            }
        }
        Employee _selectedEmp;
        public Employee SelectedEmp
        {
            get
            {
                if (_selectedEmp == null)
                    _selectedEmp = new Employee();
                return _selectedEmp;
            }
            set
            {
                _selectedEmp = value;
                OnPropertyChanged("SelectedEmp");
            }
        }

        public ICommand Add
        {
            get
            {
                if (_AddEmployee == null)
                    _AddEmployee = new RelayCommand(ExAdd, CanAdd);
                return _AddEmployee;
            }
        }

        private bool CanAdd(object obj)
        {
            if (!string.IsNullOrEmpty(SelectedEmp.empName) || !string.IsNullOrEmpty(SelectedEmp.empLastName) || !string.IsNullOrEmpty(SelectedEmp.empEmail) || !string.IsNullOrEmpty(SelectedEmp.empPhone)
                 || !string.IsNullOrEmpty(SelectedEmp.empBdate.ToString()))
                return true;
            return false;
        }

        private void ExAdd(object obj)
        {
            channal.channal.addEmployee(SelectedEmp);
            EmpList.Add(SelectedEmp);
            SelectedEmp = new Employee();

        }

        public ICommand Change
        {
            get
            {
                if (_EmployeesSetting == null)
                    _EmployeesSetting = new RelayCommand(ExChange, CanChange);
                return _EmployeesSetting;   
            }
        }

        private bool CanChange(object obj)
        {
            if (!string.IsNullOrEmpty(SelectedEmp.empName) || !string.IsNullOrEmpty(SelectedEmp.empLastName) || !string.IsNullOrEmpty(SelectedEmp.empEmail) || !string.IsNullOrEmpty(SelectedEmp.empPhone)
                  || !string.IsNullOrEmpty(SelectedEmp.empBdate.ToString()))
                return true;
            return false;
        }

        private void ExChange(object obj)
        {
            channal.channal.changeEmployee(EmpList[SelectedIndex].empId, SelectedEmp);
            EmpList[SelectedIndex] = SelectedEmp;
            SelectedIndex = 0;
            SelectedEmp = new Employee();

        }

        public ICommand Delete
        {
            get
            {
                if (_DeleteEmployee == null)
                    _DeleteEmployee = new RelayCommand(DeleteEx, CanDelete);
                return _DeleteEmployee;
            }
        }

        private bool CanDelete(object obj)
        {
            if (SelectedIndex != 0)
                return true;
            return false;
        }

        private void DeleteEx(object obj)
        {
            channal.channal.deleteEmployee(EmpList[SelectedIndex].empId);
            EmpList.RemoveAt(SelectedIndex);
            SelectedIndex = 0;
            SelectedEmp =new  Employee();
        }
    }
}
