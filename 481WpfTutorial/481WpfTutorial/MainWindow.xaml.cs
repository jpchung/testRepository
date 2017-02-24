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

namespace _481WpfTutorial
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {


        public Brushes GridBackground;

        public MainWindow()
        {
            InitializeComponent();




        }

        private void radioButton_Checked(object sender, RoutedEventArgs e)
        {

            bool thing1Checked = radioButton.IsChecked.Value;
            if (thing1Checked)
            {
                textBox.Text = (string) radioButton.Content;
                temmie_image.Visibility = Visibility.Visible;
                sans_image.Visibility = Visibility.Hidden;
                windowGrid.Background = Brushes.Aquamarine;

            }
            else
            {
                textBox.Text = "";
                windowGrid.Background = Brushes.White;
            }
            
        }

        private void radioButton_Copy_Checked(object sender, RoutedEventArgs e)
        {
 
            bool thing2Checked = radioButton_Copy.IsChecked.Value;
            if (thing2Checked)
            {
                textBox.Text = (string) radioButton_Copy.Content;
                sans_image.Visibility = Visibility.Visible;
                temmie_image.Visibility = Visibility.Hidden;
                windowGrid.Background = Brushes.DarkBlue;
            }
            else
            {
                textBox.Text = "";
                windowGrid.Background = Brushes.White;
                
            }
            
        }
    }
}
