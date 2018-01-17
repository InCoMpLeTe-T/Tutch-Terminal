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

namespace Fredags1024x768
{
    /// <summary>
    /// Interaction logic for Salg.xaml
    /// </summary>
    public partial class Salg : Page
    {
        public Salg()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Page1_MainMeny p2 = new Page1_MainMeny();
            this.NavigationService.Navigate(p2);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            //øl knappen gør den synlig
            this.øl.Visibility = Visibility.Visible;           
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            //back knappen hidder 
            this.øl.Visibility = Visibility.Hidden;
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            //Rtd knappen gør rtd synlig
            this.Rtd.Visibility = Visibility.Visible;
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            //back knappen hidder rtd
            this.Rtd.Visibility = Visibility.Hidden;
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            //soda knappen gør sodan synlig
            this.Soda.Visibility = Visibility.Visible;
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            //back knap hidder soda
            this.Soda.Visibility = Visibility.Hidden;
        }

    }
}
