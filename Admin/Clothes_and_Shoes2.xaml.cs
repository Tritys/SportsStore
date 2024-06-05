using SportsStore.ApplicationData;
using SportsStore.Client;
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

namespace SportsStore.Admin
{
    /// <summary>
    /// Логика взаимодействия для Clothes_and_Shoes2.xaml
    /// </summary>
    public partial class Clothes_and_Shoes2 : Page
    {
        private ClothesAndShoes clother = new ClothesAndShoes();
        public Clothes_and_Shoes2()
        {
            InitializeComponent();
            DataContext = clother;
            ClothesAndShoes1.ItemsSource = SportsStoreEntities.GetContext().ClothesAndShoes.ToList();
        }

        private void Button7_Click(object sender, RoutedEventArgs e)
        {
            NavigationService AppFrame1 = NavigationService.GetNavigationService(this);
            AppFrame1.Navigate(new Profile2());
        }

        private void Button2_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button3_Click(object sender, RoutedEventArgs e)
        {
            NavigationService AppFrame1 = NavigationService.GetNavigationService(this);
            AppFrame1.Navigate(new Sport_Goods2());
        }

        private void Button5_Click(object sender, RoutedEventArgs e)
        {
            NavigationService AppFrame1 = NavigationService.GetNavigationService(this);
            AppFrame1.Navigate(new Underwear());
        }

        private void Button8_Click(object sender, RoutedEventArgs e)
        {
            NavigationService AppFrame1 = NavigationService.GetNavigationService(this);
            AppFrame1.Navigate(new For_Children2());
        }

        private void Button9_Click(object sender, RoutedEventArgs e)
        {
            NavigationService AppFrame1 = NavigationService.GetNavigationService(this);
            AppFrame1.Navigate(new Orders2());
        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            SportsStoreEntities.GetContext().ClothesAndShoes.Add(clother);
            try
            {
                SportsStoreEntities.GetContext().SaveChanges();
                MessageBox.Show("Информация сохранена");
                ClothesAndShoes1.ItemsSource = SportsStoreEntities.GetContext().ClothesAndShoes.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void Button10_Click(object sender, RoutedEventArgs e)
        {
            var hotelsForRemoving = ClothesAndShoes1.SelectedItems.Cast<ClothesAndShoes>().ToList();

            if (MessageBox.Show($"Вы точно хотите удалить следующее {hotelsForRemoving.Count()} элементов", "Внимание", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                try
                {
                    SportsStoreEntities.GetContext().ClothesAndShoes.RemoveRange(hotelsForRemoving);
                    SportsStoreEntities.GetContext().SaveChanges();
                    MessageBox.Show("Данные удалены!");

                    ClothesAndShoes1.ItemsSource = SportsStoreEntities.GetContext().ClothesAndShoes.ToList();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
        }

        private void Page_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (Visibility == Visibility.Visible)
            {
                SportsStoreEntities.GetContext().ChangeTracker.Entries().ToList().ForEach(p => p.Reload());
                ClothesAndShoes1.ItemsSource = SportsStoreEntities.GetContext().ClothesAndShoes.ToList();
            }
        }

        private void ClothesAndShoes1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
