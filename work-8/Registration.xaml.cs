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
using System.Text.RegularExpressions;
using System.Security.Cryptography;

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
            string role = roles.SelectedItem as string;
            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(lastname) || string.IsNullOrEmpty(phone) || string.IsNullOrEmpty(login)
               || string.IsNullOrEmpty(role))
            {
                MessageBox.Show("Не все поля заполнены!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                List<string> errors = new List<string>();
                if (name.Length > 255) errors.Add("Слишком длинное имя!");
                if (lastname.Length > 255) errors.Add("Слишком длинная фамилия!");
                if (middlename.Length > 255) errors.Add("Слишком длинная фамилия!");
                if (login.Length > 255) errors.Add("Слишком длинное имя!");
                if (Data.logins.Contains(login)) errors.Add("Пользователь с таким логином уже существует!");
                string pattern = @"((\+7|7|8)+([0-9]){10})$";
                Regex regex = new Regex(pattern);
                if (!(regex.IsMatch(phone))) errors.Add("Неверный формат номера телефона!");
                else if (Data.phones.Contains(phone)) errors.Add("Пользователь с таким номером телефона уже существует!");
                if (errors.Count < 1)
                {
                    User us;
                    if (role == "Администратор")
                    {
                        us = new User(name, lastname, middlename, login, phone, DateTime.Today.ToString(), Role.Admin);
                    }
                    else
                    {
                        us = new User(name, lastname, middlename, login, phone, DateTime.Today.ToString(), Role.Menager);
                    }
                    Data.users[login] = us;
                    Data.usersPh[phone] = us;
                    Data.logins.Add(login);
                    Data.phones.Add(phone);
                    string passlist = default;
                    foreach (string passwor in User.passwords)
                    {
                        passlist += $"{passwor}\n";
                    }
                    MessageBox.Show("Список ваших паролей:\n" +
                        passlist, $"Успешная регистрация под ролью {role}!", MessageBoxButton.OK, MessageBoxImage.Information);
                    Close();
                }
                else
                {
                    string errorslist = default;
                    foreach (string error in errors)
                    {
                        errorslist += $"{error}{Environment.NewLine}";
                    }
                    MessageBox.Show(errorslist, "Ошибки", MessageBoxButton.OK, MessageBoxImage.Error);
                }
                    
            }
        }
    }
}
