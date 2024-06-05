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

namespace SportsStore.Client
{
    /// <summary>
    /// Логика взаимодействия для Underwear.xaml
    /// </summary>
    public partial class Underwear : Page
    {
        public Underwear()
        {
            InitializeComponent();
            ClothesAndShoes1.ItemsSource = SportsStoreEntities.GetContext().UnderwearID.ToList();
        }

        private void Button7_Click(object sender, RoutedEventArgs e)
        {
            NavigationService AppFrame1 = NavigationService.GetNavigationService(this);
            AppFrame1.Navigate(new Profile());
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

        private void Button4_Click(object sender, RoutedEventArgs e)
        {
            NavigationService AppFrame1 = NavigationService.GetNavigationService(this);
            AppFrame1.Navigate(new Basket());
        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {

        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
