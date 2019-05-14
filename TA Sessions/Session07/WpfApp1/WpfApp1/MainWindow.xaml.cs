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
using WpfApp1.Controllers.CExceptions;

namespace WpfApp1
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

        private void CreateSimpleDataInDB_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Controllers.DBController dBController = new Controllers.DBController();
                int number = Int32.Parse(startNumebr.Text);
                for (int i = number; i < number + 10; i++)
                {
                    Controllers.Models.Product product = new Controllers.Models.Product()
                    {
                        Name = "Product" + i.ToString(),
                        NumberOfExsistance = i*2 ,
                        Image = $"https://www.w3schools.com/w3css/img_lights.jpg"
                    };
                    var r = dBController.AddProduct(product);
                    //MessageBox.Show(r.ToString(), "RETURN", MessageBoxButton.OK, MessageBoxImage.Information);
                }
                
            }
            catch (PRODUCT_DUPLICATE_EXCEPTION)
            {
                MessageBox.Show("Product is already exsist in database !", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            catch (Exception)
            {
                 MessageBox.Show("All Exception","Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            
        }

        private void ShowAllProducts_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Controllers.DBController dBController = new Controllers.DBController();
                List<Controllers.Models.Product> products = dBController.AllProducts();
                foreach (var item in products)
                {
                    UC.ProductShowUC productShowUC = new UC.ProductShowUC();
                    productShowUC.AddData(item);
                    Xpanel.Children.Add(productShowUC);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message ,"Error",MessageBoxButton.OK,MessageBoxImage.Error);
            }
            
        }
    }
}
