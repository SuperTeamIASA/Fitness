using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FitnessCentreApp.Infrastructure;
using System.Windows.Input;
using FitnessCentreApp.Model;
using FitnessCentreApp.View;
using System.Drawing;

namespace FitnessCentreApp.ViewModel
{
    class NewsFrameViewModel : ViewModelBase
    {
        Channal channal;
        RelayCommand _AddNews;
        RelayCommand _NewsSetting;
        RelayCommand _DeleteNews;
        RelayCommand _Update;
        ObservableCollection<New> _newsCollection = new ObservableCollection<New>() { new New() { Title = "Title1", NewText = "Text Text Text Text Text Text Text Text Text Text Text Text Text Text ", Image1 = new Bitmap(@"C:\Users\vladk\documents\visual studio 2015\Projects\CourseWork\FitnessCentreApp\Images\twitter.png") } ,
            new New() { Title = "Title1", NewText = "Text Text Text Text Text Text Text Text Text Text Text Text Text Text ", Image1 = new Bitmap(@"C:\Users\vladk\documents\visual studio 2015\Projects\CourseWork\FitnessCentreApp\Images\twitter.png") } ,
            new New() { Title = "Title1", NewText = "Text Text Text Text Text Text Text Text Text Text Text Text Text Text ", Image1 = new Bitmap(@"C:\Users\vladk\documents\visual studio 2015\Projects\CourseWork\FitnessCentreApp\Images\twitter.png") } };
        public NewsFrameViewModel()
        {
            channal = Channal.Create();
        }

        public ObservableCollection<New> NEWS
        {
            get
            {
                if (_newsCollection == null)
                {
                    _newsCollection = new ObservableCollection<New>(channal.channal.GetNews());
                }

                return _newsCollection;
            }
        }
        public ICommand AddNewCommand
        {
            get
            {
                if (_AddNews == null)
                    _AddNews = new RelayCommand(ExecuteAddNews, CanAddNews);
                return _AddNews;
            }
        }
        public ICommand NewSettingCommand
        {
            get
            {
                if (_NewsSetting == null)
                    _NewsSetting = new RelayCommand(ExecuteNewSetting, CanNewSetting);
                return _NewsSetting;
            }
        }
        public ICommand DeleteCommand
        {
            get
            {
                if (_DeleteNews == null)
                    _DeleteNews = new RelayCommand(ExecuteDelete, CanDelete);
                return _DeleteNews;
            }
        }
        public ICommand UpdateCommand
        {
            get
            {
                if (_Update == null)
                    _Update = new RelayCommand(ExecuteUpdate, CanUpdate);
                return _Update;
            }
        }
        public int SelectedListItem { get; set; }
        

        void ExecuteAddNews(object o)
        {
            NewCreator window = new NewCreator();
            
            window.Show();
            window.Closed += (obj, e) => { ExecuteUpdate(3); };

        }
       bool CanAddNews(object o)
        {
            return true;
        }
        void ExecuteNewSetting(object o)
        {
            NewCreator window = new NewCreator(NEWS[SelectedListItem].Title, NEWS[SelectedListItem].NewText);
            window.Show();
            window.Closed += (obj, e) => { ExecuteUpdate(3); };
        }
        bool CanNewSetting(object o)
        {
            return true;
        }
        void ExecuteDelete(object o)
        {
            channal.channal.DeleteNew(NEWS[SelectedListItem]);
            NEWS.RemoveAt(SelectedListItem);   
        }
        bool CanDelete(object o)
        {
            return true;

        }
        void ExecuteUpdate(object o)
        {
            _newsCollection = null;
        }
        bool CanUpdate(object o)
        {
            return true;
        }
    }
}
