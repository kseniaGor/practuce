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
using System.Windows.Shapes;

namespace WpfApp6
{
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }
        private void Click_login(object sender, RoutedEventArgs e)
        {
            var login = loginBox.Text; var password = passwordBox.Text;
            var context = new AppDbContext();
            var user = context.Users.SingleOrDefault(x => x.login == login && x.password == password); if (user is null)
            {
                result_text.Text = "Неправильный логин или пароль!";
            }
            else
            {
                result_text.Text = "Вы успешно вошли в аккаунт!";
            }
        }
        private void switch_Click(object sender, RoutedEventArgs e)
        {
            Window1 form = new Window1();
            form.Show(); this.Close();
        }
    }
}
