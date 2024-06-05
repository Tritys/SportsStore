using Microsoft.Win32;
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

namespace SportsStore.Client
{
    /// <summary>
    /// Логика взаимодействия для Profile.xaml
    /// </summary>
    public partial class Profile : Page
    {
        public Profile()
        {
            InitializeComponent();
        }

        private void Button7_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button6_Click(object sender, RoutedEventArgs e)
        {
            NavigationService AppFrame3 = NavigationService.GetNavigationService(this);
            AppFrame3.Navigate(new MainWindow());
        }

        private void Button2_Click(object sender, RoutedEventArgs e)
        {
            NavigationService AppFrame1 = NavigationService.GetNavigationService(this);
            AppFrame1.Navigate(new Clothes_and_Shoes());
        }

        private void Button3_Click(object sender, RoutedEventArgs e)
        {
            NavigationService AppFrame1 = NavigationService.GetNavigationService(this);
            AppFrame1.Navigate(new Sport_Goods());
        }

        private void Button5_Click(object sender, RoutedEventArgs e)
        {
            NavigationService AppFrame1 = NavigationService.GetNavigationService(this);
            AppFrame1.Navigate(new Underwear());
        }

        private void Button8_Click(object sender, RoutedEventArgs e)
        {
            NavigationService AppFrame1 = NavigationService.GetNavigationService(this);
            AppFrame1.Navigate(new For_Children());
        }

        private void Button9_Click(object sender, RoutedEventArgs e)
        {
            NavigationService AppFrame1 = NavigationService.GetNavigationService(this);
            AppFrame1.Navigate(new Basket());
        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Title = "Select a picture";
            op.Filter = "All supported graphics|*.jpg;*.jpeg;*.png|" +
              "JPEG (*.jpg;*.jpeg)|*.jpg;*.jpeg|" +
              "Portable Network Graphic (*.png)|*.png";
            if (op.ShowDialog() == true)
            {
                Image.Source = new BitmapImage(new Uri(op.FileName));
            }
        }

        private void TextBox2_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
