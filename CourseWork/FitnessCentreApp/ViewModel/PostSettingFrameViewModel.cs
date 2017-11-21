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
    class PostSettingFrameViewModel : ViewModelBase
    {
        Channal channal;
        RelayCommand _save;
        RelayCommand _add;
        RelayCommand _delete;
        int _empCount;
        public int EmpCount
        {
            get
            {
                return _empCount;
            }
            set
            {
                _empCount = value;
            }
        }
        void CalculateEmps(int id)
        {
            int temp = 0;
            XDocument doc = XDocument.Load(AppDomain.CurrentDomain.BaseDirectory + "/sesion.xml");
            foreach (var item in doc.Root.Element("emploees").Elements())
            {
                if (int.Parse(item.Attribute("postId").Value) == id)
                {
                    temp++;
                }
            }
            EmpCount = temp;
        }
        public ICommand AddCommand
        {
            get
            {
                if (_add == null)
                    _add = new RelayCommand(AddExecute, CanAdd);
                return _add;
            }
        }

        private bool CanAdd(object obj)
        {
            if (string.IsNullOrEmpty(SelectedPost.postName) || string.IsNullOrEmpty(SelectedPost.description))
                return true;
            return false;
        }

        private void AddExecute(object obj)
        {
            channal.channal.AddPost(SelectedPost);
            SelectedPostIndex = 0;
            SelectedPost = new Post();
            EmpCount = 0;
        }

        public ICommand DelCommand
        {
            get
            {
                if(_delete == null)
                {
                    _delete = new RelayCommand(DeleteEx, CanDelete);
                }
                return _delete;
            }
        }

        private bool CanDelete(object obj)
        {
            if (SelectedPostIndex != 0)
                return true;
            return false;
        }

        private void DeleteEx(object obj)
        {
            channal.channal.DeletePost(PostList[SelectedPostIndex].postId);
            PostList.RemoveAt(SelectedPostIndex);
            SelectedPostIndex = 0;
            SelectedPost = new Post();
            EmpCount = 0;
        }

        public ICommand SaveCommand
        {
            get
            {
                if (_save == null)
                {
                    _save = new RelayCommand(ExecuteSave, CanSave);
                }
                return _save;
            }
        }

        private bool CanSave(object obj)
        {
            return true;
        }

        private void ExecuteSave(object obj)
        {
            
            channal.channal.ChangePost(PostList[SelectedPostIndex].postId, SelectedPost);
            PostList[SelectedPostIndex] = SelectedPost;
            SelectedPostIndex = 0;
            SelectedPost = new Post();
           
        }

        ObservableCollection<Post> _postlist;
        public ObservableCollection<Post> PostList
        {
            get
            {
                if (_postlist == null)
                {
                    XDocument doc = XDocument.Load(AppDomain.CurrentDomain.BaseDirectory + "/sesion.xml");
                    _postlist = new ObservableCollection<Post>();
                    foreach (var item in doc.Root.Element("posts").Elements())
                    {
                        _postlist.Add(new Post()
                        {
                            postId = int.Parse(item.Attribute("id").Value),
                            postName = item.Attribute("name").Value,
                            description = item.Attribute("description").Value,
                            salary = decimal.Parse(item.Attribute("salary").Value)
                        });
                       
                    }
                }
                return _postlist;
            }
            set
            {
                _postlist = value;
            }
        }
        int _selectedpostindex;
        public int SelectedPostIndex
        {
            get
            {
                return _selectedpostindex;
            }
            set
            {
                _selectedpostindex = value;
                OnPropertyChanged("SelectedPostIndex");
                SelectedPost = PostList[SelectedPostIndex];
                CalculateEmps(PostList[SelectedPostIndex].postId);
            }
        }
        Post _SelectedPost;
        public Post SelectedPost
        {
            get
            {
                if (_SelectedPost == null)
                    _SelectedPost = new Post();
                return _SelectedPost;
            }
            set
            {
                _SelectedPost = value;
                OnPropertyChanged("SelectedPost");

            }
        }

    }
}
