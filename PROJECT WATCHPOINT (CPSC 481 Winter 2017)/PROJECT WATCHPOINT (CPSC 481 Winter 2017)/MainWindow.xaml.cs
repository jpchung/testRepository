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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PROJECT_WATCHPOINT__CPSC_481_Winter_2017_
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ChangeProfileButton_Click(object sender, RoutedEventArgs e)
        {
            profileImage.Source = new BitmapImage(new Uri("https://s-media-cache-ak0.pinimg.com/236x/cb/77/bc/cb77bc142fa78f6e9f0d3b4ae150f392.jpg"));
        }

  
    }
}
