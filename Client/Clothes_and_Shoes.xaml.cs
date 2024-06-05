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
    /// Логика взаимодействия для Clothes_and_Shoes.xaml
    /// </summary>
    public partial class Clothes_and_Shoes : Page
    {
        public Clothes_and_Shoes()
        {
            InitializeComponent();
            ClothesAndShoes1.ItemsSource = SportsStoreEntities.GetContext().ClothesAndShoes.ToList();

        //var allTypes = SportsStoreEntities.GetContext().Types.ToList();

        //    CheckActual.IsChecked = true;



        }
    //  private void Update()
     //   {
       //     var currentTours = SportsStoreEntities.GetContext().Tours.ToList();

        //    currentTours = currentTours.Where(p => p.Name.ToLower().Contains(TextBox.Text.ToLower())).ToList();

        //    if (CheckActual.IsChecked.Value)
        //        currentTours = currentTours.Where(p => p.IsActual).ToList();
        //
         //   ClothesAndShoes1.ItemsSource = currentTours.OrderBy(p => p.ID).ToList();
      //  }
        private void Button1_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button4_Click(object sender, RoutedEventArgs e)
        {
            NavigationService AppFrame1 = NavigationService.GetNavigationService(this);
            AppFrame1.Navigate(new Basket());
        }

        private void Button7_Click(object sender, RoutedEventArgs e)
        {
            NavigationService AppFrame1 = NavigationService.GetNavigationService(this);
            AppFrame1.Navigate(new Profile());
        }

        private void Button2_Click(object sender, RoutedEventArgs e)
        {

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

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            var searchText = TextBox.Text;

            var result = SportsStoreEntities.GetContext().BasketID.Where(p => p.Name.Contains(searchText)).ToList();
            ClothesAndShoes1.ItemsSource = result;
        }
    }
}
