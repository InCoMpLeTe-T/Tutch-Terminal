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
    /// Interaction logic for Page1_MainMeny.xaml
    /// </summary>
    public partial class Page1_MainMeny : Page
    {
        public Page1_MainMeny()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Page1_login p1 = new Page1_login();
            this.NavigationService.Navigate(p1);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            //ikke sikkert salg skal være p1!!!!!!!!!!!!!!!!!!!!
            Salg p1 = new Salg();
            this.NavigationService.Navigate(p1);
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Kasse p1 = new Kasse();
            this.NavigationService.Navigate(p1);
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Ret_La p1 = new Ret_La();
            this.NavigationService.Navigate(p1);
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            Indkøb p1 = new Indkøb();
            this.NavigationService.Navigate(p1);
        }
    }
}
