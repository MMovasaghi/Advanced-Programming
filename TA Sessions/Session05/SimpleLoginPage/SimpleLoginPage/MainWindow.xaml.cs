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
            
            using (var db = new Models.LoginContext())
            {
                var res = db.Blogs.Where(i => i.Username == UserNameTXT.Text && i.Password == PasswordTXT.Password).FirstOrDefault();
                if (res != null)
                {
                    //login Successfully
                    MessageBox.Show("login Successfully", "Login", MessageBoxButton.OK, MessageBoxImage.Information);
                }
                else
                {
                    //Password or username is not correct
                    MessageBox.Show("Password or username is not correct", "Login", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }

        private void CreatorButton_Click(object sender, RoutedEventArgs e)
        {
            using (var db = new Models.LoginContext())
            {
                db.Blogs.Add(new Models.Person() { Name = "Ali", Username = "ali@gmail.com", Password = "1234" });
                db.Blogs.Add(new Models.Person() { Name = "Hasan", Username = "hasan@gmail.com", Password = "1234" });
                db.Blogs.Add(new Models.Person() { Name = "Hossein", Username = "hossein@gmail.com", Password = "1234" });
                db.Blogs.Add(new Models.Person() { Name = "Maryam", Username = "maryam@gmail.com", Password = "1234" });
                db.SaveChanges();
            }
        }
    }
}
