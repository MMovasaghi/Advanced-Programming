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


namespace WpfApp1.UC
{
    /// <summary>
    /// Interaction logic for ProductShowUC.xaml
    /// </summary>
    public partial class ProductShowUC : UserControl
    {
        private string URL { get; set; }
        public ProductShowUC()
        {
            InitializeComponent();
        }
        private void AddPicture(string URL)
        {
            try
            {
                //Show Image On the screen--------------------------------------------------------------------
                var image = new Image();
                var fullFilePath = URL;

                BitmapImage bitmap = new BitmapImage();
                bitmap.BeginInit();
                bitmap.UriSource = new Uri(fullFilePath, UriKind.Absolute);
                bitmap.EndInit();

                image.Source = bitmap;

                ImageShowStack.Children.Add(image);


            }
            catch (Exception)
            {
                MessageBox.Show("Error While Loading Image", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
        public void AddData(Controllers.Models.Product product)
        {
            URL = product.Image;
            AddPicture(URL);

            Name.Text += product.Name;
            Number.Text += product.NumberOfExsistance;
        }
    }
}
