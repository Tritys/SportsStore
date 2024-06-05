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
    /// Логика взаимодействия для My_Orders.xaml
    /// </summary>
    public partial class My_Orders : Page
    {
        public My_Orders()
        {
            InitializeComponent();
            ClothesAndShoes1.ItemsSource = SportsStoreEntities.GetContext().BasketID.ToList();
        }

        private void Button7_Click(object sender, RoutedEventArgs e)
        {
            NavigationService App = NavigationService.GetNavigationService(this);
            App.Navigate(new Profile3());
        }

        private void Button2_Click(object sender, RoutedEventArgs e)
        {
            NavigationService App = NavigationService.GetNavigationService(this);
            App.Navigate(new Orders());
        }

        private void Button3_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
