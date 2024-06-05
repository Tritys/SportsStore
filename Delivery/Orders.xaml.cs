using SportsStore.ApplicationData;
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

namespace SportsStore.Delivery
{
    /// <summary>
    /// Логика взаимодействия для Orders.xaml
    /// </summary>
    public partial class Orders : Page
    {
        public Orders()
        {
            InitializeComponent();
            ClothesAndShoes1.ItemsSource = SportsStoreEntities.GetContext().OrderID.ToList();
        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button2_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button7_Click(object sender, RoutedEventArgs e)
        {
            NavigationService App = NavigationService.GetNavigationService(this);
            App.Navigate(new Profile3());
        }

        private void Button3_Click(object sender, RoutedEventArgs e)
        {
            NavigationService App = NavigationService.GetNavigationService(this);
            App.Navigate(new My_Orders());
        }

        private void ClothesAndShoes1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
