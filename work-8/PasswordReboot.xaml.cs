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
    /// Логика взаимодействия для PasswordReboot.xaml
    /// </summary>
    public partial class PasswordReboot : Window
    {
        public PasswordReboot()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string phoneReb = phone1.Text;
            if (string.IsNullOrEmpty(phoneReb)) MessageBox.Show("Не заполнены поля");
            else
            {
                if (phones)
                {

                }
            }
        }
    }
}
