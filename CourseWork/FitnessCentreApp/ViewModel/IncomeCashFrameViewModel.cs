using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FitnessCentreApp.Infrastructure;
using System.Windows.Input;
using FitnessCentreApp.Model;
using System.Drawing;
using System.Drawing.Printing;
using FitnessCentreApp.Properties;

namespace FitnessCentreApp.ViewModel
{
    class IncomeCashFrameViewModel : ViewModelBase
    {
        Channal channal;
        RelayCommand _print;
      public   ICommand Print
        {
            get
            {
                if(_print==null)
                {
                    _print = new RelayCommand(PrintEx, CanPrint);
                    
                }
                return _print;
            }
        }
        public IncomeCashFrameViewModel()
        {
            channal = Channal.Create();
        }
        private bool CanPrint(object obj)
        {
            return CashInfo.allincash != 0;
        }

        private void PrintEx(object obj)
        {
            PrintDocument doc = new PrintDocument();
            doc.PrintPage += PrintPageHandler;
            doc.Print();
        }

       
    
    void PrintPageHandler(object sender, PrintPageEventArgs e)
    {
        
        e.Graphics.DrawString("----------------------- FITNESS CENTRE COMPANY-----------------------", new Font("Arial", 50), Brushes.Black, 0, 0);
            e.Graphics.DrawImage(Resources.fitness_clip_art_48, 30, 30);
            e.Graphics.DrawString("Доход с " + DateFrom + " по " + DateTo +  "\n" + "Общий: " +
                 CashInfo.allincash + "\n" +
                 "Зарплата: -" + CashInfo.salarycash + "\n" + 
                 "Налоги: -" + CashInfo.podatok  + "\n"+
                 new string('-',50) + 
                 "Чистая прибыль: " + CashInfo.flowcash
                 , new Font("Arial", 20), Brushes.Black, 80, 0);
    }

    DateTime _DateFrom;
         DateTime _DateTo;
        public DateTime DateFrom
        {

            get
            {
                return _DateFrom;
            }
            set
            {
                _DateFrom = value;
                UpdateInfo();
                OnPropertyChanged("DateFrom");
            }
        }
        public DateTime DateTo
        {
            get
            {
                return _DateTo;
            }
            set
            {
                _DateTo = value;
                UpdateInfo();
                OnPropertyChanged("DateTo");
            }
        }
        Cash _CashInfo;
        public Cash CashInfo
        {
            get
            {
                if (_CashInfo == null)
                    _CashInfo = new Cash();
                return _CashInfo;
            }
            set
            {
                _CashInfo = value;
            }
        }
        void UpdateInfo()
        {
            Cash cc = channal.channal.GetCashFromTo(DateFrom.ToBinary(), DateTo.ToBinary());
            CashInfo.salarycash = cc.salarycash;
            CashInfo.allincash = cc.allincash;
        }

    }
}
