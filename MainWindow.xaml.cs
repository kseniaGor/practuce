﻿using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp6
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        
        private void login_Click (object sender, RoutedEventArgs e)
        {
            string login = txtLogin.Text;
            string password = txtpassword.Text;
            if (login == "admin" && password == "12345")
            {
                MessageBox.Show("авторизация успешна");
            }
            else
            {
                MessageBox.Show("неверный логин или пароль");
            }
        }

        private void regicter_click(object sender, RoutedEventArgs e)
        {

        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}