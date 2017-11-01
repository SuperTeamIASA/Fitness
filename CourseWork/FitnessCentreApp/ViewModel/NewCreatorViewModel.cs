using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using FitnessCentreApp.Infrastructure;
using FitnessCentreApp.Model;
using Microsoft.Win32;
using System.Drawing;

namespace FitnessCentreApp.ViewModel
{
    class NewCreatorViewModel :ViewModelBase
    {
        Channal chanal;
        New _cuttentnew;
        RelayCommand _AttachPhoto;
        RelayCommand _AddNews;
     public   string fotopath;
        public NewCreatorViewModel()
        {
            chanal = Channal.Create();
        }
        public New CurrentNew
        {
            get
            {
                if (_cuttentnew == null)
                    _cuttentnew = new New();
                return _cuttentnew;
            }
            set
            {
                _cuttentnew = value;
                OnPropertyChanged("CurrentNew");
            }
        }
        public ICommand AttachPhotoCommand
        {
            get
            {
                if (_AttachPhoto == null)
                    _AttachPhoto = new RelayCommand(ExecuteAttachPhoto, CanAttachPhoto);
                return _AttachPhoto;
            }
        }
        public ICommand AddNewCommand
        {
            get
            {
                if (_AddNews == null)
                    _AddNews = new RelayCommand(ExecuteAddNew, CanAddNew);
                return _AddNews;
            }
        }

        private bool CanAddNew(object obj)
        {
            if (string.IsNullOrEmpty(CurrentNew.Title) || string.IsNullOrEmpty(CurrentNew.NewText)) 
                return false;
            return true;
        }

        private void ExecuteAddNew(object obj)
        {
            if (fotopath != string.Empty) {
                chanal.channal.SendImage(CurrentNew.imagename, Model.ImageControl.ImageToByte(fotopath));
                    }
            chanal.channal.AddNew(CurrentNew);
            
            CurrentNew.Title = string.Empty;
            CurrentNew.NewText = string.Empty;
            CurrentNew.imagename = string.Empty;
          
        }
        private bool CanAttachPhoto(object obj)
        {
            return true;
        }

        private void ExecuteAttachPhoto(object obj)
        {
            //OpenFileDialog filedialoge = new OpenFileDialog();
            //filedialoge.Title = "прикрепить изображение";
            //filedialoge.Filter = "Image documents PNG (.png)|*.png";
            //filedialoge.DefaultExt = ".png";
            //bool? result = filedialoge.ShowDialog();
            //if (result == true)
            //{

            //    CurrentNew.imagename = filedialoge.SafeFileName;

            //    fotopath = filedialoge.FileName;
            //}
        }
    }


}
