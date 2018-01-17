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
    }
}
