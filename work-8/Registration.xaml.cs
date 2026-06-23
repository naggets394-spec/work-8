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

namespace work_8
{
    /// <summary>
    /// Логика взаимодействия для Registration.xaml
    /// </summary>
    public partial class Registration : Window
    {
        public Registration()
        {
            InitializeComponent();
            roles.Items.Add("Менеджер");
            roles.Items.Add("Администратор");
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string name = name1.Text;
            string lastname = lastname1.Text;
            string middlename = middlename1.Text;
            string phone = phone1.Text;
            string login = login2.Text;
            string password = password2.Password;
            string passwordRep = passwordRep1.Password;
            string role = roles.SelectedItem as string;
            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(lastname) || string.IsNullOrEmpty(phone) || string.IsNullOrEmpty(login) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(passwordRep) 
               || string.IsNullOrEmpty(role))
            {
                MessageBox.Show("Не все поля заполнены!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                
            }
        }
    }
}
