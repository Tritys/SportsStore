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
    /// Логика взаимодействия для For_Children2.xaml
    /// </summary>
    public partial class For_Children2 : Page
    {
        private ForChildrenID clother = new ForChildrenID();
        public For_Children2()
        {
            InitializeComponent();
            DataContext = clother;
            ClothesAndShoes1.ItemsSource = SportsStoreEntities.GetContext().ForChildrenID.ToList();
        }

        private void Button7_Click(object sender, RoutedEventArgs e)
        {
            NavigationService AppFrame1 = NavigationService.GetNavigationService(this);
            AppFrame1.Navigate(new Profile2());
        }

        private void Button2_Click(object sender, RoutedEventArgs e)
        {
            NavigationService AppFrame1 = NavigationService.GetNavigationService(this);
            AppFrame1.Navigate(new Clothes_and_Shoes2());
        }

        private void Button3_Click(object sender, RoutedEventArgs e)
        {
            NavigationService AppFrame1 = NavigationService.GetNavigationService(this);
            AppFrame1.Navigate(new For_Children2());
        }

        private void Button5_Click(object sender, RoutedEventArgs e)
        {
            NavigationService AppFrame1 = NavigationService.GetNavigationService(this);
            AppFrame1.Navigate(new Underwear());
        }

        private void Button8_Click(object sender, RoutedEventArgs e)
        {
            SportsStoreEntities.GetContext().ForChildrenID.Add(clother);
            try
            {
                SportsStoreEntities.GetContext().SaveChanges();
                MessageBox.Show("Информация сохранена");
                ClothesAndShoes1.ItemsSource = SportsStoreEntities.GetContext().ForChildrenID.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void Button9_Click(object sender, RoutedEventArgs e)
        {
            NavigationService AppFrame1 = NavigationService.GetNavigationService(this);
            AppFrame1.Navigate(new Basket());
        }

        private void Button10_Click(object sender, RoutedEventArgs e)
        {
            var hotelsForRemoving = ClothesAndShoes1.SelectedItems.Cast<ForChildrenID>().ToList();

            if (MessageBox.Show($"Вы точно хотите удалить следующее {hotelsForRemoving.Count()} элементов", "Внимание", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                try
                {
                    SportsStoreEntities.GetContext().ForChildrenID.RemoveRange(hotelsForRemoving);
                    SportsStoreEntities.GetContext().SaveChanges();
                    MessageBox.Show("Данные удалены!");

                    ClothesAndShoes1.ItemsSource = SportsStoreEntities.GetContext().ForChildrenID.ToList();
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
                ClothesAndShoes1.ItemsSource = SportsStoreEntities.GetContext().ForChildrenID.ToList();
            }
        }
    }
}
