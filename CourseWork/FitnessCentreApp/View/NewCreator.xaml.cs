using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace FitnessCentreApp.View
{
    /// <summary>
    /// Логика взаимодействия для NewCreator.xaml
    /// </summary>
    public partial class NewCreator : Window
    {
        public NewCreator()
        {
            InitializeComponent();
        }
        public NewCreator(string title, string text)
        {
            InitializeComponent();
            Titleblock.Text = title;
            TextBlock.Text = text;
    
        }
    }
}
