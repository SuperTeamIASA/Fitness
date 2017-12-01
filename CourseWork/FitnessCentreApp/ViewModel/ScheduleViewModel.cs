using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FitnessCentreApp.Infrastructure;
using FitnessCentreApp.Model;
using System.Collections.ObjectModel;
using System.Xml.Linq;
using System.Windows.Input;

namespace FitnessCentreApp.ViewModel
{
    class ScheduleViewModel : ViewModelBase
    {
        Channal channal;
        RelayCommand _add;
        RelayCommand _change;
        RelayCommand _delete;
        DateTime _selected_date;
        public ICommand Add
        {
            get
            {
                if (_add == null)
                    _add = new RelayCommand(AddEx, CanAdd);
                return _add;
            }
        }

        private bool CanAdd(object obj)
        {
            throw new NotImplementedException();
        }

        private void AddEx(object obj)
        {
            throw new NotImplementedException();
        }

        public ICommand Change
        {
            get
            {
                if (_change == null)
                    _change = new RelayCommand(ChangeEx, CanChange);
                return _change;
            }
        }

        private bool CanChange(object obj)
        {
            throw new NotImplementedException();
        }

        private void ChangeEx(object obj)
        {
            throw new NotImplementedException();
        }

        public ICommand Delete
        {
            get
            {
                if (_delete == null)
                    _delete = new RelayCommand(DeleteEx, CanDelete);
                return _delete;
            }
        }

        private bool CanDelete(object obj)
        {
            throw new NotImplementedException();
        }

        private void DeleteEx(object obj)
        {
            throw new NotImplementedException();
        }

        public DateTime SelectedDate
        {
            get
            {

                return _selected_date;
            }
            set
            {
                _selected_date = value;
                //loadtable
            }
        }

        public ScheduleViewModel()
        {
            channal = Channal.Create();
        }
        List<ScheduleCell> _schedule;
        public List<ScheduleCell> Schedule
        {
            get
            {
                return _schedule;
            }
            set
            {
                _schedule = value;

            }
        }
        ObservableCollection<Trainer> _trainerlist;
        public ObservableCollection<Trainer> TrainerList
        {
            get
            {
                if (_trainerlist == null)
                    _trainerlist = new ObservableCollection<Trainer>();
                return _trainerlist;
            }
            set
            {
                _trainerlist = value;
                OnPropertyChanged("TrainerList");
            }
        }
        ObservableCollection<Lessons> _lessons;
        int _selectedlessonindex;
        public int SelectedLessonIndex
        {
            get
            {
                return _selectedlessonindex;
            }
            set
            {
                _selectedlessonindex = value;
                TrainerList = new ObservableCollection<Trainer>(channal.channal.GetTrainerlist(LessonList[SelectedLessonIndex].lessonid));
                OnPropertyChanged("SelectedLessonIndex");
            }
        }
        public ObservableCollection<Lessons> LessonList
        {
            get
            {
                if (_lessons == null)
                {
                    XDocument doc = XDocument.Load(AppDomain.CurrentDomain.BaseDirectory + "/sesion.xml");
                    _lessons = new ObservableCollection<Lessons>();
                    foreach (var item in doc.Root.Element("lessons").Elements())
                    {
                        _lessons.Add(new Lessons()
                        {
                            lessonid = int.Parse(item.Attribute("id").Value),
                            name = item.Attribute("name").Value,
                            description = item.Attribute("description").Value,
                            duration = int.Parse(item.Attribute("duration").Value),
                            groupcost = decimal.Parse(item.Attribute("groupcost").Value),
                            indivcost = decimal.Parse(item.Attribute("individualcost").Value)
                        });
                    }
                }
                return _lessons;
            }
            set
            {
                _lessons = value;
            }
        }
        private int _trainerlistindex;

        public int TrainerListIndex
        {
            get { return _trainerlistindex; }
            set
            {
                _trainerlistindex = value;
                OnPropertyChanged("TrainerListIndex");
            }
        }










    }
}
