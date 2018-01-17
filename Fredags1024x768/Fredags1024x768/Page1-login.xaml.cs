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
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Fredags1024x768
{
    /// <summary>
    /// Interaction logic for Page1_login.xaml
    /// </summary>
    public partial class Page1_login : Page
    {
<<<<<<< HEAD

    
=======
        
        static String MyConnectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=vlan1";
        MySqlConnection conn = new MySqlConnection(MyConnectionString);

>>>>>>> dec2a6d276a898d73c85a9ccaf88de38deb55ecb
        public Page1_login()
        {
            InitializeComponent();
        }


        public void FocusCheck(int i)
        {
            if(i == 11)
            {
                if(Keyboard.FocusedElement == UsernameTextBox)
                {
                    UsernameTextBox.Text = "";
                }
                else if (Keyboard.FocusedElement == PasswordTextBox)
                {
                    PasswordTextBox.Text = "";
                }
            }

            else if (Keyboard.FocusedElement == UsernameTextBox)
            {
                UsernameTextBox.Text += i.ToString();
            }
            else if (Keyboard.FocusedElement == PasswordTextBox)
            {
                PasswordTextBox.Text += i.ToString();
            }
 
        }

        private void ButtonEnter_Click(object sender, RoutedEventArgs e)
        {
            
            string username = UsernameTextBox.Text;
            string password = PasswordTextBox.Text;
            string vagtNavn = "";
            string sql = "SELECT * FROM brugere WHERE `Username` = '" + username + "'";
            MySqlCommand cmd = new MySqlCommand(sql, conn);

            conn.Open();
            
            MySqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {   
                if (password == reader.GetString("Password"))
                {
                    vagtNavn = reader.GetString("Name");
                    Page1_MainMeny p2 = new Page1_MainMeny();
                    this.NavigationService.Navigate(p2);
                }
                else
                {
                    Wrong.Content = "Wrong Username or Password";
                }
            }
            else
            {
                Wrong.Content = "Wrong Username or Password";
            }

            conn.Close();
        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            FocusCheck(1);
        }

        private void Button2_Click(object sender, RoutedEventArgs e)
        {
            FocusCheck(2);
        }

        private void Button3_Click(object sender, RoutedEventArgs e)
        {
            FocusCheck(3);
        }

        private void Button4_Click(object sender, RoutedEventArgs e)
        {
            FocusCheck(4);
        }

        private void Button5_Click(object sender, RoutedEventArgs e)
        {
            FocusCheck(5);
        }

        private void Button6_Click(object sender, RoutedEventArgs e)
        {
            FocusCheck(6);
        }

        private void Button7_Click(object sender, RoutedEventArgs e)
        {
            FocusCheck(7);
        }

        private void Button8_Click(object sender, RoutedEventArgs e)
        {
            FocusCheck(8);
        }

        private void Button9_Click(object sender, RoutedEventArgs e)
        {
            FocusCheck(9);
        }

        private void Button0_Click(object sender, RoutedEventArgs e)
        {
            FocusCheck(0);
        }

        private void ButtonDelete_Click(object sender, RoutedEventArgs e)
        {
            FocusCheck(11);
        }
    }
}
