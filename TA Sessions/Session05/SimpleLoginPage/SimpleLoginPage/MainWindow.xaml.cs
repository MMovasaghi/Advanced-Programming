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

namespace SimpleLoginPage
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

        private void SignInButton_Click(object sender, RoutedEventArgs e)
        {
            Models.Validation v = new Models.Validation();
            Models.Person per = new Models.Person()
            {
                Username = UserNameTXT.Text,
                Password = PasswordTXT.Password
            };
            bool a = v.CheckUSERPASS(per);
            if (a)
            {
                MessageBox.Show(a.ToString());
            }
            else
            {
                MessageBox.Show(a.ToString());
            }
        }

        private void CreatorButton_Click(object sender, RoutedEventArgs e)
        {
            Models.Validation v = new Models.Validation();
            MessageBox.Show(v.InitialDB().ToString());
        }

        private void Costtext_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                string str = costtext.Text;
                int a = Int32.Parse(costtext.Text);
                if (str.Length > 4)
                {
                    throw new Exception();
                }
            }
            catch (Exception)
            {
                //costtext.Text = "";
                string str = costtext.Text;
                string newstr = "";
                for (int i = 0; i < str.Length -1 ; i++)
                {
                    newstr += str[i];
                }
                costtext.Text = newstr;
                costtext.CaretIndex = costtext.Text.Length;
                //costtext.IsEnabled = false;
            }
        }
    }
}
