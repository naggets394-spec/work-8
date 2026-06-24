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

namespace work_8
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        User user = new User("Кверк", "Кверков", "Кверкович", "12345", "89021354234", "password", "12.12.2025", "Администратор");
        static public HashSet<string> logins = new HashSet<string>();
        static public Dictionary<string, string> passwords = new Dictionary<string, string>();
        static public HashSet<string> phones { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            logins.Add(user.login);
            passwords[user.login] = user.password;
            phones.Add(user.phone);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Hide();
            Registration registration = new Registration();
            registration.ShowDialog();
            Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Hide();
            PasswordReboot passreb = new PasswordReboot();
            passreb.ShowDialog();
            Show();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {

            string login1 = loginBox.Text;
            string password1 = passBox.Password;
            if (!string.IsNullOrEmpty(login1) || !string.IsNullOrEmpty(password1))
            {
                if (logins.Contains(login1))
                {
                    if (passwords[user.login] == password1)
                    {
                        Hide();
                        Main main = new Main();
                        main.Show();
                    }
                }
                else MessageBox.Show("Пользователя с таким логином не существует!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);

            }
            else MessageBox.Show("Поле логина или пароля не заполнено", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);

        }
    }
}
