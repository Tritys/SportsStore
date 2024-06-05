﻿using SportsStore.Admin;
using SportsStore.ApplicationData;
using SportsStore.Client;
using SportsStore.Delivery;
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

namespace SportsStore
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            AppConnect.modelOdb = new SportsStoreEntities();


        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            string input = TextBox1.Text;
            string englishLetters = "@abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890/.?,";

            foreach (char c in input)
            {
                if (!englishLetters.Contains(c))
                {
                    TextBox1.Text = TextBox1.Text.Remove(TextBox1.Text.IndexOf(c), 1);
                    TextBox1.SelectionStart = TextBox1.Text.Length;
                }
            }
        }

        private void PasswordBox1_PasswordChanged(object sender, RoutedEventArgs e)
        {
            string input = PasswordBox1.Password;
            string englishLetters = "@abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890/.?,";

            foreach (char c in input)
            {
                if (!englishLetters.Contains(c))
                {
                    TextBox1.Text = TextBox1.Text.Remove(TextBox1.Text.IndexOf(c), 1);
                    TextBox1.SelectionStart = TextBox1.Text.Length;
                }
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TextBox1.Text))
            {
                // Вывод ошибки
                MessageBox.Show("Ошибка: отсутствует E-mail");
            }
            else if (string.IsNullOrWhiteSpace(PasswordBox1.Password))
            {
                MessageBox.Show("Ошибка: отсутствует пароль");
            }
            else
            {
                try
                {
                    var userObj = AppConnect.modelOdb.User.FirstOrDefault(x => x.Login == TextBox1.Text && x.Password == PasswordBox1.Password);
                    if (userObj == null)
                    {
                        MessageBox.Show("Такого пользователя нет", "Ошибка при авторизации",
                            MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                    else
                    {
                        switch (userObj.Role)
                        {
                            case "Администратор":
                                MessageBox.Show("Здравствуйте Администратор" + "!",
                                "Уведомление", MessageBoxButton.OK, MessageBoxImage.Information);
                                NavigationService AppFrame1 = NavigationService.GetNavigationService(this);
                                AppFrame1.Navigate(new Profile2());
                                break;

                            case "Доставщик":
                                MessageBox.Show("Здравствуйте Доставщик" + "!",
                                "Уведомление", MessageBoxButton.OK, MessageBoxImage.Information);
                                NavigationService AppFrame2 = NavigationService.GetNavigationService(this);
                                AppFrame2.Navigate(new Profile3());
                                break;
                            case "Клиент":
                                MessageBox.Show("Здравствуйте Клиент" + "!",
                                "Уведомление", MessageBoxButton.OK, MessageBoxImage.Information);
                                NavigationService AppFrame3 = NavigationService.GetNavigationService(this);
                                AppFrame3.Navigate(new Profile());
                                break;
                            default:
                                MessageBox.Show("Данные не обнаружены!", "Уведомление", MessageBoxButton.OK, MessageBoxImage.Warning);
                                break;
                        }

                    }
                }
                catch (Exception Ex)
                {
                    MessageBox.Show("Ошибка " + Ex.Message.ToString() + "Критическая работа приложения!",
                        "Уведомление", MessageBoxButton.OK, MessageBoxImage.Warning);
                }
            }
        }

        private void FrmMain_Navigated(object sender, NavigationEventArgs e)
        {

        }
    }
}
