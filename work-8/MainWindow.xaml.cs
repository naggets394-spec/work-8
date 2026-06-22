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
        User user = new User();
        HashSet<string> logins = new HashSet<string>();
        Dictionary<string, string> passwords = new Dictionary<string, string>();
        
        public MainWindow()
        {
            InitializeComponent();
            logins.Add(user.login);
            passwords[user.login] = user.password;
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

            string login = loginBox.Text;
            string password = passBox.Password;
            if (string.IsNullOrEmpty(login))
            {
                if (logins.Contains(login))
                {
                    if (passwords[user.login] == password)
                    {
                        MessageBox.Show("Ура!");
                    }
                }
            }
            //MessageBox.Show()

        }
    }
}
