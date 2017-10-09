using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FitnessCentreApp.Infrastructure;
using FitnessCentreApp.Model;
using System.Windows.Input;
using System.Collections.ObjectModel;
namespace FitnessCentreApp.ViewModel
{
    class ChatFrameViewModel : ViewModelBase
    {
        
        RelayCommand _clear;
        RelayCommand _send;
        Channal channal;
        public ChatFrameViewModel()
        {
            channal = Channal.Create();
        }
        public ICommand ClearCommand
        {
            get
            {
                if (_clear == null)
                    _clear = new RelayCommand(ExecuteClear, CanClear);
                return _clear;
            }
        }
        public   ICommand SendCommand
        {
            get
            {
                if (_send == null)
                    _send = new RelayCommand(ExecuteSend, CanSend);
                return _send;
            }
        }
        ObservableCollection<MessageClass> _messages;
        //колекция собщений для каждого клиента
        public ObservableCollection<MessageClass> MessagesWithUser
        {
            get
            {
                if (_messages == null)
                    _messages = new ObservableCollection<MessageClass>(channal.channal.GetMessage(_users[SelectionClientItem]));
                return _messages;
            }
            set
            {
                _messages = value;
                OnPropertyChanged("MessagesWithUser");
            }
        }
        ObservableCollection<ChatUser> _users;
        //Колекция клиентов которые учавствували в переписке
        public ObservableCollection<ChatUser> ChatUsers
        {
            get
            {
                if (_users == null)
                    _users = new ObservableCollection<ChatUser>(channal.channal.GetChatUsers());
                return _users;
            }
            set
            {
                _users = value;
                OnPropertyChanged("ChatUsers");
            }
        }
        //выбранный индекс текущего елемнта в списке клиентов
        public int SelectionClientItem { get; set; }

        string _message;
        public string Message
        {
            get
            {
                return _message;
                               
            }
            set
            {
                _message = value;
                OnPropertyChanged("Message");
            }
        }
        //имя клиента текущей открытой переписки
        public string CurrentUserName
        {
            get
            {
               return  ChatUsers[SelectionClientItem].Name;
            }
        }
        private bool CanSend(object obj)
        {
            if (string.IsNullOrEmpty(Message))
                return false;
            return true;
        }

        // Отправка собщения на сервер и динамическое добавления его в список
        private void ExecuteSend(object obj)
        {
            channal.channal.SendMessade(ChatUsers[SelectionClientItem], new MessageClass() { Timeofmessage = DateTime.Now, _autor = 0, MessageText = Message });
            MessagesWithUser.Add(new MessageClass() { Timeofmessage = DateTime.Now, _autor = 0, MessageText = Message });
            ExecuteClear(2);
        }

        private bool CanClear(object obj)
        {
            if (string.IsNullOrEmpty(Message))
                return false;
            return true;
        }

        // Очистка блока с собщением
        private void ExecuteClear(object obj)
        {
            Message = string.Empty;
        }
    }
}
