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

namespace SportsStore.Admin
{
    /// <summary>
    /// Логика взаимодействия для Underwear.xaml
    /// </summary>
    public partial class Underwear : Page
    {
        private UnderwearID _car = new UnderwearID();
        public Underwear()
        {
            InitializeComponent();
            DataContext = _car;
            ClothesAndShoes1.ItemsSource = SportsStoreEntities.GetContext().UnderwearID.ToList();
        }

        private void Button3_Click(object sender, RoutedEventArgs e)
        {
            NavigationService AppFrame = NavigationService.GetNavigationService(this);
            AppFrame.Navigate(new Sport_Goods2());
        }

        private void Button8_Click(object sender, RoutedEventArgs e)
        {
            NavigationService AppFrame = NavigationService.GetNavigationService(this);
            AppFrame.Navigate(new For_Children2());
        }

        private void Button10_Click(object sender, RoutedEventArgs e)
        {
            var hotelsForRemoving = ClothesAndShoes1.SelectedItems.Cast<UnderwearID>().ToList();

            if (MessageBox.Show($"Вы точно хотите удалить следующее {hotelsForRemoving.Count()} элементов", "Внимание", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                try
                {
                    SportsStoreEntities.GetContext().UnderwearID.RemoveRange(hotelsForRemoving);
                    SportsStoreEntities.GetContext().SaveChanges();
                    MessageBox.Show("Данные удалены!");

                    ClothesAndShoes1.ItemsSource = SportsStoreEntities.GetContext().UnderwearID.ToList();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            SportsStoreEntities.GetContext().UnderwearID.Add(_car);
            try
            {
                SportsStoreEntities.GetContext().SaveChanges();
                MessageBox.Show("Информация сохранена");
                ClothesAndShoes1.ItemsSource = SportsStoreEntities.GetContext().UnderwearID.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void Page_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (Visibility == Visibility.Visible)
            {
                SportsStoreEntities.GetContext().ChangeTracker.Entries().ToList().ForEach(p => p.Reload());
                ClothesAndShoes1.ItemsSource = SportsStoreEntities.GetContext().UnderwearID.ToList();
            }
        }

        private void Button7_Click(object sender, RoutedEventArgs e)
        {
            NavigationService AppFrame = NavigationService.GetNavigationService(this);
            AppFrame.Navigate(new Profile2());
        }

        private void Button2_Click(object sender, RoutedEventArgs e)
        {
            NavigationService AppFrame = NavigationService.GetNavigationService(this);
            AppFrame.Navigate(new Clothes_and_Shoes2());
        }

        private void Button5_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button9_Click(object sender, RoutedEventArgs e)
        {
            NavigationService AppFrame = NavigationService.GetNavigationService(this);
            AppFrame.Navigate(new Orders2());
        }
    }
}
